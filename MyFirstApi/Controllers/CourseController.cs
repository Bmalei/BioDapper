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
        [HttpPost]

        public bool AddCourse(CourseModel course)
        {
            CourseService courseServices = new CourseService();
            return courseServices.AddCourse(course);
        }
    }
}
