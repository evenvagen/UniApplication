using NUnit.Framework;
using MyUniversity;

namespace UniTests
{
    public class StudentsToCourses
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]

        public void AddCourse()
        {

            var co = new Course(101, "Fysikk", 0);

            var st = new Student("John", "john@gmail.com", 33, co);

            var actual = st.StudentCourse(101);

            Assert.AreEqual("101: Fysikk, deltagere: 1\n\n", actual);

        }

        [Test]

        public void AddMultipleStudents()
        {
            var co = new Course(101, "Fysikk", 0);

            var st = new Student("John", "john@gmail.com", 33, co);

            var st2 = new Student("Kate", "kate@gmail.com", 34, co);

            var st3 = new Student("Even", "even@gmail.com", 35, co);

            var students = new UniStudents(st, st2, st3);

            var actual = students.AddStudentsToCourses(101);

            Assert.AreEqual("101: Fysikk, deltagere: 3\n\n", actual);
        }
    }
}
