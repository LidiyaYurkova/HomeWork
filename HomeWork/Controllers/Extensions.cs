using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork.Controllers
{
    public static class Extensions
    {
        public static int GetQuarter(this DateTime date)
        {
            return (date.Month + 2) / 3;
        }
      
    }
}