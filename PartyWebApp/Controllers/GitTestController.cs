using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyWebApp.Controllers
{
    public class GitTestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}