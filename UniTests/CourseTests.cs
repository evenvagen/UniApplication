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

        [Test]
        public void MultipleCourses()
        { 
            var co1 = new Course(101, "Fysikk", 4);
            var co2 = new Course(102, "Biologi", 10);
            var co3 = new Course(103, "Matte", 12);

            var actual = new UniCourses(co1, co2, co3).ShowAllCourses();
            var expected = "101: Fysikk, deltagere: 4\n\n" + "102: Biologi, deltagere: 10\n\n" +
                           "103: Matte, deltagere: 12\n\n";

            Assert.AreEqual(expected, actual);
        }
    }

}
