namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private string name;
        private ICollection<Course> courses;
        private ICollection<Student> students;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("School's name should be a valid non-empty string.");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Cannot add null to the list of students.");
            }

            if (this.Students.Any<Student>(x => x.Number == student.Number))
            {
                throw new InvalidOperationException(string.Format("A student with number {0} already exists.", student.Number));
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Cannot remove null from the list of students.");
            }

            if (!this.Students.Contains(student))
            {
                throw new InvalidOperationException("There's no such student in the list of students.");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Cannot add null to the list of courses.");
            }

            if (this.Courses.Any<Course>(x => x.Name == course.Name))
            {
                throw new InvalidOperationException(string.Format("A course with name '{0}' already exists.", course.Name));
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("course", "Cannot remove null from the list of courses.");
            }

            if (!this.Courses.Contains(course))
            {
                throw new InvalidOperationException("There is no such course in the list of courses.");
            }

            this.courses.Remove(course);
        }
    }
}
