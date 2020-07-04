using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class Course
    {
        public int? IdCourse { get; private set; }
        public string Class { get; private set; }

        public List<Student> Participants;

        public Course(int? idCourse, string @class)
        {
            IdCourse = idCourse;
            Class = @class;
        }




        public string CourseInfo()
        {
            var courseDescription = $"{IdCourse}: {Class}, deltagere: {Participants}\n\n";
            return courseDescription;
        }


    }
}
