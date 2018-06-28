using Microsoft.EntityFrameworkCore;
using StudentEnrollment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Models
{
    /// <summary>
    /// this is for viewing the data from the Courses
    /// </summary>
    public class CourseDetailViewModel
    {
        public IEnumerable<Student> Students { get; set; }
        public Course Course { get; set; }

        public static async Task<CourseDetailViewModel> FromIDAsync(int id, EnrollmentDbContext context)
        {
            CourseDetailViewModel cdvm = new CourseDetailViewModel();

            cdvm.Course =
                await context.Courses.Where(c => c.ID == id).SingleAsync();

            cdvm.Students =
                await context.Students.Where(s => s.Course == cdvm.Course)
                .Select(s => s)
                .ToListAsync();

            return cdvm;
        }

    }
}
