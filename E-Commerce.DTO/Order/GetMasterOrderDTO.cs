using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTO.Order
{
    public class GetMasterOrderDTO
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; init; } = DateTime.Now;
        public Status OrderStatus { get; set; }
        public decimal? TotalPrice { get; set; }
        public int UserID { get; init; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
