using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;

namespace MyUniversity
{
    public class UniStudents
    {
        public List<Student> Students { get; set; }

        public UniStudents(Student[] student)
        { 
            Students = new List<Student>(student);
        }



        public void ListStudents(UniCourses c)
        {
            var i = "";
            foreach (var student in Students)
            {
                i += student.StudentInfo(c);
            }
            App.WriteL(i);
        }


    }
}
