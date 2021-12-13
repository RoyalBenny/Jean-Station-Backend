using JeanStationModels;
using System.Collections.Generic;

namespace DAL
{
    public interface IOrderRepository
    {
        Order AddOrder(Order order);
        List<Order> GetAllOrders();
        Order GetOrder(string id);
        bool UpdateOrder(string id, Order order);
    }
}