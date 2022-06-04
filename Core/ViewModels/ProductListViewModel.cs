using System;
using System.Collections.Generic;
using System.Text;

namespace Core.ViewModels
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
}
