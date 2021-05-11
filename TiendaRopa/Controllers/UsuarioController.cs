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
    public class UsuarioController : Controller
    {

       private readonly ILogger<UsuarioController> _logger;
       private readonly ApplicationDbContext _context;


        public UsuarioController(ILogger<UsuarioController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var listUsuarios=_context.Usuarios.ToList();
            return View(listUsuarios);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Enviar(Usuario objFormulario)
        {
              if (ModelState.IsValid)
                {
              _context.Add(objFormulario);
                _context.SaveChanges();
                TempData["prueba"] = "prueba01";
                objFormulario.Respuesta = "Gracias. Formulario enviado";
                return RedirectToAction("Index");  
                }
                return View("Index", objFormulario);
        }

        // GET: Contacto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
          public IActionResult Delete(int? id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,nombre,apellidos,direccion,distrito,sexo,Email,edad,celular")] Usuario usuario)
        {
            if (id != usuario.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                    
                }
                 TempData["prueba02"] = "prueba02";
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }
        

       

    }
}