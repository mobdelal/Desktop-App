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
    public class OrderDetailRepository : GenaricRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(EContext eContext) : base(eContext) { }

    }
}
