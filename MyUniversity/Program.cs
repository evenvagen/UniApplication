namespace MyUniversity
{
    class Program
    {
        static void Main(string[] args)
        {   var c1 = new Course(101, "Rocket science",2);
            var c2 = new Course(202, "Space mining", 2);
            var c3 = new Course(303, "Space farming", 1);

            Course[] allCourses = { c1, c2, c3 };
            var courses = new UniCourses(allCourses);


            var s1 = new Student("Joe","joe@nasa.com", 1, allCourses);
            var s2 = new Student("Kate", "kate@nasa.com", 2);
            var s3 = new Student("Alfred", "alfred@nasa.com", 3, c2, c1);


            Student[] stu = { s1, s2, s3 };
            var students = new UniStudents(stu);


            App.Welcome();

            App.RunApp(students, courses);


        }


    }
}
