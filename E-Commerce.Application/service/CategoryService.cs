using E_Commerce.Application.Contract;
using E_Commerce.DTO.Category;
using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace E_Commerce.Application.service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository , IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public void CreateCategory(CategoryDTO categoryDto)
        {
           
            Categoryy category = _mapper.Map<Categoryy>(categoryDto);

            _categoryRepository.create(category);
            _categoryRepository.Save();
        }

        public void DeleteCategory(int id)
        {
            var category = _categoryRepository.get(id);
            if (category == null)
            {
                return;
            }

            _categoryRepository.delete(category);
            _categoryRepository.Save();

        }

        public IEnumerable<CategoryDTO> GetAllCategories()
        {
            return _categoryRepository.getAll().Select(category => new CategoryDTO
            {
                CategoryID = category.CategoryID,
                Name = category.Name,
                Description = category.Description
            });
        }

        public CategoryDTO GetCategoryById(int id)
        {
            var category = _categoryRepository.get(id);
            if (category == null)
            {
                return null;
            }

            return new CategoryDTO
            {
                CategoryID = category.CategoryID,
                Name = category.Name,
                Description = category.Description
            };
        }

        public void UpdateCategory(CategoryDTO categoryDto)
        {
            var category = _categoryRepository.get(categoryDto.CategoryID);
            if (category == null)
            {
                return;
            }

            category.Name = categoryDto.Name;
            category.Description = categoryDto.Description;

            _categoryRepository.update(category);
            _categoryRepository.Save();
        }
    }
}
