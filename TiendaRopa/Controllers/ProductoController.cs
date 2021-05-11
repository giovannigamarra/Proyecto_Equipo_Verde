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
    public class ProductoController : Controller
    {

       private readonly ILogger< ProductoController> _logger;
       private readonly ApplicationDbContext _context;


        public  ProductoController(ILogger< ProductoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var listContactos=_context.Productos.OrderBy(y => y.nombre).OrderBy(x => x.descripcion).ToList();
            return View(listContactos);
        }
     

      
                
        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,nombre,modelo,marca,sku,talla,precio,pages ,descripcion,imagen")] Producto producto)
        {
            if (id !=  producto.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                  TempData["prueba02"] = "prueba02";
                return RedirectToAction(nameof(Listar));
            }
            return View(producto);
        }
        

        // GET: http://localhost:5000/Contacto/Delete/6 MUESTRA Contacto
        public IActionResult Delete(int? id)
        {
            var producto = _context.Productos.Find(id);
            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Listar));
        }

        public IActionResult Enviar(Producto objFormulario)
        {
              if (ModelState.IsValid)
                {
              _context.Add(objFormulario);
                _context.SaveChanges();
                TempData["prueba"] = "prueba01";
                objFormulario.Respuesta = "Gracias. Formulario enviado";
                return RedirectToAction("Listar");  
                }
                return View("index", objFormulario);
        }
    }
}