using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IProductService
    {
        Product AddProduct(Product product);
        Product UpdateProduct(string id, Product product);
        Product DeleteProduct(string id);

        Product GetAllProducts();
        Product GetProductById(string id);
    }
}
