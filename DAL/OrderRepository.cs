using JeanStationModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class OrderRepository : IOrderRepository
    {

        private readonly JeanStationDbContext _context;
        public OrderRepository(JeanStationDbContext con)
        {
            _context = con;
        }

        public Order AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order;

        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public List<Order> GetOrdersByUserId(string userId)
        {
            return _context.Orders.Where( o=> o.UserId == userId).ToList(); 
        }
        public Order GetOrder(string id)
        {
            return _context.Orders.FirstOrDefault(o => o.Id == id);
        }

        public bool UpdateOrder(string id, Order order)
        {
            var o = _context.Orders.FirstOrDefault(x => x.Id == id);
            if (o == null) return false;
            o.status = order.status;
            _context.Entry(o).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
