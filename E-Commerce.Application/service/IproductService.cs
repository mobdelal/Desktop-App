using E_commerce.Model;
using E_Commerce.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.service
{
    public interface IproductService
    {
        public CreateProductDTO AddProduct(CreateProductDTO Productdto);
        public List<GetAllProductsDTO> GetAllPagination(int Count, int PageNumber);
        public List<GetAllProductsDTO> FilterByCategory(string CategoryName, int Count, int PageNumber);
        public List<GetAllProductsDTO> FilterByPrice(decimal Price, int Count, int PageNumber);
        public List<GetAllProductsDTO> Searh(string ProductName);
        public ProductDetailsDTO GetProductDetails(GetAllProductsDTO Product);
        public void Deleteproduct(int Id);

        public void UpdateProducts(ProductDetailsDTO productdto);




    }
}
