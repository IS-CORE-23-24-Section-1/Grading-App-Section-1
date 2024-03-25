using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Grading_App_Section_1.Controllers
{
    public class Team14Controller : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult MasterGroup()
        {
            return View();
        }
    }
}
