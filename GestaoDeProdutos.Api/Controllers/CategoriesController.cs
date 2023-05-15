using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpPost]
        [Route("create-category")]
        public IActionResult CreateCategory(int? id)
        {
            return Ok(new { id });
        }
    }
}
