using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IOrderService
    {
        Order AddOrder(Order order);
        List<Order> GetAllOrders();
        List<Order> GetOrdersByUserId(string userId);
        Order GetOrder(string id);
        bool UpdateOrder(string id, Order order);

    }
}
