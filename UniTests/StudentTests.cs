using NUnit.Framework;
using MyUniversity;

namespace UniTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void OneStudent()
        {
            var student = new Student("Jolene", "jolene@gmail.com", 1);
            var expected = "Jolene(1), jolene@gmail.com\n\n";
            var actutal = student.StudentInfo();
            Assert.AreEqual(expected,actutal);
        }

        [Test]
        public void MultipleStudents()
        {
            var st1 = new Student("Jolene", "jolene@gmail.com", 1);
            var st2 = new Student("John", "john@gmail.com", 2);
            var st3 = new Student("Christian", "christian@gmail.com", 3);

            var students = new UniStudents(st1, st2, st3);
            var actutal = students.ListStudents();
            var expected = "Jolene(1), jolene@gmail.com\n\n" + "John(2), john@gmail.com\n\n" +
                           "Christian(3), christian@gmail.com\n\n";

            Assert.AreEqual(expected, actutal);
        }
    }
}