/*
Problem 2. Print Company Information
    • A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    • Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.WriteLine("This program reads information about a company and its manager and prints it" + "\n" + "back on the console." +"\n");

        string companyName;
        string companyAddress;
        string companyPhone;
        string companyFaxIn;
        int companyFaxOut = 0;
        string companyWebsite;
        string managerFirstName;
        string managerLastName;
        int managerAge;
        string managerPhone;
        bool parseCheck = false;

        Console.Write("Enter company name: ");
        companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        companyPhone = Console.ReadLine();
        do
        {
            Console.Write("Enter company fax: ");
            companyFaxIn = Console.ReadLine();

            if (companyFaxIn == "")
            {
                companyFaxIn = "(no fax)";
                break;
            }
            else
            {
                parseCheck = int.TryParse(companyFaxIn, out companyFaxOut);
            }
        } while (!parseCheck);
        parseCheck = false;
        Console.Write("Enter company website: ");
        companyWebsite = Console.ReadLine();
        Console.Write("Enter manager first name: ");
        managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name: ");
        managerLastName = Console.ReadLine();
        do
        {
            Console.Write("Enter manager age: ");
            parseCheck = int.TryParse(Console.ReadLine(), out managerAge);
        } while (!parseCheck);
        Console.Write("Enter manager phone number: ");
        managerPhone = Console.ReadLine();

        Console.WriteLine
            ("\n" + companyName + "\n" +
            "Address: " + companyAddress + "\n" +
            "Tel. {0}" + "\n" + "Fax: {1}" + "\n" +
            "Web site: " + companyWebsite + "\n" +
            "Manager: " + managerFirstName + managerLastName + "(age: {2}, tel. {3})",
            companyPhone, companyFaxIn == "(no fax)" ? companyFaxIn : Convert.ToString(companyFaxOut), managerAge, managerPhone);
    }
}
