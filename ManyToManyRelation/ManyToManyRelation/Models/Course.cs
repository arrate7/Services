using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Models
{
    public class Course
    {

        public int Id { get; set; }
        public string CourseName { get; set; }

        public List<StudentCourse> StudentCourses;
    }
}
