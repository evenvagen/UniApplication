using System;
using System.Collections.Generic;
using System.Globalization;

namespace MyUniversity
{
    public class Student 
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Id;
        public List<Course> Courses;

        public Student(string name, string email, int id)
        {
            Name = name;
            Email = email;
            Id = id;
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
