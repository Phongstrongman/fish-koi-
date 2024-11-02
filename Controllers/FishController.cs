using Microsoft.AspNetCore.Mvc;
namespace Managerment_fish.Controllers;
public class FishController : Controller
{



    public IActionResult Index()
    {

        return View(); // Trả về view với danh sách cá
    }
}
