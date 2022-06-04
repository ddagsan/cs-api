using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Infrastructure
{
    public class CustomControllerBase : ControllerBase
    {
        public static int UserId = 1;
    }
}
