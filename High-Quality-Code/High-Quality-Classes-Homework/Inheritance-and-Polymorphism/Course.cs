namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course
    {
        private string caurseName;
        private string teacherName;
        private IList<string> students;

        protected Course(string name)
        {
            this.CourseName = name;
        }

        protected Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        protected Course(string name, string teacherName, IList<string> students)
            : this(name, teacherName)
        {
            this.Students = students;
        }

        public string CourseName
        {
            get
            {
                return this.caurseName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The course's name cannot be null or empty string.");
                }

                this.caurseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The teacher's name cannot be null or empty string.");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                foreach (var student in value)
                {
                    if (string.IsNullOrWhiteSpace(student))
                    {
                        throw new ArgumentException("A student's name cannot be null or empty string.");
                    }
                }

                this.students = value;
            }
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                var result = "{ " + string.Join(", ", this.Students) + " }";
                return result;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name + " { Name = ");
            result.Append(this.CourseName);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString().Trim();
        }
    }
}
