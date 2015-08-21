/*
Problem 4. Print a Deck of 52 Cards
    • Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should 
      be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds). 
        ◦ The card faces should start from 2 to A.
        ◦ Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case 
          statement.
 
 output
2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
…  
K of spades, K of clubs, K of hearts, K of diamonds
A of spades, A of clubs, A of hearts, A of diamonds

 Note: You may use the suit symbols instead of text.
*/

using System;

class PrintADeckOf52Cards
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 14; i++)
        {
            for (int j = 3; j < 7 && i < 10; j++)
            {
                Console.Write("{0}{1} ", i, (char)j);           //Converts 'j' to its char value [3...6], which is visualized as one of the suits.
            }

            switch (i)
            {
                case 10:
                    Console.Write("J{0} J{1} J{2} J{3}", (char)3, (char)4, (char)5, (char)6);
                    break;
                case 11:
                    Console.Write("Q{0} Q{1} Q{2} Q{3}", (char)3, (char)4, (char)5, (char)6);
                    break;
                case 12:
                    Console.Write("K{0} K{1} K{2} K{3}", (char)3, (char)4, (char)5, (char)6);
                    break;
                case 13:
                    Console.Write("A{0} A{1} A{2} A{3}", (char)3, (char)4, (char)5, (char)6);
                    break;
                default:
                    break;
            }
            
            Console.WriteLine();

        }
    }
}