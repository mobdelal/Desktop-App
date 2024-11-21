using E_commerce.Model;
using E_Commerce.Application.Contract;
using E_Commerce.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class CategoryRepository : GenaricRepository<Categoryy>, ICategoryRepository
    {
        private readonly EContext _context;

       
        public CategoryRepository(EContext context) : base(context) {

            context = _context;
           
        }
        public Categoryy GetCategoryByName(string name)
        {
            return dbset.FirstOrDefault(c => c.Name == name);
        }
    }
}
