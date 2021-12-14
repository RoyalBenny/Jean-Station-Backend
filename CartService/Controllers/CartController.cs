using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using JeanStationModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CartService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;
        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        // GET: api/<CartController>
        [HttpGet]
        public List<Cart> Get()
        {
            try
            {
                return _cartService.GetAllCarts();
            }
            catch (Exception ex)
            {
                throw new Exception ( ex.Message);
            }
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public Cart Get(string userid)
        {
            try
            {
                return _cartService.GetCartByUserId(userid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // POST api/<CartController>
        [HttpPost]
        public IActionResult AddCart([FromBody] Cart cart)
        {
            
                try
                {
                    Cart obj =_cartService.AddCart(cart);
                    return Created("", obj);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
           
        }

        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                 _cartService.DeleteCart(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
