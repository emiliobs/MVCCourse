using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
         if (id.HasValue)
            {
                return new JsonResult(new { id = id.ToString()});
            }
         else
            {
                return new ContentResult { Content = "NO content" };
            }
        }
    }
}
