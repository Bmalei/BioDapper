﻿using MyFirstDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Repository
{
    public class InstructorRepository : GenericRepository<InstructorModel>
    {
        public bool AddInstructor(InstructorModel instructor)
        {
            throw new NotImplementedException();
        }

        public InstructorModel GetInstructorbyId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
