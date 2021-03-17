using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this return list of products";
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "this return single product";
        }
    }
}