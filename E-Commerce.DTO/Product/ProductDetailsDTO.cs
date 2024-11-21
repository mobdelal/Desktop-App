using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTO.Product
{
    public record ProductDetailsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int CategoryID { get; set; }

        public string ImageURL { get; set; }
        public Categoryy Category { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discount { get; set; }
    }
}
