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
    public class UserController : CustomControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int CountOfItemsInCart()
        {
            return 1;
        }

        [HttpPost]
        public int Post([FromBody] int productId)
        {
            return 1;
        }
    }
}
