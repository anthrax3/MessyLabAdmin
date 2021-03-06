﻿using System.Linq;
using System;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using MessyLabAdmin.Models;
using MessyLabAdmin.Util;
using System.Collections.Generic;
using System.Globalization;
using Action = MessyLabAdmin.Models.Action;
using Microsoft.AspNet.Authorization;

namespace MessyLabAdmin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            ViewBag.latestActions = _context.Actions
                .Include(a => a.Student)
                .OrderByDescending(a => a.CreatedTime)
                .Take(10);
            ViewBag.latestSolutions = _context.Solutions
                .Include(s => s.Assignment)
                .Include(s => s.Student)
                .Where(s => !s.IsHistory)
                .OrderByDescending(s => s.CreatedTime)
                .Take(10);
            return View();
        }

        [AllowAnonymous]
        public IActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Error()
        {
            return View();
        }
    }
}
