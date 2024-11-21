using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTO.OrderItem
{

    public record GetAllOrderDetailDTO
    {

        public string ProductName { get; init; }
        public int? Quantity { get; init; }
        public decimal? UnitPrice { get; init; }
    }

}
