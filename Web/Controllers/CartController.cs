using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Infrastructure;
using Web.ViewModels;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartController : CustomControllerBase
    {
        private readonly ILogger<CartController> _logger;
        private readonly IUserService _userService;

        public CartController(
            ILogger<CartController> logger,
            IUserService userService
            )
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public IEnumerable<CartListViewModel> GetItemsInCart()
        {
            var cartItems = _userService.GetItemsInCart(UserId).Select(m => new CartListViewModel() //TODO: automapper
            {
                CartId = m.Id,
                Image = "", //TODO: image yolu eklenecek
                ProductName = m.Product.Name,
                ProductId = m.ProductId
            });

            return cartItems;
        }

        [HttpGet("/count")]
        public int GetCountOfItemsInCart()
        {
            return _userService.GetCountOfItemsInCart(UserId);
        }

        [HttpPost()]
        public int Post([FromBody] int productId)
        {
            return 1;
        }

        [HttpDelete()]
        public void Delete([FromBody] int productId)
        {
            _userService.DeleteItemInCart(UserId, productId);
        }
    }
}
