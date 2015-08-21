using System;

class Program
{
    static void Main(string[] args)
    {
        int SECRET = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        int isEven = 0;
        double currentInt;

        foreach (char current in text)
        {
            currentInt = Convert.ToDouble(Convert.ToInt16(current));
            if (current == '@')
            {
                return;
            }
            else if ((current >= 'A' && current <= 'Z') || (current >= 'a' && current <= 'z'))
            {
                currentInt = currentInt * SECRET + 1000;
            }
            else if (current >= '0' && current <= '9')
            {
                currentInt = currentInt + SECRET + 500;
            }
            else
            {
                currentInt -= SECRET;
            }


            if (isEven % 2 == 0)
            {
                currentInt = currentInt / 100;
                Console.WriteLine("{0:0.00}", currentInt);
            }
            else
            {
                currentInt *= 100;
                Console.WriteLine(currentInt);
            }

            isEven++;

        }
    }
}