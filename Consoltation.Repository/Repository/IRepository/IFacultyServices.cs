using Consultation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Repository.Repository.IRepository
{
    public interface IFacultyServices
    {
        Task<List<ConsultationRequest?>> FacultyConsultation(int id);
        Task<Faculty> GetFacultyInformation(string studentUMNumber);
    }
}
