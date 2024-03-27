using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TAController : Controller
    {
        public IActionResult Rubric()
        {
            return View();
        }
    }
}
