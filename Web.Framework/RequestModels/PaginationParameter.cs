using Web.RequestModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Web.RequestModels
{
    public class PaginationParameter
    {
        public int Offset { get; set; }
        public int Take { get; set; }
    }
}
