using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Consultation.Repository.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultation.Repository.Repository
{
    public class FacultyRepository : IFacultyServices
    {
        private readonly AppDbContext _context;

        public FacultyRepository(AppDbContext context) => _context = context;
        public async Task<List<ConsultationRequest?>> FacultyConsultation(int id)
        {
            var consultation = await _context.ConsultationRequest.Include(cr => cr.Faculty)
                .Where(f => f.FacultyID == id)
                .ToListAsync();

            return consultation;
        }

        public async Task<Faculty> GetFacultyInformation(string faucltyUMID)
        {
            try
            {
                var faculty = _context.Faculty
                       .Include(f => f.SchoolYear)
                       .ThenInclude(f => f.EnrolledCourses)
                       .Include(f => f.ConsultationRequests)
                       .FirstOrDefaultAsync(f => f.FacultyUMID == faucltyUMID);
                return await faculty ?? new Faculty();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Student Repository Error: {ex.Message}");
                return new Faculty();
            }
        }
    }
}
