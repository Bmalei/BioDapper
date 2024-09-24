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

        public bool UpdateEnrollment(EnrollmentModel enrollment)
        {
            enrollmentRepository = new EnrollmentRepository();

            return enrollmentRepository.Update(enrollment);
        }

        public bool DeleteEnrollment(EnrollmentModel enrollment)
        {
            enrollmentRepository = new EnrollmentRepository();

            return enrollmentRepository.Delete(enrollment);
        }
    }
}
