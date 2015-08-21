/*
Problem 11. Bank Account Data
    • A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 
      3 credit card numbers associated with the account.
    • Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Wolfgang";
        string middleName = "Amadeus";
        string lastName = "Mozart";
        string holderName = "Wolfgang Amadeus Mozart";
        decimal availableBalance = 522876493.88M;
        string bankName = "Berenberg Bank";
        string iBAN = "DE25 1002 0000 1352 9254 06";
        long creditcardN1 = 7364049012058771;
        long creditcardN2 = 7364049012058772;
        long creditcardN3 = 7364049012058773;
        Console.WriteLine(firstName);
        Console.WriteLine(middleName);
        Console.WriteLine(lastName);
        Console.WriteLine(holderName);
        Console.WriteLine(availableBalance);
        Console.WriteLine(bankName);
        Console.WriteLine(iBAN);
        Console.WriteLine(creditcardN1);
        Console.WriteLine(creditcardN2);
        Console.WriteLine(creditcardN3);

    }
}
