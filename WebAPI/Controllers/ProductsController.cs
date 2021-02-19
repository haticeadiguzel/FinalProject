using Business.Abstact;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController] //ATTRIBUTE demektir. Bu class bir controllerdır ona göre davran demek
    public class ProductsController : ControllerBase
    {
        IProductService _productService;//field

        public ProductsController(IProductService productService)
        {
            //Controller sen bir IProductService bağımlısısın demek
            //Gevşek bağlılık
            _productService = productService;
        }

        [HttpGet("getall")]//diğer getler ile karışmasın diye isimlendirdik

        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result); //result.Data
            }
            return BadRequest(result); //result.Message yazarsak sadece sistem bakımda yazar
        }

        //1. deneme
        //public string GetAll()
        //{
        //    return "Merhaba";
        //}

        //2. deneme
        //public List<Product> GetAll()
        //{
        //    return new List<Product>
        //    {
        //        new Product{ProductId=1, ProductName="Elma"},
        //        new Product{ProductId=2, ProductName="Armut"}
        //    };
        //}

        //3. deneme
        //public List<Product> GetAll()
        //{
        //    var result = _productService.GetAll();
        //    return result.Data;
        //}

        [HttpGet("getbyid")]//isimlendirdik hata olamsın diye
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
