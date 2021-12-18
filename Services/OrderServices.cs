using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using JeanStationModels;

namespace Services
{
    public class OrderServices : IOrderService
    {
        private readonly IOrderRepository _repo;
        public OrderServices(IOrderRepository repo)
        {
            _repo = repo;
        }
        public Order AddOrder(Order order)
        {
            try
            {
                order.Id = null;
                order.Date = DateTime.Now;
                return _repo.AddOrder(order);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Order> GetAllOrders()
        {
            try
            {
                return _repo.GetAllOrders();
            }catch (Exception ex)
            {
               throw ex;
            }
        }

        public Order GetOrder(string id)
        {
            try { return _repo.GetOrder(id); } 
            catch (Exception ex)
            { throw new Exception(ex.Message); }
        }

        public List<Order> GetOrdersByUserId(string userId)
        {
            try
            {
                return _repo.GetOrdersByUserId(userId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateOrder(string id, Order order)
        {
            try
            {
                return _repo.UpdateOrder(id, order);
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}
