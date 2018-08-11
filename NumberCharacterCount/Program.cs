using System;

namespace NumberCharacterCount
{
    class Program
    {
        private static void Main()
        {
            /*Q17 - If the numbers from 1 to 1000 (one thousand) inclusive were written in words, how many letters would be used?
            NOTE: Don't count spaces or hyphens. E.g. 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.*/
            Console.WriteLine("Solution to Number Letter Count - Question 17");
            Console.WriteLine();

            int num1to9 = "OneTwoThreeFourFiveSixSevenEightNine".Length;
            int num10to19 = "TenElevenTwelveThirteenFourteenFifteenSixteenSeventeenEighteenNineteen".Length;
            int num20to90 = "TwentyThirtyFortyFiftySixtySeventyEightyNinety".Length;

            //Calculations used to establish the number of times the same set of characters occur within a number range
            int num1to99 = (num1to9 * 9) + num10to19 + (num20to90 * 10);
            int hundred = "Hundred".Length * 9;
            int hundredAnd = "HundredAnd".Length * 99 * 9;
            int num1to1000 = (num1to9 * 100) + (num1to99 * 10) + hundred + hundredAnd + "oneThousand".Length;

            Console.WriteLine("Answer = " + num1to1000);

            //ReadKey(); Utilized to terminate the application easily
            Console.WriteLine();
            Console.WriteLine("\"Press any key to exit the application.\"");
            Console.ReadKey();
        }
    }
}
