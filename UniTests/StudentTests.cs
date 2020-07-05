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
            var student = new Student("Jolene", "jolene@gmail.com", 4);
            var expected = "Jolene(4), jolene@gmail.com\n\n";
            var actutal = student.StudentInfo();
            Assert.AreEqual(expected,actutal);
        }
    }
}