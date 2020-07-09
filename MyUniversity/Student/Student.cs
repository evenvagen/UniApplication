using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace MyUniversity
{
    public class Student 
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public int Id;
        public List<Course> Courses { get; set; }

        public Student(string name, string email, int id, params Course[] courses)
        {
            Name = name;
            Email = email;
            Id = id;
            Courses = new List<Course>(courses);
        }


        public void AddAndCountStudents()
        { 
            foreach (var course in Courses)
            {
                course.Participants++;
            }
        }


        public string StudentInfo()
        {
            var studentOutput =  $"{Name}({Id}), {Email}\nMeldt på {Courses.Count} kurs\n\n";
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

            return new Student(name, email, IdLoop(students), null);
        }


        public static int IdLoop(UniStudents students)
        {
            var i = students.Students.Count + 1;

            foreach (var student in students.Students)
            {
                if(i == student.Id) i = new Random().Next(1000);
            }

            return i;
        }


    }
}
