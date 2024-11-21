using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTO.OrderItem
{
    public record CreateOrderDetailDTO
    {
        public int OrderID { get; set; }
        public int ProductId { get; init; }
        public int? Quantity { get; init; }
        public decimal? UnitPrice { get; init; }
    }
}
