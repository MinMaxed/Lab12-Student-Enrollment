using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Data;
using StudentEnrollment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Controllers
{
    public class CourseController : Controller
    {

        private EnrollmentDbContext _context;
        public CourseController(EnrollmentDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID,Name,MaxStudents")]Course course)
        {
            if (ModelState.IsValid)
            {
                await _context.Courses.AddAsync(course);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id.HasValue)
            {
                Course course = await _context.Courses.FirstOrDefaultAsync(c => c.ID == id);
                return View(course);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Course course)
        {
            _context.Courses.Update(course);
            await _context.SaveChangesAsync();

            return View();
        }

        public async Task<IActionResult> ViewAll()
        {
            var dta = await _context.Courses.ToListAsync();

            return View(dta);

        }

    }
}
