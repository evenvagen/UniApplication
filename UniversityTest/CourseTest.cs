using MyUniversity;
using NUnit.Framework;

namespace UniversityTest
{
    public class CourseTest
    {
        [Test]
        public void CourseStringTest()
        {
            var course = new Course(107, "utviklingsstudier");

            var actual = course.CourseInfo();
            const string expected = "107: utviklingsstudier, deltagere: 0\n\n";
            
            Assert.AreEqual(actual, expected);
        }
    }
}