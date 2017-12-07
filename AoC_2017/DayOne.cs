using System;

namespace AoC_2017
{
    class DayOne
    {
        public static void PartOne(string input)
        {
            int total = 0;
            Char previousDigit = input[input.Length - 1];
            Char currentDigit = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                currentDigit = input[i];

                if (previousDigit.Equals(currentDigit))
                {
                    total += (int)Char.GetNumericValue(currentDigit);
                }
                previousDigit = currentDigit;
            }

            Console.WriteLine("The Day One - Part One solution is: " + total.ToString());
        }

        public static void PartTwo(string input)
        {
            int total = 0;
            int half = input.Length / 2;
            var currentDigit = ' ';
            var comparisonDigit = ' ';

            for (int i = 0; i < input.Length; i++)
            {
                currentDigit = input[i];


                if ((i + half <= input.Length - 1))
                {
                    comparisonDigit = input[i + half];
                }
                else
                {
                    comparisonDigit = input[i - half];
                }

                if (comparisonDigit.Equals(currentDigit))
                {
                    total += (int)Char.GetNumericValue(currentDigit);
                }
                comparisonDigit = currentDigit;
            }

            Console.WriteLine("The Day One - Part Two solution is: " + total.ToString());
        }
    }
}