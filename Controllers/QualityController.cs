using Managerment_fish.Models;
using Microsoft.AspNetCore.Mvc;

namespace Managerment_fish.Controllers
{
    public class QualityController : Controller
    {

		private readonly ApplicationDbContext _context;

		public QualityController(ApplicationDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
        {
            return View();
        }


		[HttpPost]
		public async Task<IActionResult> SubmitForm(float ph, float temperature, float dissolved_oxygen, float turbidity)
		{
			var chatLuongHoCa = new ChatLuongHoCa
			{
				MaNguoiDung = 1,            // Replace with the actual user ID if needed
				PH = ph,
				NhietDo = temperature,
				OxyHoaTan = dissolved_oxygen,
				DoDuc = turbidity
			};

			_context.ChatLuongHoCa.Add(chatLuongHoCa);
			await _context.SaveChangesAsync();

			return RedirectToAction("Index");  // Redirect to another page after saving
		}
	}
}
