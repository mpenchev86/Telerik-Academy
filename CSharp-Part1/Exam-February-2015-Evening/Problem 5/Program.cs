using System;

class Program
{
    static void Main(string[] args)
    {
        int occur = 0;
        byte S = byte.Parse(Console.ReadLine());
        byte N = byte.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            int current = int.Parse(Console.ReadLine());
            int maskS = S & 31;

            for (int j = 0; j < 25; j++)
            {
                int maskN = 31 << j;
                int tempNum = current & maskN;
                tempNum = tempNum >> j;
                if (tempNum == maskS)
                {
                    occur++;
                }
            }
        }

        Console.WriteLine(occur);
    }
}