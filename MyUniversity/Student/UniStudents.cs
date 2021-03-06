﻿using System.Collections.Generic;
using System.Linq;

namespace MyUniversity
{
    public class UniStudents
    {
        public List<Student> Students { get; set; }

        public UniStudents(params Student[] student)
        { 
            Students = new List<Student>(student);
        }



        public string ListStudents()
        {
            var i = "";

            foreach (var student in Students)
            {
                i += student.StudentInfo();
            }

            return i;
        }

        public string RemoveStudents(int id)
        {
            var i = "";
            foreach (var student in Students.Where(s => s.Id == id).ToList())
            {
                if (student.Id.ToString() == id.ToString())
                {
                    Students.Remove(student);
                    i =  $"{student.Name}({student.Id}) fjernet";
                }
            }
            return i;
        }


        public string FindStudent(int id)
        {
            var i = "";
            foreach (var student in Students.Where(s => s.Id == id).ToList())
            {
                if (student.Id.ToString() == id.ToString()) i = student.StudentInfo();
            }
            return i;
        }



    }
}
