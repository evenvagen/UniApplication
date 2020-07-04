using System;
using System.Collections.Generic;

namespace MyUniversity
{
    public class Student
    {
        public int? Subject { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Id { get; private set; }
        public List<Course> Courses;

        public Student(int? subject, string name, string email, int id)
        {
            Subject = subject;
            Name = name;
            Email = email;
            Id = id;
        }


        public string StudentInfo(UniCourses c)
        {
            var studentOutput =  $"{Name}({Id}), {Email}\n";
            foreach (var course in c.Courses)
            {
                if (Subject == course.IdCourse) studentOutput += course.CourseInfo();
            }

            if (Subject == 0) studentOutput += "Studenten er ikke meldt på noe kurs\n\n";


            return studentOutput;
        }

        chehg



        public Student()
        {

        }


        public Student CreateStudent()
        {
            Console.WriteLine("Lag en ny student!");

            var name = App.Ask("Navn: ");

            var email = App.Ask("E-post: ");

            var id = Convert.ToInt32(App.AskForId());

            int? subject = Convert.ToInt32(App.Ask("Kurs: "));

            return new Student(subject, name, email, id);

        }
        

    }
}
