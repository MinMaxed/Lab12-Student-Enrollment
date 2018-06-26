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


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID, Name, Course, CourseID")] Student student)
        {

            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();

            int id = student.ID;
            return View();
        }



        public async Task<IActionResult> ViewAll()
        {
            var dta = await _context.Students.ToListAsync();

            return View(dta);

        }
    }
}
