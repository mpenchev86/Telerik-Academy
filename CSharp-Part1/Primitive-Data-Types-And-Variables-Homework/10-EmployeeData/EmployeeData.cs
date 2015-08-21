/*
Problem 10. Employee Data

A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    • First name
    • Last name
    • Age (0...100)
    • Gender (m or f)
    • Personal ID number (e.g. 8306112507)
    • Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. 
Print the data at the console.
*/

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Darren";
        string lastName = "Aronofsky";
        sbyte age = 45;
        char gender = 'm';
        long personalIDNumber = 6902121492;
        int uniqueEmployeeNumber = 27563331;
        Console.WriteLine("\u2219 First name: {0}", firstName);
        Console.WriteLine("\u2219 Last name: {0}", lastName);
        Console.WriteLine("\u2219 Age: {0}", age);
        Console.WriteLine("\u2219 Gender: {0}", gender);
        Console.WriteLine("\u2219 Personal ID number: {0}", personalIDNumber);
        Console.WriteLine("\u2219 Unique employee number: {0}", uniqueEmployeeNumber);
    }
}