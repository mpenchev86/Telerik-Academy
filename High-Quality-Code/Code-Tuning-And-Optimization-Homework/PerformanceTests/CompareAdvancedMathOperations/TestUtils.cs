namespace CompareAdvancedMathOperations
{
    using System;
    using System.Diagnostics;

    public class TestUtils
    {
        private const int Repetitions = 10000000;
        private const float FloatOperand = 1.0F;
        private const double DoubleOperand = 1.0;
        private const decimal DecimalOperand = 1.0M;
        private static Stopwatch stopwatch = new Stopwatch();

        public static void TestSqrtOnAllTypes()
        {
            SqrtTesters.TestSqrtOnFloat();
            SqrtTesters.TestSqrtDouble();
            SqrtTesters.TestSqrtOnDecimal();
            Console.WriteLine();
        }

        public static void TestLogarithmOnAllTypes()
        {
            LogarithmTesters.TestLogarithmOnFloat();
            LogarithmTesters.TestLogarithmOnDouble();
            LogarithmTesters.TestLogarithmOnDecimal();
            Console.WriteLine();
        }

        public static void TestSineOnAllTypes()
        {
            SineTesters.TestSineOnFloat();
            SineTesters.TestSineOnDouble();
            SineTesters.TestSineOnDecimal();
            Console.WriteLine();
        }

        public static class SqrtTesters
        {
            public static void TestSqrtOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "SQRT on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = (float)Math.Sqrt(FloatOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSqrtDouble()
            {
                Console.Write(String.Format("{0,-30}", "SQRT on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = Math.Sqrt(DoubleOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSqrtOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "SQRT on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = (decimal)Math.Sqrt((double)DecimalOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        public static class LogarithmTesters
        {
            public static void TestLogarithmOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Logarithm on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = (float)Math.Log(FloatOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestLogarithmOnDouble()
            {
                Console.Write(String.Format("{0,-30}", "Logarithm on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = Math.Log(DoubleOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestLogarithmOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Logarithm on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = (decimal)Math.Log((double)DecimalOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        public static class SineTesters
        {
            public static void TestSineOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Sine on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = (float)Math.Sin(FloatOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSineOnDouble()
            {
                Console.Write(String.Format("{0,-30}", "Sine on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = Math.Sin(DoubleOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSineOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Sine on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result = (decimal)Math.Sin((double)DecimalOperand);
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }
    }
}
