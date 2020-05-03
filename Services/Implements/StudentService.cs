using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Models;
using ContosoUniversity.Repositories;


namespace ContosoUniversity.Services.Implements
{
    public class StudentService : GenericService<Student>, IStudentService
    {
        private IStudentRepository studentRepositiry;

        public StudentService(IStudentRepository studentRepositiry) : base (studentRepositiry) 
        {
            this.studentRepositiry = studentRepositiry;

        }


    }
}
