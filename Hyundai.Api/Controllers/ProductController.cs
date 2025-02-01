using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hyundai.Api.DataAccess;
using Hyundai.Api.Models;

namespace Hyundai.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly ApplicationContext applicationContext;

        public ProductController(ApplicationContext _applicationContext)
        {
            this.applicationContext = _applicationContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> prodeucts = applicationContext.GetProducts();
            return Ok(prodeucts);
        }
    }
}
