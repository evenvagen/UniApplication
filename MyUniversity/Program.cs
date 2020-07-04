using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace MyUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student(202, "Joe","joe@nasa.com", 1);
            var s2 = new Student(0, "Kate", "kate@nasa.com", 2);
            var s3 = new Student(203, "Alfred", "alfred@nasa.com", 3);

            Student[] stu = { s1, s2, s3 };
            var students = new UniStudents(stu);

            var c1 = new Course(101, "Rocket science", 1);
            var c2 = new Course(202, "Space mining", 0);
            var c3 = new Course(203, "Space farming", 1);

            Course[] rockCourses = { c1, c2, c3 };
            var courses = new UniCourses(rockCourses);

            App.Welcome();

            App.RunApp(students, courses);


        }


    }
}
