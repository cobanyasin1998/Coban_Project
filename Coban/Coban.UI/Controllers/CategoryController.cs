using Microsoft.AspNetCore.Mvc;

namespace Coban.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
