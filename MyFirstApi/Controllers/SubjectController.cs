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
        SubjectService subjectServices = new SubjectService();
        [HttpPost]

        public bool AddSubject(SubjectModel subject)
        {
            return subjectServices.AddSubject(subject);
        }

        [HttpPut]
        public bool UpdateSubject(SubjectModel subject)
        {
            return subjectServices.UpdateSubject(subject);
        }

        [HttpDelete]

        public bool DeleteSubject(SubjectModel subject)
        {
            return subjectServices.DeleteSubject(subject);
        }

    }
}
