using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.BusinessLayer.Abstract;
using Northwind.Core.Utilies.Results;
using Northwind.EntitiesLayer.Concrete;
namespace Northwind.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetList()
        {

            var result = _productService.GetList();
            if(result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetListByCategory/{categoryId}")]
        public IActionResult GetListByCategory(int categoryId)
        {

            var result = _productService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("GetById/{productId}")]
        public IActionResult GetById(int productId)
        {

            var result = _productService.GetById(productId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Add")]
        public IActionResult Add(Product product)
        {

            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Update")]
        public IActionResult Update(Product product)
        {

            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(Product product)
        {

            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}