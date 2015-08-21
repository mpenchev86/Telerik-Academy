using System;

class Program
{
    static void Main(string[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        if (A >= B)
        {
            if (A >= C)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(C);
            }
        }
        else
        {
            if (B>=C)
            {
                Console.WriteLine(B);
            }
            else
            {
                Console.WriteLine(C);
            }
        }

        if (A <= B)
        {
            if (A <= C)
            {
                Console.WriteLine(A);
            }
            else
            {
                Console.WriteLine(C);
            }
        }
        else
        {
            if (B <= C)
            {
                Console.WriteLine(B);
            }
            else
            {
                Console.WriteLine(C);
            }
        }

        Console.WriteLine("{0:F3}", (double)(A + B + C) / 3);

    }
}