using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface ICategoryRepository : IGenaricrepository<Categoryy>
    {
        Categoryy GetCategoryByName(string name);
    }
}
