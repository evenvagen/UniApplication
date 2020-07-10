using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class Course
    {
        public int IdCourse { get; set; }
        public string Name { get; private set; }

        public int Participants;


        public Course(int idCourse, string course, int participants)
        {
            IdCourse = idCourse;
            Name = course;
            Participants = participants;
        }


        public string CourseInfo()
        {
            var courseDescription = $"{IdCourse}: {Name}, deltagere: {Participants}\n\n";
            return courseDescription;
        }


    }
}
