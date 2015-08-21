/*
Problem 10.* Beer Time
    • A beer time is after  1:00 PM  and before  3:00 AM .
    • Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
      and prints  beer time  or  non-beer time  according to the definition above or  invalid time  if the time cannot be parsed. Note: You 
      may need to learn how to parse dates and times. 
*/

using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        DateTime inputTime;             // The DateTime variable stores the time the user inputs.
        bool parseCheck;

        Console.Write("Enter time (hours [01...12], minutes [00…59], AM / PM): ");
        parseCheck = DateTime.TryParseExact(Console.ReadLine(), "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out inputTime);     // It tries to parse the user input with the exact specified format.
        if (!parseCheck)            // If parse is impossible, the program prints "Invalid time" and exits.
        {
            Console.WriteLine("Invalid time");
            return;
        }

        DateTime startBeerTime = DateTime.ParseExact("01:00 pm", "hh:mm tt", CultureInfo.InvariantCulture);     //These two DateTime variables serve as the time frame we have to compare 'inputTime' with. They are stored in the same format.
        DateTime endBeerTime = DateTime.ParseExact("03:00 am", "hh:mm tt", CultureInfo.InvariantCulture);

        if (inputTime.TimeOfDay.CompareTo(startBeerTime.TimeOfDay) >= 0 || inputTime.TimeOfDay.CompareTo(endBeerTime.TimeOfDay) < 0)        // TimeOfDay works with the time elapsed since midnight. So beer time is either after 01:00 pm in the afternoon, or before 03:00 am in the morning. That is why we use the || operator.
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }

    }

}