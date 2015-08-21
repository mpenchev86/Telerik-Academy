namespace School.Tests
{
    using System;
    using System.Diagnostics;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentShouldNotThrowAnException()
        {
            var student = new Student("Pepito Bee", 73773);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedName()
        {
            var student = new Student("Spiridon Prostatiev", 89966);

            Assert.AreEqual("Spiridon Prostatiev", student.Name);
        }

        [TestMethod]
        public void StudentShouldReturnExpectedNumber()
        {
            var student = new Student("Bate Nencho", 87633);

            Assert.AreEqual(87633, student.Number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowIfNameArgumentIsNull()
        {
            var student = new Student(null, 87634);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowIfNameArgumentIsEmpty()
        {
            var student = new Student(string.Empty, 34344);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowForLowerNumberThanAllowed()
        {
            var student = new Student("Tsola Dragoycheva", 2312);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentShouldThrowForHigherNumberThanAllowed()
        {
            var student = new Student("Tsola Dragoycheva", 8383673);
        }
    }
}
