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

            return courseRepository.GetbyId(id);
        }

        public bool AddCourse(CourseModel course)
        {
            return courseRepository.Add(course);
        }

        public bool UpdateCourse(CourseModel course) 
        { 
            return courseRepository.Update(course);
        }

        public bool DeleteCourse(CourseModel course)
        {
            return courseRepository.Delete(course);
        }
    }
}
