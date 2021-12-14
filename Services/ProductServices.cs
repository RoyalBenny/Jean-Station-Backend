using DAL;
using JeanStationModels;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ProductServices : IProductService
    {
        private readonly IProductRepository _repo;
        public ProductServices(IProductRepository repo)
        {
            _repo = repo;
        }
        public Product AddProduct(Product product)
        {
            try
            {
                return _repo.AddProduct(product);
            }catch(Exception ex)
            {
                throw new Exception();
            }
        }

        public bool DeleteProduct(string id)
        {
            try
            {
               return _repo.DeleteProduct(id);
            }catch (Exception ex)
            {
                return false;
            }
        }

        public List<Product> GetAllProducts()
        {
            try
            {
                return _repo.GetAllProducts();
            }catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public Product GetProductById(string id)
        {
            try
            {
                return _repo.GetProduct(id);
            }catch(Exception e)
            {
                throw e;
            }
        }

        public bool UpdateProduct(string id, Product product)
        {
            try
            {
                return _repo.UpdateProduct(id, product);
            }catch(Exception ex){
                throw ex;
            }
        }
    }
}
