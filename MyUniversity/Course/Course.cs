using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyUniversity
{
    public class Course
    {
        public int IdCourse { get; set; }
        public string Name { get; private set; }

        public List<Student> Students;


        public Course(int idCourse, string course, params Student[] students)
        {
            IdCourse = idCourse;
            Name = course;
            Students = new List<Student>(students);
        }


        public string CourseInfo()
        {
            return $"{IdCourse}: {Name}, deltagere: {Students.Count}\n\n";
            
        }


    }
}
