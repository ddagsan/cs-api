using Core.RequestModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.RequestModels
{
    public class PaginationParameter
    {
        public int Offset { get; set; }
        public int Take { get; set; }
    }
}
