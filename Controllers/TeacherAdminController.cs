using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TeacherAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddJudge()
        {
            return View("~/Views/Team_9/AddJudge.cshtml");
        }
        public IActionResult AddRoom()
        {
            return View("~/Views/Team_9/AddRoom");
        }
        public IActionResult JudgeDash()
        {
            return View("~/Views/Team_9/JudgeDash");
        }
        public IActionResult AddSurveyItem()
        {
            return View("~/Views/Team_9/AddSurveyItem");
        }

    }
}
