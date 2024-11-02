using Managerment_fish.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Managerment_fish.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
			_logger = logger;
            _context = context;
        }

		public IActionResult Index()
		{

			var nguoiDungs = _context.NguoiDung.ToList();
			return View(nguoiDungs);
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
