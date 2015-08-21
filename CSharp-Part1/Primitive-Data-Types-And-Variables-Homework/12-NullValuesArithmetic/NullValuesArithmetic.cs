/*
Problem 12. Null Values Arithmetic
    • Create a program that assigns null values to an integer and to a double variable. 
    • Try to print these variables at the console. 
    • Try to add some number or the null literal to these variables and print the result.
*/

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInteger = null;
        double? nullDouble = null;
        Console.WriteLine("nullInteger = {0}\t nullDouble = {1}\n", nullInteger, nullDouble);
        nullInteger = nullInteger + 73;         //If one of the operands is null, the result is also null.
        nullDouble = nullDouble + 8634.34523;
        Console.WriteLine("nullInteger = {0}\t nullDouble = {1}\n", nullInteger, nullDouble); 
        nullInteger = nullInteger + null;       //The warning is due to one operand explicitly being defined as the null literal.
        nullDouble = nullDouble + null;
        Console.WriteLine("nullInteger = {0}\t nullDouble = {1}\n", nullInteger, nullDouble);
    }
}
