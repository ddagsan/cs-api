using Core.Infrastructure.Pagination;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.ViewModels
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsInCart { get; set; }
        public double Price { get; set; }
        public double DiscountRatio { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }

    public class ProductSearchViewModel
    {
        public PaginatedObject<ProductListViewModel> Products { get; set; }
        public IEnumerable<SearchableItem> Brands { get; set; }
        public IEnumerable<SearchableItem> Colors { get; set; }
    }

    public class SearchableItem
    {
        /// <summary>
        /// brand or color
        /// </summary>
        public string Type { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOf { get; set; }
    }
}
