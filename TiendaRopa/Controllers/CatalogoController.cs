using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TiendaRopa.Models;
using TiendaRopa.Data;

namespace TiendaRopa.Controllers
{
    public class CatalogoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public CatalogoController(ILogger<HomeController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            var listContactos=_context.Productos.OrderBy(y => y.nombre).OrderBy(x => x.descripcion).ToList();
            return View(listContactos);
        }

        // GET: Contacto/Edit/5
        public async Task<IActionResult> Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacto = await _context. Productos.FindAsync(id);
            if (contacto == null)
            {
                return NotFound();
            }
            return View(contacto);
        }
    }
}