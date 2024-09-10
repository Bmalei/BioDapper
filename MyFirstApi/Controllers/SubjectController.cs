using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstDapper.Model;
using MyFirstDapper.Services;

namespace MyFirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        [HttpPost]

        public bool AddSubject(SubjectModel subject)
        {
            SubjectService subjectServices = new SubjectService();
            return subjectServices.AddSubject(subject);
        }
    }
}
