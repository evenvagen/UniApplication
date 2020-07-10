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
            var course = new Course(102, "Naturfag", 0);
            var actual = student.AddCourse(course);

            Assert.AreEqual("\nJoe meldt på Naturfag\n", actual);

        }

        [Test]

        public void RemoveStudentFromCourse()
        {
            var course = new Course(102, "Naturfag", 0);
            var student = new Student("Joe", "joe@gmail.com", 1, course);

            var actual = student.RemoveCourse(course);

            Assert.AreEqual("\nJoe meldt av Naturfag\n", actual);
        }

        [Test]

        public void DuplicateAdd()
        {
            var course = new Course(102, "Naturfag", 0);
            var student = new Student("Joe", "joe@gmail.com", 1, course);

            var actual = student.AddCourse(course);

            Assert.AreEqual("Studenten er allerede meldt på dette kurset", actual);
        }


        [Test]

        public void CountParticipants()
        {
            var co2 = new Course(102, "Biologi", 1);
            var st3 = new Student("Christian", "christian@gmail.com", 3, co2);

            st3.RemoveCourse(co2);

            var actual = co2.Participants;

            Assert.AreEqual(0, actual);
        }

    }
}
