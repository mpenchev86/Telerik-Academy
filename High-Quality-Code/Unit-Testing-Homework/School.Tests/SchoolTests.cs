namespace School.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Linq;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolClassConstructorShouldWorkCorrectly()
        {
            var school = new School("School of Hard Knocks");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolClassConstructorShouldThrowWhenNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolClassConstructorShouldThrowWhenNameIsWhitespace()
        {
            var school = new School("                ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolClassConstructorShouldThrowWhenNameIsEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void AddingNewStudentShouldWorkCorrectly()
        {
            var school = new School("Greendale");
            var student = new Student("Britta Perry", 10002);
            school.AddStudent(student);
            Assert.ReferenceEquals(student, school.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullToStudentsListShouldThrow()
        {
            var school = new School("Greendale");
            school.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingStudentWithExistingNumberShouldThrow()
        {
            var school = new School("Greendale");
            var studentOne = new Student("Peshkata", 10000);
            school.AddStudent(studentOne);
            var studentTwo = new Student("Goshkata", 10000);
            school.AddStudent(studentTwo);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingExistingStudentShouldThrow()
        {
            var school = new School("Greendale");
            var studentOne = new Student("Peshkata", 10000);
            school.AddStudent(studentOne);
            school.AddStudent(studentOne);
        }

        [TestMethod]
        public void RemovingStudentShouldWorkCorrectly()
        {
            var school = new School("Greendale");
            var student = new Student("Britta Perry", 10002);
            var initialNumberOfStudents = school.Students.Count;
            school.AddStudent(student);
            school.RemoveStudent(student);
            var numberOfStudentsAfterRemoval = school.Students.Count;
            Assert.AreEqual(initialNumberOfStudents, numberOfStudentsAfterRemoval);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingNullFromStudentsShouldThrow()
        {
            var school = new School("Greendale");
            var student = new Student("Britta Perry", 10002);
            school.AddStudent(student);
            school.RemoveStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingNonexistingStudentShouldThrow()
        {
            var school = new School("Greendale");
            var studentOne = new Student("Britta Perry", 10002);
            school.AddStudent(studentOne);
            var studentTwo = new Student("Jeff Winger", 66372);
            school.RemoveStudent(studentTwo);
        }

        [TestMethod]
        public void AddingNewCourseShouldWorkCorrectly()
        {
            var school = new School("Greendale");
            var course = new Course("Grifting");
            school.AddCourse(course);
            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingNullToCoursesListShouldThrow()
        {
            var school = new School("Greendale");
            school.AddCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddingCourseWithExistingNameShouldThrow()
        {
            var school = new School("Greendale");
            var courseOne = new Course("Diving");
            school.AddCourse(courseOne);
            var courseTwo = new Course("Diving");
            school.AddCourse(courseTwo);
        }

        [TestMethod]
        public void RemovingCourseShouldWorkCorrectly()
        {
            var school = new School("Greendale");
            var course = new Course("Grifting");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.IsTrue(school.Courses.Count == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RemovingNullFromCoursesShouldThrow()
        {
            var school = new School("Greendale");
            school.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RemovingNonexistingCourseShouldThrow()
        {
            var school = new School("Greendale");
            var courseOne = new Course("Joking");
            school.AddCourse(courseOne);
            var courseTwo = new Course("Making out");
            school.RemoveCourse(courseTwo);
        }
    }
}
