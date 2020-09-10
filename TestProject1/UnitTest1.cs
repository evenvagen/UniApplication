using MyUniversity;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void StudentTest()
        {
            var student = new Student("Even", "evenvagen@gmail.com", 1);

            var result = student.StudentInfo();
            
            
            
            
        }
    }
}