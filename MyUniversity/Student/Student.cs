using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace MyUniversity
{
    public class Student 
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Id;
        public List<Course> Courses;

        public Student(string name, string email, int id, params Course[] courses)
        {
            Name = name;
            Email = email;
            Id = id;
            Courses = new List<Course>(courses);
        }


        public string StudentCourse(int id)
        {
            var i = "";
            foreach (var course in Courses.Where(c => c.IdCourse == id).ToArray())
            {
                if(course.IdCourse == id) Courses.Add(course);
                course.Participants++;
                i = course.CourseInfo();
            }
            return i;
        }


        public string StudentInfo()
        {
            var studentOutput =  $"{Name}({Id}), {Email}\n\n";
            return studentOutput;
        }


        public Student()
        {

        }


        public Student CreateStudent(UniStudents students)
        {
            Console.WriteLine("Lag en ny student!");

            var name = App.Ask("Navn: ");

            var email = App.Ask("E-post: ");

            return new Student(name, email, IdLoop(students));
        }


        public static int IdLoop(UniStudents students)
        {
            
            return students.Students.Count + 1;
        }


    }
}
