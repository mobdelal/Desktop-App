using E_commerce.Model;
using E_Commerce.DTO.Order;
using E_Commerce.DTO.OrderItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.service
{
    public interface IOrderService
    {
        public GetMasterOrderDTO CreateMasterOrder(CreateOrderMasterDTO _createOrderDTO);
        public ICollection<OrderDetail> CreateOrderDetail(CreateOrderDetailDTO OrderDetailDTO);

        public List<GetMasterOrderDTO> GetAll(Status status, int customerId);
        public List<GetMasterOrderDTO> GetOrdersByCustomer(Status status, int customerId);
        public void Updated(GetMasterOrderDTO MasterOrder);

        public void UpdateOrder(CreateOrderMasterDTO orderdto);




    }
}
