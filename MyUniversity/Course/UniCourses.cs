using System;
using System.Collections.Generic;
using System.Text;

namespace MyUniversity
{
    public class UniCourses
    {
        public List<Course> Courses { get; set; }

        public UniCourses(params Course[] courses)
        {
            Courses = new List<Course>(courses);
        }

        public void ShowAllCourses()
        {
            var i = "";
            foreach (var course in Courses)
            {
                i += course.CourseInfo();
            }

            App.WriteL(i);
        }

    }
}
