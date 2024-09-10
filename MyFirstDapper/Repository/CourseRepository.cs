using MyFirstDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 //comsumption of repository
namespace MyFirstDapper.Repository
{
    public class CourseRepository: GenericRepository<CourseModel>
    {
        public bool AddCourse(CourseModel course)
        {
            throw new NotImplementedException();
        }

        public CourseModel GetCoursebyId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
