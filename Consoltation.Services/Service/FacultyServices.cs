using Consultation.Domain;
using Consultation.Repository.Repository.IRepository;
using Consultation.Services.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Services.Service
{
    public class FacultyServices : IService.IFacultyServices
    {
        private readonly Repository.Repository.IRepository.IFacultyServices _facultyRepository;

        public FacultyServices(Repository.Repository.IRepository.IFacultyServices studentRepository)
        {
            _facultyRepository = studentRepository;
        }
        public async Task<List<ConsultationRequest?>> GetFacultyConsultation(int id)
        {
            return await _facultyRepository.FacultyConsultation(id);
        }

        public Task<Faculty?> GetFacultyInformation(string faucltyUMID)
        {
            return _facultyRepository.GetFacultyInformation(faucltyUMID);   
        }
    }
}
