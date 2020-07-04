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
        {   var c1 = new Course(101, "Rocket science",0);
            var c2 = new Course(202, "Space mining", 0);
            var c3 = new Course(303, "Space farming", 0);

            Course[] rockCourses = { c1, c2, c3 };
            var courses = new UniCourses(rockCourses);


            var s1 = new Student("Joe","joe@nasa.com", Guid.NewGuid());
            var s2 = new Student("Kate", "kate@nasa.com", Guid.NewGuid());
            var s3 = new Student("Alfred", "alfred@nasa.com", Guid.NewGuid());

            Student[] stu = { s1, s2, s3 };
            var students = new UniStudents(stu);


            App.Welcome();

            App.RunApp(students, courses);


        }


    }
}
