using NUnit.Framework;
using MyUniversity;

namespace UniTests
{
    public class CourseTest
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void OneCourse()
        {
            var course = new Course(101, "Fysikk", 4);
            var actual = course.CourseInfo();
            var expected = "101: Fysikk, deltagere: 4\n\n";

            Assert.AreEqual(expected, actual);
        }
    }

}
