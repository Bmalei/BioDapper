using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
     public class InstructorController : ControllerBase
    {
        InstructorService instructorServices = new InstructorService();
        [HttpPost]

        public bool AddInstructor(InstructorModel instructor)
        {
            return instructorServices.AddInstructor(instructor);
        }

        [HttpPut]

        public bool UpdateInstructor(InstructorModel instructor)
        {
            return instructorServices.UpdateInstructor(instructor);
        }

        [HttpDelete]

        public bool DeleteInstructor(InstructorModel instructor)
        {
            return instructorServices.DeleteInstructor(instructor);
        }

    }
}
