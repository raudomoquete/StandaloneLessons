using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandaloneLessons.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult HttpStatusCodeHnadler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "That page does not exist.";
                    break;
                default:
                    ViewBag.ErrorMessage = "There was a problem.";
                    break;
            }

            return View("NotFound");
        }
    }
}
