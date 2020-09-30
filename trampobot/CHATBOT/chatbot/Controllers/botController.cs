using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chatbot.Models;

namespace chatbot.Controllers
{
    public class botController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
