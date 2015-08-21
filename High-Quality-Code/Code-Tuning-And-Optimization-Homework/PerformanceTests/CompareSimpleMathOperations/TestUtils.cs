namespace CompareSimpleMaths
{
    using System;
    using System.Diagnostics;

    public class TestUtils
    {
        private const int Repetitions = 10000000;
        private const int IntOperand = 1;
        private const long LongOperand = 1L;
        private const float FloatOperand = 1.0F;
        private const double DoubleOperand = 1.0;
        private const decimal DecimalOperand = 1.0M;
        private static Stopwatch stopwatch = new Stopwatch();

        public static void TestAdditionOnAllTypes()
        {
            AdditionTesters.TestAdditionOnInt();
            AdditionTesters.TestAdditionOnLong();
            AdditionTesters.TestAdditionOnFloat();
            AdditionTesters.TestAdditionDouble();
            AdditionTesters.TestAdditionOnDecimal();
            Console.WriteLine();
        }

        public static void TestSubtractionOnAllTypes()
        {
            SubtractionTesters.TestSubtractionOnInt();
            SubtractionTesters.TestSubtractionOnLong();
            SubtractionTesters.TestSubtractionOnFloat();
            SubtractionTesters.TestSubtractionOnDouble();
            SubtractionTesters.TestSubtractionOnDecimal();
            Console.WriteLine();
        }

        public static void TestIncremetationOnAllTypes()
        {
            IncrementationTesters.TestIncrementationOnInt();
            IncrementationTesters.TestIncrementationOnLong();
            IncrementationTesters.TestIncrementationOnFloat();
            IncrementationTesters.TestIncrementationOnDouble();
            IncrementationTesters.TestIncrementationOnDecimal();
            Console.WriteLine();
        }

        public static void TestMultiplicationOnAllTypes()
        {
            MultiplicationTesters.TestMultiplicationOnInt();
            MultiplicationTesters.TestMultiplicationOnLong();
            MultiplicationTesters.TestMultiplicationOnFloat();
            MultiplicationTesters.TestMultiplicationOnDouble();
            MultiplicationTesters.TestMultiplicationOnDecimal();
            Console.WriteLine();
        }

        public static void TestDivisionOnAllTypes()
        {
            DivisionTesters.TestDivisionOnInt();
            DivisionTesters.TestDivisionOnLong();
            DivisionTesters.TestDivisionOnFloat();
            DivisionTesters.TestDivisionOnDouble();
            DivisionTesters.TestDivisionOnDecimal();
            Console.WriteLine();
        }

        public static class AdditionTesters
        {
            public static void TestAdditionOnInt()
            {
                Console.Write(String.Format("{0,-30}", "Addition on Int:"));

                stopwatch.Start();

                int result = IntOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result += IntOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestAdditionOnLong()
            {
                Console.Write(String.Format("{0,-30}", "Addition on Long:"));

                stopwatch.Start();

                long result = LongOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result += LongOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestAdditionOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Addition on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result += FloatOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestAdditionDouble()
            {
                Console.Write(String.Format("{0,-30}", "Addition on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result += DoubleOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestAdditionOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Addition on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result += DecimalOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        public static class SubtractionTesters
        {
            public static void TestSubtractionOnInt()
            {
                Console.Write(String.Format("{0,-30}", "Subtraction on Int:"));

                stopwatch.Start();

                int result = IntOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result -= IntOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSubtractionOnLong()
            {
                Console.Write(String.Format("{0,-30}", "Subtraction on Long:"));

                stopwatch.Start();

                long result = LongOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result -= LongOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSubtractionOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Subtraction on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result -= FloatOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSubtractionOnDouble()
            {
                Console.Write(String.Format("{0,-30}", "Subtraction on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result -= DoubleOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestSubtractionOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Subtraction on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result -= DecimalOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        public static class IncrementationTesters
        {
            public static void TestIncrementationOnInt()
            {
                Console.Write(String.Format("{0,-30}", "Incrementation on Int:"));
                stopwatch.Start();

                int result = IntOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result++;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestIncrementationOnLong()
            {
                Console.Write(String.Format("{0,-30}", "Incrementation on Long:"));

                stopwatch.Start();

                long result = LongOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result++;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestIncrementationOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Incrementation on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result++;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestIncrementationOnDouble()
            {
                Console.Write(String.Format("{0,-30}", "Incrementation on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result++;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestIncrementationOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Incrementation on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result++;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        public static class MultiplicationTesters
        {
            public static void TestMultiplicationOnInt()
            {
                Console.Write(String.Format("{0,-30}", "Multiplication on Int:"));

                stopwatch.Start();

                int result = IntOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result *= IntOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestMultiplicationOnLong()
            {
                Console.Write(String.Format("{0,-30}", "Multiplication on Long:"));

                stopwatch.Start();

                long result = LongOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result *= LongOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestMultiplicationOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Multiplication on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result *= FloatOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestMultiplicationOnDouble()
            {
                Console.Write(String.Format("{0,-30}", "Multiplication on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result *= DoubleOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestMultiplicationOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Multiplication on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result *= DecimalOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        public static class DivisionTesters
        {
            public static void TestDivisionOnInt()
            {
                Console.Write(String.Format("{0,-30}", "Division on Int:"));

                stopwatch.Start();

                int result = IntOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result /= IntOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestDivisionOnLong()
            {
                Console.Write(String.Format("{0,-30}", "Division on Long:"));

                stopwatch.Start();

                long result = LongOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result /= LongOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestDivisionOnFloat()
            {
                Console.Write(String.Format("{0,-30}", "Division on Float:"));

                stopwatch.Start();

                float result = FloatOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result /= FloatOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestDivisionOnDouble()
            {
                Console.Write(String.Format("{0,-30}", "Division on Double:"));

                stopwatch.Start();

                double result = DoubleOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result /= DoubleOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            public static void TestDivisionOnDecimal()
            {
                Console.Write(String.Format("{0,-30}", "Division on Decimal:"));

                stopwatch.Start();

                decimal result = DecimalOperand;
                for (int i = 0; i < Repetitions; i++)
                {
                    result /= DecimalOperand;
                }

                stopwatch.Stop();
                Console.WriteLine(stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }
    }
}
