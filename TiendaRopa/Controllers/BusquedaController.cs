namespace TiendaRopa.Controllers
{
    public class BusquedaController
    {
      public BusquedaController(ILogger<BusquedaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    } 
   
}