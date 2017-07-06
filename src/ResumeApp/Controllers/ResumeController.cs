using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data;

namespace ResumeApp.Controllers
{
    public class ResumeController : Controller
    {
        private ResumeContext db;

        public ResumeController(ResumeContext context)
        {        
            db = context;        
        }

        [HttpGet]
        public IActionResult GetEmployeeByID(int employeeID)
        {
            var resume = this.db.Employees
                                .Where(e => e.ID == employeeID)                            
                                .SingleOrDefault();

            return Json(resume);
        }

        [HttpGet]
        public IActionResult GetJobsByEmployeeID(int employeeID)
        {
            var jobs = this.db.Jobs
                                .Where(j => j.Employee.ID == employeeID)                            
                                .ToList();

            return Json(jobs);
        }

        [HttpGet]
        public IActionResult GetSkillsByEmployeeID(int employeeID)
        {
            var skills = this.db.Skills
                                .Where(s => s.Employee.ID == employeeID)                            
                                .ToList();

            return Json(skills);
        }
    }
}
