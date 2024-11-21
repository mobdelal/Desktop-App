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
    public class ProductRepository : GenaricRepository<Product> , IProductRepository
    {
        private readonly EContext context;
        public ProductRepository(EContext eContext):base(eContext) { }

        public Product search(string Title)
        {
            return context.Products.Find(Title);
        }

    }
}
