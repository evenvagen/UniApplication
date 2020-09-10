using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
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



        public string StudentInfo()
        {
            var studentOutput =  $"{Name}({Id}), {Email}\nMeldt på {Courses.Count} kurs\n\n";
            return studentOutput;
        }


        public Student()
        {

        }


        public string AddCourse(Course c, Student s)
        {
            if (!Courses.Contains(c))
            {
                Courses.Add(c);
                c.Students.Add(s);
            }
            else return "Studenten er allerede meldt på dette kurset";
            return $"\n{Name} meldt på {c.Name}\n";
        }

        public string RemoveCourse(Course c, Student s)
        {
            if (Courses.Contains(c))
            {
                Courses.Remove(c);
                c.Students.Remove(s);
            }
            else return "Studenten er ikke meldt på dette kurset";
            return $"\n{Name} meldt av {c.Name}\n";
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
            var i = students.Students.Count + 1;

            foreach (var student in students.Students)
            {
                if(i == student.Id) i = new Random().Next(1000);
            }

            return i;
        }



    }
}
