using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger product = 1;
        int countAll = 0;

        do
        {
            string input = Console.ReadLine();
            long currentNum;

            if (input == "END")
            {
                Console.WriteLine(product);
                break;
            }
            else
            {
                currentNum = Convert.ToInt64(input);
                countAll++;
            }

            if (countAll % 2 != 0)
            {
                if (currentNum == 0)
                {
                    continue;
                }
                else
                {
                    long tempNum = currentNum;
                    string tempNUM = Convert.ToString(currentNum);

                    for (int i = 0; i < tempNUM.Length; i++)
                    {
                        if (tempNum % 10 == 0)
                        {
                            tempNum /= 10;
                        }
                        else
                        {
                            product = product * (tempNum % 10);
                            tempNum /= 10;
                        }
                    }
                }
            }

            if (countAll == 10)
            {
                Console.WriteLine(product);
                product = 1;
            }
        } while (true);
    }
}