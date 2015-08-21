/*
Problem 9. Play with Int, Double and String
    • Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. 
        ◦ If the variable is  int  or  double , the program increases it by one.
        ◦ If the variable is a  string , the program appends  *  at the end.
    • Print the result at the console. Use switch statement.
*/

using System;
using System.Globalization;
using System.Threading;

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter your choise: " + "\n" + "1 --> int" + "\n" + "2 --> double" + "\n" + "3 --> string" + "\n"); 
        int userInput;
        bool parseCheck = false;

        do
        {
            parseCheck = int.TryParse(Console.ReadLine(), out userInput); 
        } while(!parseCheck || userInput < 1 || userInput > 3);
        

        switch (userInput)
        {
            case 1:
                Console.Write("Please, enter an int variable: ");
                Console.WriteLine(int.Parse(Console.ReadLine()) + 1);
                break;
            case 2:
                Console.Write("Please, enter a double variable: ");
                Console.WriteLine(double.Parse(Console.ReadLine()) + 1);
                break;
            case 3:
                Console.Write("Please, enter a string: ");                
                Console.WriteLine(Console.ReadLine() + "*");
                break;
            default:
                break;
        }
    }
}
