namespace School.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CourseShoudNotThrowError()
        {
            var course = new Course("Counting");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowIfNameIsNull()
        {
            var course = new Course(null);
        }

        [TestMethod]
        public void CourseShoulReturnNameCorrectly()
        {
            var course = new Course("Counting");
            Assert.AreEqual("Counting", course.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowIfNameIsEmpty()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void CourseShouldAddStudentCorrectly()
        {
            var course = new Course("Counting");
            var student = new Student("Malkiq Goshko", 55555);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenNullStudentAdded()
        {
            var course = new Course("Counting");
            Student student = null;
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenExistingStudentIsAdded()
        {
            var course = new Course("Counting");
            Student student = new Student("Malkiq Goshko", 66666);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenMoreThanPossibleStudentsAdded()
        {
            var course = new Course("Counting");

            for (int i = 0; i < 35; i++)
            {
                course.AddStudent(new Student(i.ToString(), 10000 + 1));
            }
        }

        [TestMethod]
        public void CourseShouldRemoveStudentCorrectly()
        {
            var course = new Course("Counting");
            var student = new Student("Petyrcho", 88282);
            course.AddStudent(student);
            course.RemoveStudent(student);
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenRemovingNullStudent()
        {
            var course = new Course("Counting");
            Student student = null;
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowWhenRemovingNonexistingStudent()
        {
            var course = new Course("Counting");
            Student student = new Student("The Nonexistible", 10000);
            course.RemoveStudent(student);
        }
    }
}
