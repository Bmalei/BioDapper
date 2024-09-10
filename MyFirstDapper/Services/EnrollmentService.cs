using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Services
{
    public class EnrollmentService
    {
        EnrollmentRepository enrollmentRepository = new EnrollmentRepository();

        public EnrollmentModel GetEnrollmentById(int id)
        {
            enrollmentRepository = new EnrollmentRepository();
            return enrollmentRepository.GetbyId(id);
        }

        public bool AddEnrollment(EnrollmentModel enrollment)
        {
            enrollmentRepository = new EnrollmentRepository();

            return enrollmentRepository.Add(enrollment);
        }
    }
}
