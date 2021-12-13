using System;
using System.Collections.Generic;
using System.Text;
using JeanStationModels;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL
{
    public class CartRepository : ICartRepository
    {
        private readonly JeanStationDbContext _context;
        public CartRepository(JeanStationDbContext con)
        {
            _context = con;
        }
        public List<Cart> GetAllCarts()
        {
            return _context.Carts.ToList();
        }
        public Cart GetCartByUserId(string userid)
        {
            return _context.Carts.FirstOrDefault(x => x.UserId == userid);
        }
        public bool DeleteCart(string id)
        {
            var cart = _context.Carts.FirstOrDefault(x => x.Id == id);
            if (cart == null) return false;
            _context.Carts.Remove(cart);
            _context.SaveChanges();
            return true;

        }
    }
}
