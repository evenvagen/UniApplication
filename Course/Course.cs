using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class Course
    {
        public int? IdCourse { get; private set; }
        public string Class { get; private set; }
        public int Participants { get; private set; }

        public List<Student> Students;

        public Course(int? idCourse, string @class, int participants)
        {
            IdCourse = idCourse;
            Class = @class;
            Participants = participants;
        }


        public string CourseInfo()
        {
            var courseDescription = $"{IdCourse}: {Class}, deltagere: {Participants}\n\n";
            return courseDescription;
        }


    }
}
