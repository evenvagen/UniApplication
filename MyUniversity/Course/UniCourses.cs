using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class UniCourses
    {
        public List<Course> Courses { get; set; }

        public UniCourses(Course[] courses)
        {
            Courses = new List<Course>(courses);
        }

        public string ShowAllCourses()
        {
            var i = "";
            foreach (var course in Courses)
            {
                i += course.CourseInfo();
            }

            return i;
        }

    }
}
