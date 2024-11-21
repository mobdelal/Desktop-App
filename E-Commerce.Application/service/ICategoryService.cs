using E_Commerce.DTO.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.service
{
    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetAllCategories();
        CategoryDTO GetCategoryById(int id);
        void CreateCategory(CategoryDTO categoryDto);
        void UpdateCategory(CategoryDTO categoryDto);
        void DeleteCategory(int id);
    }
}
