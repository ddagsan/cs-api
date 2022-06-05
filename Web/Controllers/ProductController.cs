using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Infrastructure;
using Web.RequestModels;
using Web.ViewModels;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : CustomControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(
            ILogger<ProductController> logger,
            IProductService productService
            )
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet()]
        public IEnumerable<ProductListViewModel> Get([FromQuery] SearchParameter search, [FromQuery] PaginationParameter pagination)
        {
            var prods = _productService.Get(search.Name, search.ColorId, search.BrandId, search.SortType, pagination.Take ?? int.MaxValue, pagination.Index);

            return prods.Select(m => new ProductListViewModel()//TODO: automapper
            {
                Brand = m.Brand.Name,
                Color = m.Color.Name,
                Id = m.Id,
                DiscountRatio = m.DiscountRatio,
                Name = m.Name,
                Price = m.Price,
                IsInCart = m.Carts.Any(c => c.UserId == UserId)
            });
        }
    }
}
