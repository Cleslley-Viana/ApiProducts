using ApiProducts.Models;
using ApiProducts.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService service)
        {
            _productService = service;
        }

        [HttpGet("id")]
       public IActionResult Get([FromQuery] int Id)
        {
            return Ok(_productService.Get(Id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }


        [HttpPost]
        public IActionResult Post(Product product)
        {
            return Created("", _productService.Save(product));
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            return Ok(_productService.Change(product));
        }

        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            _productService.Delete(Id);

            return Ok();
        }
    }
}
