using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Services
{
     //provides method for performing crud
    public class StudentServices
    {
        StudentRepository studentRepository = new StudentRepository();

        
        public StudentModel GetStudentById(int id)
        {           
            return studentRepository.GetbyId(id);
        }

        public bool AddStudent(StudentModel student)
        {         
            return studentRepository.Add(student);
        }

        public bool UpdateStudent(StudentModel student)
        {           
            return studentRepository.Update(student);
        }

        public bool DeleteStudent(StudentModel student)
        {
            return studentRepository.Delete(student);
        }

    }
}
