using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using MyUniversity;
using NuGet.Frameworks;

namespace UniTests
{
    public class StudentsToCourses
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]

        public void AddStudentToCourse()
        {
            var student = new Student("Joe", "joe@gmail.com", 1);
            var course = new Course(102, "Naturfag");
            var actual = student.AddCourse(course, student);

            Assert.AreEqual("\nJoe meldt på Naturfag\n", actual);

        }

        [Test]

        public void RemoveStudentFromCourse()
        {
            var course = new Course(102, "Naturfag");
            var student = new Student("Joe", "joe@gmail.com", 1, course);

            var actual = student.RemoveCourse(course, student);

            Assert.AreEqual("\nJoe meldt av Naturfag\n", actual);
        }

        [Test]

        public void DuplicateAdd()
        {
            var course = new Course(102, "Naturfag");
            var student = new Student("Joe", "joe@gmail.com", 1, course);

            var actual = student.AddCourse(course, student);

            Assert.AreEqual("Studenten er allerede meldt på dette kurset", actual);
        }


        [Test]

        public void CountParticipants()
        {
            var co2 = new Course(102, "Biologi");
            var st3 = new Student("Christian", "christian@gmail.com", 3, co2);

            st3.RemoveCourse(co2, st3);

            var actual = co2.Students.Count;

            Assert.AreEqual(0, actual);
        }

    }
}
