using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TiendaRopa.Models;

namespace TiendaRopa.Controllers
{
    public class ContactenosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ContactenosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
