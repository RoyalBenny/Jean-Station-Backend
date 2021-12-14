using DAL;
using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _repo;

        public CartService(ICartRepository repo)
        {
            _repo = repo;
        }
        public bool DeleteCart(string id)
        {
            try
            {
                return _repo.DeleteCart(id);
            }catch(Exception ex)
            {
                return false;
            }
        }

        public List<Cart> GetAllCarts()
        {
            try
            {
                return _repo.GetAllCarts(); 
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public Cart GetCartByUserId(string userid)
        {
            try
            {
                return _repo.GetCartByUserId(userid);
            }catch (Exception ex)
            {
               throw new Exception(ex.Message);
            }
        }
    }
}
