using Core.RequestModels;
using Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Infrastructure;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : CustomControllerBase
    {
        private readonly ILogger<CartController> _logger;

        public CartController(ILogger<CartController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int CountOfItemsInCart()
        {
            return 1;
        }

        [HttpPost()]
        public int Post([FromBody] int productId)
        {
            return 1;
        }

        [HttpDelete()]
        public int Delete([FromBody] int productId)
        {
            return 1;
        }
    }
}
