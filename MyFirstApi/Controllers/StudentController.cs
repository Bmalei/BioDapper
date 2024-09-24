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
        StudentServices studentServices = new StudentServices();
        [HttpPost]

        public bool AddStudent(StudentModel student)
        {
            return studentServices.AddStudent(student);
        }

        [HttpPut]
        public bool UpdateStudent(StudentModel student) 
        {
            return studentServices.UpdateStudent(student);
        }

        [HttpDelete]
        public bool DeleteStudent(StudentModel student)
        {
            return studentServices.DeleteStudent(student);
        }
    }
}
