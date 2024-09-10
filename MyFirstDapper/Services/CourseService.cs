using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Services
{
    public class CourseService
    {
        CourseRepository courseRepository = new CourseRepository();

        public CourseModel GetCourseById(int id)
        {
            courseRepository = new CourseRepository();
            return courseRepository.GetbyId(id);
        }

        public bool AddCourse(CourseModel course)
        {
            courseRepository = new CourseRepository();

            return courseRepository.Add(course);
        }
    }
}
