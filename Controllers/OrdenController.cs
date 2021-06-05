using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TiendaRopa.Models;
using TiendaRopa.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace TiendaRopa.Controllers
{
    public class OrdenController : Controller
    {
        private readonly ILogger< OrdenController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public  OrdenController(ILogger< OrdenController> logger,
            ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult AddItem(int? id)
        {
            var producto = _context.Productos.Find(id);

            var orderDetail = new OrdenDetail();
            orderDetail.productoID = producto.ID;
            orderDetail.Nombre = producto.nombre;
            orderDetail.Precio = producto.precio;
            orderDetail.Cantidad = 1;
            var name = _userManager.GetUserName(User);
            orderDetail.Email = name;

            _context.Add(orderDetail);
            _context.SaveChanges();
            return RedirectToAction("Index", "Catalogo");
        }

        public IActionResult Carrito()
        {
            var listContactos=_context.OrdenDetails.ToList();
            return View(listContactos);
        }
        public IActionResult Proceso()
        {
            var listContactos=_context.OrdenDetails.ToList();
            return View(listContactos);
        }
    }
}