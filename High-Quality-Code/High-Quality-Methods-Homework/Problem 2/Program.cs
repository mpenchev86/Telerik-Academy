using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            string[] input = new string[T];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }

            for (int i = 0; i < input.Length; i++)
            {
                int[] seq = input[i].Split(' ').Select(int.Parse).ToArray();
                uint[] dif = new uint[seq.Length - 1];
                for (int j = 0; j < dif.Length; j++)
                {
                    dif[j] = (uint)Math.Abs(seq[j + 1] - seq[j]);
                }

                if (dif.Length == 1)
                {
                    Console.WriteLine("True");
                }

                for (int j = 1; j < dif.Length; j++)
                {
                    if (dif[j] - dif[j - 1] > 1 || dif[j] - dif[j - 1] < 0)
                    {
                        Console.WriteLine("False");
                        break;
                    }
                    if (j == dif.Length - 1)
                    {
                        Console.WriteLine("True");                        
                    }
                }
            }
        }
    }
}
