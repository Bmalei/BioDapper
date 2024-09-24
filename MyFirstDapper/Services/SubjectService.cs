using MyFirstDapper.Model;
using MyFirstDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyFirstDapper.Services
{
    public class SubjectService
    {
        SubjectRepository subjectRepository = new SubjectRepository();

        public SubjectModel GetSubjectById(int id)
        {
            return subjectRepository.GetbyId(id);
        }

        public bool AddSubject(SubjectModel subject)
        {
            return subjectRepository.Add(subject);
        }

        public bool UpdateSubject(SubjectModel subject)
        {
            return subjectRepository.Update(subject);
        }

        public bool DeleteSubject(SubjectModel subject)
        {
            return subjectRepository.Delete(subject);
        }
    }
}
