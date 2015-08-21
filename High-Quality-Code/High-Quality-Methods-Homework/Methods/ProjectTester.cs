namespace Methods
{
    using System;

    public class ProjectTester
    {
        public static void Main()
        {
            Console.WriteLine(MathUtils.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Converter.DigitToWord(5));

            Console.WriteLine(MathUtils.FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            NumberPrinter.PrintAsNumber(1.3, "f");
            NumberPrinter.PrintAsNumber(0.75, "%");
            NumberPrinter.PrintAsNumber(2.30, "r");

            Console.WriteLine(MathUtils.CalcDistanceBetweenPoints(3, -1, 3, 2.5));
            Console.WriteLine(MathUtils.GetLinePositionIn2D(3, -1, 3, 2.5));

            Student peter = new Student("Peter", "Ivanov");
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student("Stella", "Markova");
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
