using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        [Route("create-product")]
        public IActionResult CreateProduct(int? id)
        {
            return Ok(new { id });
        }
    }
}
