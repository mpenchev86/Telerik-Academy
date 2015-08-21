namespace Exceptions_Homework
{
    using System;

    public class CSharpExam : Exam
    {
        private const int MaxScore = 100;
        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Score" + " cannot be a negative number.");
                }

                if (value > CSharpExam.MaxScore)
                {
                    throw new ArgumentOutOfRangeException("Score" + " cannot be greater than " + "MaxScore");
                }

                this.score = value;
            }
        }

        public override ExamResult Check()
        {
            return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
        }
    }
}