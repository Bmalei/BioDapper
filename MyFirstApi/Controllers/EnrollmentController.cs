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
        [HttpPost]

        public bool AddEnrollment(EnrollmentModel enrollment)
        {
            EnrollmentService enrollmentServices = new EnrollmentService();
            return enrollmentServices.AddEnrollment(enrollment);
        }
    }
}
