namespace TiendaRopa.Controllers
{
    public class MenuController
    {
      public MenuController(ILogger<MenuController> logger)
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