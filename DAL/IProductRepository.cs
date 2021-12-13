using JeanStationModels;
using System.Collections.Generic;

namespace DAL
{
    public interface IProductRepository
    {
        Product AddProduct(Product product);
        bool DeleteProduct(string id);
        List<Product> GetAllProducts();
        Product GetProduct(string id);
        bool UpdateProduct(string id, Product p);
    }
}