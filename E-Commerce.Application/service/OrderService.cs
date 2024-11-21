using AutoMapper;
using E_Commerce.Application.Contract;
using E_Commerce.DTO.Order;
using E_Commerce.DTO.OrderItem;
using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using E_Commerce.DTO.Category;


namespace E_Commerce.Application.service
{
    public class OrderService : IOrderService
    {
        public IOrderRepository _orderRepository { get; set; }
        public IProductRepository _productRepository { get; set; }
        public IOrderDetailRepository _orderDetailRepository { get; set; }
        public ICategoryRepository _categoryRepository { get; set; }
        public IUserRepository _userRepository { get; set; }
        private readonly IMapper Mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper, IOrderDetailRepository orderDetailRepository, IProductRepository productRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            _orderRepository = orderRepository;
            Mapper = mapper;
            _orderDetailRepository = orderDetailRepository;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
        }
        public GetMasterOrderDTO CreateMasterOrder(CreateOrderMasterDTO _createMasterOrderDTO)
        {
            if (_createMasterOrderDTO != null)
            {

                Order order = Mapper.Map<Order>(_createMasterOrderDTO);


                order.Status = Status.InCart;

                var savedOrder = _orderRepository.create(order);

                _orderRepository.Save();
                return Mapper.Map<GetMasterOrderDTO>(savedOrder);
            }
            return null;
        }


        public ICollection<OrderDetail> CreateOrderDetail(CreateOrderDetailDTO OrderDetailDTO)
        {
            if (OrderDetailDTO != null)
            {

                OrderDetail orderDetail = Mapper.Map<OrderDetail>(OrderDetailDTO);
                Product product = _productRepository.get(orderDetail.ProductID);
                if (product == null)
                {
                    orderDetail.Product = null;
                }
                else
                {
                    orderDetail.ProductID = product.ProductID;
         

                }
               
                product.UnitsInStock -= orderDetail.Quantity;
                product.Price = orderDetail.Quantity * product.Price;
                orderDetail.UnitPrice = product.Price;
                OrderDetail savedOrderDetail = _orderDetailRepository.create(orderDetail);
                _orderDetailRepository.Save();
                ICollection<OrderDetail> Saved = new Collection<OrderDetail>();
                
                Saved.Add(savedOrderDetail);
                return Saved;


            }
            return null;
        }
        public void Updated(GetMasterOrderDTO order)
        {

            Order Order = Mapper.Map<Order>(order);
            _orderRepository.update(Order);
            
            _orderRepository.Save();

        }



        public List<GetMasterOrderDTO> GetAll( Status status ,int customerId)
        {
            var orders = _orderRepository.getAll().AsNoTracking()
                .Where(P => P.Status == status && P.UserID == customerId)
                .Select(P => Mapper.Map<GetMasterOrderDTO>(P)).ToList();
            return orders;
        }


        public List<GetMasterOrderDTO> GetOrdersByCustomer(Status status, int customerId)
        {
            var orders = _orderRepository.getAll().AsNoTracking()
                .Where(o => o.User.UserID == customerId && o.Status == Status.Processing || o.Status == Status.Delivering)
                .ToList();

            return Mapper.Map<List<GetMasterOrderDTO>>(orders);
        }

        public void UpdateOrder(CreateOrderMasterDTO orderdto)
        {
            var order = _orderRepository.get(orderdto.OrderID);
            if (order == null)
            {
                return;
            }

            order.Status = orderdto.OrderStatus;

            _orderRepository.update(order);
            _orderRepository.Save();
        }

    }
}