namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExceptionsHomework
    {
        public static void Main()
        {
            var substr = Utils.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Utils.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            try
            {
                Console.WriteLine(Utils.ExtractEnding("I love C#", 2));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName);
            }

            try
            {
                Console.WriteLine(Utils.ExtractEnding("Nakov", 4));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName);
            }

            try
            {
                Console.WriteLine(Utils.ExtractEnding("beer", 4));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName);
            }

            try
            {
                Console.WriteLine(Utils.ExtractEnding("Hi", 100));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ParamName);
            }

            Utils.CheckPrime(23);
            Utils.CheckPrime(33);

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}