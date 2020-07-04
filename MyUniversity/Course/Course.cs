using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class Course
    {
        public int? IdCourse { get; private set; }
        public string Coursed { get; private set; }

        public int Participants;

        public List<Student> Students;

        public Course(int? idCourse, string course, int participants)
        {
            IdCourse = idCourse;
            Coursed = course;
            Participants = participants;
        }




        public string CourseInfo()
        {
            var courseDescription = $"{IdCourse}: {Coursed}, deltagere: {Participants}\n\n";
            return courseDescription;
        }


    }
}
