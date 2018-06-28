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
    public class StudentController : Controller
    {
        private EnrollmentDbContext _context;

        /// <summary>
        /// constructor to take the connection to the DB through _context
        /// into context
        /// </summary>
        /// <param name="context"></param>
        public StudentController(EnrollmentDbContext context)
        {
            _context = context;
        }

        //go to Student create home page
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            //connects to the Courses in the database to be used in the drop down menu on the Create page
            ViewData["Courses"] = await _context.Courses.Select(c => c).ToListAsync();
            return View();
        }

        //
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID,Name,Course,CourseID")]Student student)
        {
            if (ModelState.IsValid)
            {
                student.Course = await _context.Courses.Where(c => c.ID == student.CourseID).SingleAsync();

                _context.Students.Add(student);

                await _context.SaveChangesAsync();
                //int id = student.ID;
                ViewData["Courses"] = await _context.Courses.Select(c => c).ToListAsync();
                return View("ViewAll");

            }
            ViewData["Courses"] = await _context.Courses.Select(c => c).ToListAsync();
            return View(student);
        }



        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            if (id.HasValue)
            {
                Student student = await _context.Students.FirstOrDefaultAsync(s => s.ID == id);
                return View(student);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Update(Student student)
        {
            _context.Students.Update(student);
            await _context.SaveChangesAsync();

            return View();
        }

        public async Task<IActionResult> ViewAll()
        {
            var dta = await _context.Students.ToListAsync();

            return View(dta);
        }
    }
}
