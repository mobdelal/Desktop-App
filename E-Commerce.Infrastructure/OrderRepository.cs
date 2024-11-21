using E_commerce.Model;
using E_Commerce.Application.Contract;
using E_Commerce.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class OrderRepository:GenaricRepository<Order> , IOrderRepository
    {
        public OrderRepository(EContext eContext):base(eContext) { }
    }
}
