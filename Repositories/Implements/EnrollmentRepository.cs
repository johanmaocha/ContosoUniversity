using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ContosoUniversity.Repositories.Implements
{
    public class EnrollmentRepository : GenericRepository<Enrollment>, IEnrollmentRepository
    {
        private SchoolContext schoolContext;

        public EnrollmentRepository(SchoolContext schoolContext) : base(schoolContext)
        {
            this.schoolContext = schoolContext;
        }

        public new async Task<List<Enrollment>> GetAll()
        {
           var ListEnrollments = await schoolContext.Enrollments
                .Include(x => x.Course)
                .Include(x => x.Student)
                .ToListAsync();

            /*  var ListEnrollments = (from enrollments in schoolContext.Enrollments
                                join course in schoolContext.Courses on enrollments.CourseID equals course.CourseID
                                join course in schoolContext.Students on enrollments.StudentID equals course.ID
                                select enrollments).ToListAsync();
                                 */


            return ListEnrollments;
        }

    }
}
