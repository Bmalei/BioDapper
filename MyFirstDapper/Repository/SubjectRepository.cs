using MyFirstDapper.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapper.Repository
{
    public class SubjectRepository : GenericRepository<SubjectModel>
    {
        public bool AddSubject(SubjectModel subject)
        {
            throw new NotImplementedException();
        }

        public SubjectModel GetSubjectbyId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
