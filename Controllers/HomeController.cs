using K205Agency.Data;
using K205Agency.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace K205Agency.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AgencyDbContext _context;
        public HomeController(ILogger<HomeController> logger, AgencyDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var header = _context.Mastheads.FirstOrDefault();
            return View(header);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}