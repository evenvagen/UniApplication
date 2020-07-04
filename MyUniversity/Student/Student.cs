using System;
using System.Collections.Generic;

namespace MyUniversity
{
    public class Student 
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public Guid Id;
        public List<Course> Courses;

        public Student(string name, string email, Guid id)
        {
            Name = name;
            Email = email;
            Id = id;
        }


        public string StudentInfo()
        {
            var studentOutput =  $"{Name}({Id}), {Email}\n{Courses}\n\n";
            return studentOutput;
        }


        public Student()
        {

        }


        public Student CreateStudent()
        {
            Console.WriteLine("Lag en ny student!");

            var name = App.Ask("Navn: ");

            var email = App.Ask("E-post: ");

            return new Student(name, email, Guid.NewGuid());

        }


    }
}
