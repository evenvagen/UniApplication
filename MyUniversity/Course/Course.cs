﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class Course
    {
        public int? IdCourse { get; private set; }
        public string Name { get; private set; }

        public int Participants;

        public List<Student> Students;

        public Course(int? idCourse, string course, int participants)
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
