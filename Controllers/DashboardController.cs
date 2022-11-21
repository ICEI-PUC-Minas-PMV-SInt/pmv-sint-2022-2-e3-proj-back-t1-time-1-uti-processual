using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using utip_backend.Models;
using utip_backend.Data;
namespace utip_backend.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        private ProcessDbContext db = new ProcessDbContext();

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(db.Processo.ToList());     
         }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
