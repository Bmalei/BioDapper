using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Services;
using Microsoft.AspNetCore.Http;
using MyFirstDapper.Model;

namespace MyFirstApi.Controllers
{
    //common attributes for controller
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]

        public bool AddStudent(StudentModel student)
        {
            StudentServices studentServices = new StudentServices();
            return studentServices.AddStudent(student);
        }
    }
}
