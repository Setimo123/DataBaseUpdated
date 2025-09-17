using Consultation.Repository.IRepository;
using Consultation.Domain;
using Consultation.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Consultation.Repository.Repository.IRepository;

namespace Consultation.Repository
{
    public class UserRepository : IAuthRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context) => _context = context;

        public async Task<Users?> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        //For mobile repository
        public async Task<Student> GetStudentInformation(string studentUMNumber)
        {
            try
            {
                var students = _context.Students
                      .AsNoTracking()
                       .AsSplitQuery()
                       .Include(s => s.SchoolYear)
                       .Include(s => s.EnrolledCourses)
                       .ThenInclude(s => s.Faculty)
                       .Include(s => s.ConsultationRequests)
                       .Include(s => s.Program)
                       .FirstOrDefaultAsync(s => s.StudentUMID == studentUMNumber);
                return await students ?? new Student();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Student Repository Error: {ex.Message}");
                return new Student();
            }

        }


        public async Task<EnrolledCourse?> GetStudentEnrolledCourses(string CourseName)
        {
            try
            {
                var enrolledCourses = _context.EnrolledCourse
                      .AsNoTracking()
                       .AsSplitQuery()
                       .FirstOrDefaultAsync(s => s.CourseName == CourseName);
                return await enrolledCourses ?? new EnrolledCourse();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Student Repository Error: {ex.Message}");
                return new EnrolledCourse();
            }

        }
    }
}
