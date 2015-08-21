namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxNumberOfStudents = 30;
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
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
                    throw new ArgumentException("Course's name should be a valid non-empty string.");
                }
                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("student", "Cannot add null to the students in the course.");
            }

            if (this.Students.Contains(student))
            {
                throw new InvalidOperationException("This student already exists in this course.");
            }

            if (this.Students.Count + 1 == MaxNumberOfStudents)
            {
                throw new InvalidOperationException("The course is full.");
            }

            this.Students.Add(student);
        }

        public void RemoveStudent(Student studentToRemove)
        {
            if (studentToRemove == null)
            {
                throw new ArgumentNullException("studentToRemove", "Cannot add null to the students in a course.");
            }

            if (!this.Students.Contains(studentToRemove))
            {
                throw new InvalidOperationException("There's no such student in this course.");
            }

            this.Students.Remove(studentToRemove);
        }
    }
}
