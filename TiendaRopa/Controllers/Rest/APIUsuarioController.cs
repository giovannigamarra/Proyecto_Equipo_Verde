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

namespace TiendaRopa.Controllers.Rest
{
    [ApiController]
    [Route("api/usuario")]
    public class APIUsuarioController : ControllerBase
    {

    private readonly ILogger<APIUsuarioController> _logger;
    
    private readonly ApplicationDbContext _context;

     public  APIUsuarioController(ILogger<APIUsuarioController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


     [HttpGet]
        
        public IEnumerable<Usuario> ListUsuario()
        {
             var ListUsuario=_context.Usuarios.OrderBy(s => s.ID).ToList();   
             return ListUsuario.ToArray();
        }

        [HttpGet("{id}")]
        public Usuario GetProduct(int? id)
        {
            var usuario =  _context.Usuarios.Find(id);
            return usuario;
        }

        [HttpPost]
        public Usuario CreateProduct(Usuario usuario){
            _context.Add(usuario);
            _context.SaveChanges();
            return usuario;
        }













    }


}
