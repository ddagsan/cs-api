using System;
using System.Collections.Generic;
using System.Text;

namespace Web.ViewModels
{
    public class CartListViewModel
    {
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int ProductId { get; set; }
    }
}
