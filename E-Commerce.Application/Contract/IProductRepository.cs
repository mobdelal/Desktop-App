using E_commerce.Model;
using E_Commerce.DTO.Product;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface IProductRepository : IGenaricrepository<Product>
    {
        public Product search(string proName);
    }
}
