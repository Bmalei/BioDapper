﻿using MyFirstDapper.Model;
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
        {
            instructorRepository = new InstructorRepository();
            return instructorRepository.GetbyId(id);
        }

        public bool AddInstructor(InstructorModel instructor)
        {
            instructorRepository = new InstructorRepository();

            return instructorRepository.Add(instructor);
        }
    }
}
