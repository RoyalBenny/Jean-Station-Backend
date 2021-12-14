using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using DAL;
using JeanStationModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public List <Product> Get()
        {
            try
            {
                return _productService.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(string id)
        {
            try
            {
                return _productService.GetProductById(id);
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            try
            {
                Product obj= _productService.AddProduct(product);
                return  Created("", obj);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateProduct ( [FromBody] Product product, string id)
        {
            try
            {
                _productService.UpdateProduct(id, product);
                return Ok(true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(string id)
        {
            try
            {
                _productService.DeleteProduct(id);
                return Ok(true);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
