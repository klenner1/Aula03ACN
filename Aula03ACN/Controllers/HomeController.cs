using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula03ACN.Models;

namespace Aula03ACN.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Convert(string val)
        {
            Celsius data = new Celsius();
            if (val != null)
            {
                double c = Double.Parse(val);
                double f = (c / 5 * 9) + 32;
                data.val =  f ;
            }
            else
            {
                data.val = 0;
            }

                return Json(data);
            
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
