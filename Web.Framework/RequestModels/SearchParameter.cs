using Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.RequestModels
{
    public class SearchParameter
    {
        public string Name { get; set; }
        public int? ColorId { get; set; }
        public int? BrandId { get; set; }
        public SortType SortType { get; set; }
    }
}
