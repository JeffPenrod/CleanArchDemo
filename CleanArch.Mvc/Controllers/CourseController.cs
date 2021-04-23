﻿using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {

        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
             return View(_courseService.GetCourses());
        }
    }
}
