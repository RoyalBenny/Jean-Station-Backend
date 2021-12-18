using JeanStationModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class ProductRepository : IProductRepository
    {
        private readonly JeanStationDbContext _context;
        public ProductRepository(JeanStationDbContext con)
        {
            _context = con;
        }

        public Product AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(string id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateProduct(string id, Product p)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return false;
            product.Name = p.Name;
            product.Description = p.Description;
            product.Price = p.Price;
            product.Discount = p.Discount;
            product.ImageUrl = p.ImageUrl;
            product.section = p.section;
            product.category = p.category;
            product.Quantity = p.Quantity;
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

        public bool DeleteProduct(string id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return false;
            _context.Products.Remove(product);
            _context.SaveChanges();
            return true;

        }

    }
}
