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

            Assert.AreEqual("\nJoe fjernet fra Naturfag\n", actual);

        }

    }
}
