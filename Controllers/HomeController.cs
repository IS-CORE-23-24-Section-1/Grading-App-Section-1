using Grading_App_Section_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Grading_App_Section_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TAView()
        {
            return null;
        }
        [HttpPost]
        public IActionResult TAPost()
        {
            return null;
        }
        [HttpGet]
        public IActionResult TeachView()
        {
            return null;
        }
        [HttpPost]
        public IActionResult TeachPost()
        {
            return null;
        }
        [HttpGet]
        public IActionResult JudgeView()
        {
            return null;
        }
        [HttpPost]
        public IActionResult JudgePost()
        {
            return null;
        }
        [HttpGet]
        public IActionResult StudView()
        {
            return null;
        }
        [HttpPost]
        public IActionResult StudPost()
        {
            return null;
        }
    }
}
