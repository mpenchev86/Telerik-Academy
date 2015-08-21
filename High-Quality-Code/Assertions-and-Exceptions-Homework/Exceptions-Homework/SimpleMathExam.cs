namespace Exceptions_Homework
{
    using System;

    public class SimpleMathExam : Exam
    {
        private const int MinProblemsSolved = 0;
        private const int MaxProblemsSolved = 10;
        private int problemsSolved;

        public SimpleMathExam(int problemsSolved)
        {
            this.ProblemsSolved = problemsSolved;
        }

        public int ProblemsSolved
        {
            get
            {
                return this.problemsSolved;
            }

            private set
            {
                if (value < 0)
                {
                    this.problemsSolved = SimpleMathExam.MinProblemsSolved;
                }

                if (value > 10)
                {
                    this.problemsSolved = SimpleMathExam.MaxProblemsSolved;
                }

                this.problemsSolved = value;
            }
        }

        public override ExamResult Check()
        {
            string comments;

            if (this.ProblemsSolved == 0)
            {
                comments = "Bad result: nothing done.";
            }
            else if (this.ProblemsSolved == 1)
            {
                comments = "Average result: nothing done.";
            }
            else if (this.ProblemsSolved == 2)
            {
                comments = "Average result: nothing done.";
            }
            else
            {
                comments = "Invalid number of problems solved!";
            }

            return new ExamResult(this.ProblemsSolved, SimpleMathExam.MinProblemsSolved, SimpleMathExam.MaxProblemsSolved, comments);
        }
    }
}