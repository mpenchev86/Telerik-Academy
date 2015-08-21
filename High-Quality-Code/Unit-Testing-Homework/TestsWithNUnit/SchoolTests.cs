namespace School.TestsWithNUnit
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SchoolTests
    {
        [Test]
        public void AddingNullAsStudentShouldThrow()
        {
            var school = new School("Greendale");
            Student student = null;
            Assert.Throws(typeof(ArgumentNullException), 
                () => { school.AddStudent(student); });
        }
    }
}
