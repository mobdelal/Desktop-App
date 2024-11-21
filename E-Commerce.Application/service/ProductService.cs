using E_Commerce.Application.Contract;
using E_Commerce.DTO.Product;
using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace E_Commerce.Application.service
{
    public class ProductService : IproductService
    {
        private IProductRepository ProductRepositor;
        private readonly IMapper Mapper;

        public ProductService(IProductRepository _productRepositor, IMapper _Mapper)
        {
            ProductRepositor = _productRepositor;
            Mapper = _Mapper;
        }
        public CreateProductDTO AddProduct(CreateProductDTO Productdto)
        {
            Product product = Mapper.Map<Product>(Productdto);
            if (Productdto != null)
            {
                Product Prod = ProductRepositor.create(product);
                ProductRepositor.SaveChanges();
                return Mapper.Map<CreateProductDTO>(Prod);
            }
            return null;
        }

        public List<GetAllProductsDTO> FilterByCategory(string CategoryName, int Count, int PageNumber)
        {
            var ProductsPages = ProductRepositor.getAll().Skip(Count * (PageNumber - 1)).Take(Count).Where(b => b.Category.Name == CategoryName)
                .Select(b => new GetAllProductsDTO
                {
                    Id =b.ProductID,
                    Name = b.Name,
                    ImageURL = b.ImageURL,
                    Price = b.Price,
                }).ToList();
            ProductRepositor.SaveChanges();
            return ProductsPages;
        }

        public List<GetAllProductsDTO> FilterByPrice(decimal Price, int Count, int PageNumber)
        {
            var ProductsPages = ProductRepositor.getAll().Skip(Count * (PageNumber - 1)).Take(Count).Where(b => b.Price <= Price)
                .Select(b => new GetAllProductsDTO
                {
                    Id = b.ProductID,
                    Name = b.Name,
                    ImageURL = b.ImageURL,
                    Price = b.Price,
                }).ToList();
            ProductRepositor.SaveChanges();
            return ProductsPages;
        }


        public List<GetAllProductsDTO> GetAllPagination(int Count, int PageNumber)
        {
            var ProductsPages = ProductRepositor.getAll().Skip(Count * (PageNumber - 1)).Take(Count)
                .Select(b => new GetAllProductsDTO
                {
                    Id = b.ProductID,
                    Name = b.Name,
                    ImageURL = b.ImageURL,
                    Price = b.Price,
                }).ToList();
            ProductRepositor.SaveChanges();
            return ProductsPages;
        }

        public List<GetAllProductsDTO> Searh(string ProductName)
        {
            var Targeted = ProductRepositor.getAll().Where(p=> p.Name == ProductName)
                .Select(p => new GetAllProductsDTO
                {
                    Id=p.ProductID,
                    Name=p.Name,
                    Price=p.Price,
                    ImageURL=p.ImageURL,
                }).ToList();
            return Targeted;
        }

        public ProductDetailsDTO GetProductDetails(GetAllProductsDTO Product)
        {
            var p = (ProductRepositor.get(Product.Id));
            var selectedProduct = new ProductDetailsDTO
            {
                Id = p.ProductID,
                Name = p.Name,
                Price = p.Price,
                ImageURL = p.ImageURL,
                Category = p.Category,
                UnitsInStock = p.UnitsInStock,
                Discount = p.Discount,
            };
            return selectedProduct;
        }

        public void Deleteproduct(int Id)
        {
            var Product = ProductRepositor.get(Id);
            if (Product == null)
            {
                return;
            }

            ProductRepositor.delete(Product);
            ProductRepositor.Save();



        }

        public void UpdateProducts(ProductDetailsDTO productdto)
        {
            var product = ProductRepositor.get(productdto.Id);
            if (product == null)
            {
                return;
            }
            product.CategoryID = productdto.CategoryID;
            product.Name = productdto.Name;
            product.ProductID = productdto.Id;
            product.UnitsInStock = productdto.UnitsInStock;
            product.Price = productdto.Price;
            product.ImageURL = productdto.ImageURL;
            product.Category = productdto.Category;
            product.UnitsInStock = productdto.UnitsInStock;
            product.Discount = productdto.Discount; 

            

            ProductRepositor.update(product);
            ProductRepositor.SaveChanges();
        }
    }
}
