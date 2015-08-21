/*
Problem 9. Exchange Variable Values
    • Declare two integer variables  a  and  b  and assign them with  5  and  10  and after that exchange their values by using some 
      programming logic.
    • Print the variable values before and after the exchange.
*/

using System;

class ExchangeValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Variable values before exchange: a = {0}, b = {1}", a, b);
        b = b - a;              //1 First we calculate the difference between 'a' and 'b' and assign it temporarily to 'b'.
        a = a + b;              //2 Then, we assign to 'a' the sum of this temporary 'b' with the initial value of 'a'. This sum now equals the initial value of 'b'. Therefore, 'a' acquired the initial value of 'b'.
        b = a - b;              //3 This line is unnecessary for the particular values stated in the assignment, because 'b' already acquired the initial value of 'a' (10-5=5). But it is mandatory if we want to use different values.
        Console.WriteLine("Variable values after exchange: a = {0}, b = {1}", a, b);
    }
}
