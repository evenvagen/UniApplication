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

            var actual = st.AddStudentToCourse(101, 33);

            Assert.AreEqual( "John(33) Fysikk 101", actual);

        }

    }
}
