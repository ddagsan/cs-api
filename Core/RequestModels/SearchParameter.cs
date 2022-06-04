using Core.RequestModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.RequestModels
{
    public class SearchParameter
    {
        public string Name { get; set; }
        public int? ColorId { get; set; }
        public int? BrandId { get; set; }
        public SortType SortType { get; set; }
    }
}
