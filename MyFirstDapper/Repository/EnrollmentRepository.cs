using MyFirstDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Repository
{
    public class EnrollmentRepository : GenericRepository<EnrollmentModel>
    {
        public bool AddEnrollment(EnrollmentModel enrollment)
        {
            throw new NotImplementedException();
        }

        public EnrollmentModel GetEnrollmentbyId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
