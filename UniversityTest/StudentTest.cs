using MyUniversity;
using NUnit.Framework;

namespace UniversityTest
{
    public class Tests
    {
        

        [Test]
        public void StudentTest()
        {
            var student = new Student("Even", "evenvagen@gmail.com", 1);

            var result = student.StudentInfo();
            const string expected = "Even(1), evenvagen@gmail.com\nMeldt på 0 kurs\n\n";
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AddStudentToCourse()
        {
            var student = new Student("Jack", "jack@mail.net", 99);
            var course = new Course(2, "Politics");

            var actual = student.AddCourse(course, student);

            var expected = "\nJack meldt på Politics\n";
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveStudentFromCourse()
        {
            var course = new Course(2, "Politics");
            var student = new Student("Jack", "jack@mail.net", 99, course);

            var actual = student.RemoveCourse(course, student);

            var expected = "\nJack meldt av Politics\n";
            
            Assert.AreEqual(expected, actual);

        }
    }
}