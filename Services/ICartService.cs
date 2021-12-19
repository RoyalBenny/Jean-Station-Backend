using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICartService
    {
        Cart AddCart(Cart cart);
        bool DeleteCart(string id);
        List<Cart> GetAllCarts();
        public List<Cart> GetCartByUserId(string userid);
    }
}
