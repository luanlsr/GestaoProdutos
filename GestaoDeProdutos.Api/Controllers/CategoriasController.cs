using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        [HttpPost]
        [Route("create-product")]
        public IActionResult CreateProduct(int? id)
        {
            return Ok(new { id });
        }
    }
}
