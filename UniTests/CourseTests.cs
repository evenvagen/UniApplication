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
            var course = new Course(101, "Fysikk");
            var actual = course.CourseInfo();
            var expected = "101: Fysikk, deltagere: 0\n\n";

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MultipleCourses()
        { 
            var co1 = new Course(101, "Fysikk");
            var co2 = new Course(102, "Biologi");
            var co3 = new Course(103, "Matte");

            var actual = new UniCourses(co1, co2, co3).ShowAllCourses();
            var expected = "101: Fysikk, deltagere: 0\n\n" + "102: Biologi, deltagere: 0\n\n" +
                           "103: Matte, deltagere: 0\n\n";

            Assert.AreEqual(expected, actual);
        }
    }

}
