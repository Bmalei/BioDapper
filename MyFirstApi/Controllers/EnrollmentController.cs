using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        EnrollmentService enrollmentServices = new EnrollmentService();
        [HttpPost]

        public bool AddEnrollment(EnrollmentModel enrollment)
        {
            return enrollmentServices.AddEnrollment(enrollment);
        }

        [HttpPut]
        public bool UpdateEnrollment(EnrollmentModel enrollment)
        {
            return enrollmentServices.UpdateEnrollment(enrollment);
        }

        [HttpDelete]
        public bool DeleteEnrollment(EnrollmentModel enrollment)
        {
            return enrollmentServices.DeleteEnrollment(enrollment);
        }
    }
}
