using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Services
{
    public class InstructorService
    {
        InstructorRepository instructorRepository = new InstructorRepository();


        public InstructorModel GetInstructorById(int id)
        {           ;
            return instructorRepository.GetbyId(id);
        }

        public bool AddInstructor(InstructorModel instructor)
        {
            return instructorRepository.Add(instructor);
        }

        public bool UpdateInstructor(InstructorModel instructor)
        {
            return instructorRepository.Update(instructor);
        }

        public bool DeleteInstructor(InstructorModel instructor)
        {
            return instructorRepository.Delete(instructor);
        }
    }
}
