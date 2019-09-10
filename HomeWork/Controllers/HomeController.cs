using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string date)
        {
            
            DateTime validatedDate;
            int quarter;
            try
            {
                validatedDate = Convert.ToDateTime(date);
                quarter = (validatedDate.Month + 2) / 3;
                ViewData["quarter"] = "Определённо " + quarter + " квартал.";
                @ViewData["date"] = date;
                return View();
            }

            catch
            {
                ViewData["quarter"] = "Введённая строка не является датой!";
                @ViewData["date"] = date;
                return View();
            }



          
        }

    }
}