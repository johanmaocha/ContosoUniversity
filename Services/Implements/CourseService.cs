using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Repositories;

namespace ContosoUniversity.Services.Implements
{
    public class CourseService : GenericService<Course>, ICourseService 
    { 

        private ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository) : base(courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<IEnumerable<Student>> GetStudentsByCourse(int id)
        {
            return await courseRepository.GetStudentsByCourse(id);
        }
    }
}
