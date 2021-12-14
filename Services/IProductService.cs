using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        bool UpdateProduct(string id, Product product);
        bool DeleteProduct(string id);

        List<Product> GetAllProducts();
        Product GetProductById(string id);
    }
}
