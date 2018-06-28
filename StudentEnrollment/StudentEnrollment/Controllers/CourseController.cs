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

        //go to the Course main page
        public IActionResult Index()
        {
            return View();
        }

        //go to the create a Course page
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Create a and save a Course
        /// </summary>
        /// <param name="course">The type of model  being created</param>
        /// <returns>go to the Course index page</returns>
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ID,Name,MaxStudents")]Course course)
        {
            if (ModelState.IsValid)
            {
                await _context.Courses.AddAsync(course);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details");
            }
            return View();
        }

        /// <summary>
        /// this will read 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// if there is a course to look at, view its details otherwise return to course index
        /// page
        /// </summary>
        /// <param name="id">id of course you want details of</param>
        /// <returns>id's page or course page</returns>
        public async Task<IActionResult> Details(int? id)
        {
            if (id.HasValue)
            {
                return View(await CourseDetailViewModel.FromIDAsync(id.Value, _context));
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        /// <summary>
        /// update a course object that exists
        /// </summary>
        /// <param name="course">the object you want to adjust</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Update([Bind("ID, Name, MaxStudents")]Course course)
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
