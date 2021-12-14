using JeanStationModels;
using System.Collections.Generic;

namespace DAL
{
    public interface ICartRepository
    {
        bool DeleteCart(string id);
        List<Cart> GetAllCarts();
        Cart GetCartByUserId(string userid);
    }
}