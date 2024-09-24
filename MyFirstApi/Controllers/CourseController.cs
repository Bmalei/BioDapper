using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Services;
using Microsoft.AspNetCore.Http;
using MyFirstDapper.Model;

namespace MyFirstApi.Controllers
{
     //common attributes for controller
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        CourseService courseServices = new CourseService();
        
        [HttpPost]
        public bool AddCourse(CourseModel course)
        { 
            
            return courseServices.AddCourse(course);
        }

        [HttpPut]
        public bool UpdateCourse(CourseModel course) 
        {
            return courseServices.UpdateCourse(course);
        }

        [HttpDelete]
        public bool DeleteCourse(CourseModel course) 
        {
            return courseServices.DeleteCourse(course);
        }
    }
}
