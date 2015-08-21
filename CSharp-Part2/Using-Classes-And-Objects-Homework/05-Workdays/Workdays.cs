/*
Problem 5. Workdays
	• Write a method that calculates the number of workdays between today and given date, passed as parameter.
	• Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

internal class Workdays
{
	static void Main(string[] args)
	{
		Console.Write("Enter date after today DD/MM/YYYY: ");
		string dateInput = Console.ReadLine();
		Console.Write("Enter public holidays in format DD/MM/YYYY: ");
		string[] holidays = Console.ReadLine()
			.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
			.ToArray();

		DateTime endDate = DateTime.ParseExact(dateInput, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

		int result = WorkDays(endDate, holidays);
		Console.WriteLine("Working days between {0:dd/MM/yyyy} and {1:dd/MM/yyyy}: {2}", DateTime.Today, endDate, result);        
	}

	private static int WorkDays(DateTime endDate, string[] holidays)
	{
		int timeSpan = 0; 

		if (endDate == DateTime.Now)
		{
			return 0;
		}
		else if (endDate < DateTime.Now)
		{
			timeSpan = (endDate - DateTime.Now).Days;
		}
		else
		{
			timeSpan = (endDate - DateTime.Now).Days + 1;
		}

		int result = 0;
		for (int i = 0; i < Math.Abs(timeSpan); i++)
		{
			string dayToCheck = string.Empty;
			if (timeSpan > 0)
			{
				dayToCheck = DateTime.Now.AddDays(i).DayOfWeek.ToString();

				if (HolidayCheck(dayToCheck, holidays))
				{
					continue;
				}
				else
				{
					result++;
				}
			}
			else if (timeSpan < 0)
			{
				dayToCheck = DateTime.Now.Subtract(TimeSpan.FromDays(i)).DayOfWeek.ToString();
				Console.WriteLine(dayToCheck);
				if (HolidayCheck(dayToCheck, holidays))
				{
					continue;
				}
				else
				{
					result++;
				}
			}
		}

		return result;
	}

	static bool HolidayCheck(string dayToCheck, string[] holidays)
	{
		if (DateTime.ReferenceEquals(dayToCheck, DayOfWeek.Saturday.ToString()) ||
			DateTime.ReferenceEquals(dayToCheck, DayOfWeek.Sunday.ToString()))
		{
			return true;
		}
		foreach (string day in holidays)
		{
			if (dayToCheck == DateTime.Parse(day, CultureInfo.InvariantCulture).DayOfWeek.ToString())
			{
				return true;
			}
		}
		return false;
	}
}