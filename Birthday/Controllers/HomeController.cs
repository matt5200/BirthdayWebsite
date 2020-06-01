using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Birthday.Models;
using Microsoft.AspNetCore.Mvc;

namespace Birthday.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Models.BdResponse bdResponse)
        {
            if (ModelState.IsValid)
            {
                return View("BdResponse", bdResponse);

            }
            else
            {
                return View();
            }
        }
    }
}