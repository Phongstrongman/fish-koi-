using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
namespace Managerment_fish.Controllers;
=======
using System.Collections.Generic;
using System.Linq;
using Managerment_fish.Data; // Thay thế YourNamespace bằng namespace thực tế của bạn //dòng đã thay thế
using Microsoft.EntityFrameworkCore;

>>>>>>> d48681261eeb414acc9cd123ee078b81d41e29cf
public class FishController : Controller
{



    public IActionResult Index()
    {

        return View(); // Trả về view với danh sách cá
    }
}
