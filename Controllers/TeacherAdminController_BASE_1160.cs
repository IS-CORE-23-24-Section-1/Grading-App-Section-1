﻿using Microsoft.AspNetCore.Mvc;

namespace Grading_App_Section_1.Controllers
{
    public class TeacherAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
