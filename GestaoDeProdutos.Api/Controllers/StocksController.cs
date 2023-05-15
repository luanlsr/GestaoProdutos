using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        [HttpPost]
        [Route("create-stock")]
        public IActionResult CreateStock(int? id)
        {
            return Ok(new { id });
        }
    }
}
