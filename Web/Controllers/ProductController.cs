using Core.Domain;
using Core.Infrastructure.Pagination;
using Core.Pagination.Infrastructure;
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
        public ProductSearchViewModel Get([FromQuery] SearchParameter search, [FromQuery] PaginationParameter pagination)
        {
            var retVal = new ProductSearchViewModel();

            var prods = _productService.Get(search.Name, search.ColorId, search.BrandId, search.SortType);
            var prodsListed = prods.ToList();
            var list = prods.Select(m => new ProductListViewModel()//TODO: automapper
            {
                Brand = m.Brand.Name,
                Color = m.Color.Name,
                Id = m.Id,
                DiscountRatio = m.DiscountRatio,
                Name = m.Name,
                Price = m.Price,
                IsInCart = m.Carts.Any(c => c.UserId == UserId)
            });
            var pagedList = new PagedList<ProductListViewModel>(list, pagination.Index, pagination.Size);
            retVal.Products = new PaginatedObject<ProductListViewModel>(pagedList);
            retVal.Brands = prodsListed.GroupBy(m => m.Brand, m => m.BrandId, (Key, G) => new SearchableItem() { Id = Key.Id, Name = Key.Name, Type = "Brand", CountOf = G.Count() });
            retVal.Colors = prodsListed.GroupBy(m => m.Color, m => m.ColorId, (Key, G) => new SearchableItem() { Id = Key.Id, Name = Key.Name, Type = "Color", CountOf = G.Count() });

            return retVal;
        }
    }
}
