namespace School
{
    using System;

    public class Student
    {
        private const int MinStudentNumber = 10000;
        private const int MaxStudentNumber = 99999;
        private string name;
        private int number;

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
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
                    throw new ArgumentException("Student's should be a valid, non-empty string.");
                }
                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                if (value < MinStudentNumber || value > MaxStudentNumber)
                {
                    throw new ArgumentOutOfRangeException("Student's number should be between 10 000 and 99 999.");
                }
                this.number = value;
            }
        }
    }
}
