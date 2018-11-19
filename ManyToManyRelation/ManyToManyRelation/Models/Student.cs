using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManyToManyRelation.Models
{
    public class Student
    {

        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        public List<StudentCourse> StudentCourses;

    }
}
