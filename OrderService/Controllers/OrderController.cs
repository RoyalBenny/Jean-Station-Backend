using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using JeanStationModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public List<Order> GetAllOrders()
        {
            try
            {
                return _orderService.GetAllOrders();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<OrderController>/5
        [HttpPost("userorder")]
       
        public IActionResult GetOrdersByUserId([FromBody] User user)
        {
            try
            {
                return Ok(_orderService.GetOrdersByUserId(user.Id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        // POST api/<OrderController>
        [HttpPost]
        public IActionResult AddOrder([FromBody] Order order)
        {
            try
            {
                Order obj = _orderService.AddOrder(order);
                return Ok(true);
            }
            catch(Exception x)
            {
                throw x;
            }
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateStatus(string id, [FromBody] Order order)
        {
            try
            {
                 _orderService.UpdateOrder(id, order);
                return Ok(true);
            }
            catch (Exception ex)
            {
                 throw ex;
            }
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void DeleteOrder(string id)
        {
            
        }
    }
}
