using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data;

namespace ResumeApp.Controllers
{
    public class HomeController : Controller
    {
        private ResumeContext db;
        private readonly ILogger _logger;

        public HomeController(ResumeContext context,
            ILogger<HomeController> logger)
        {        
            db = context;
            _logger = logger;
        }

        public IActionResult Index()
        {        
            return View();
        }
    }
}
