using System;

namespace AoC_2017
{
    class Day03
    {
        public static int PartOne(int dayThreeInput)
        {
            int currOddNumber = -1;
            int currOddSquare = 0;

            do
            {
                currOddNumber += 2;
                currOddSquare = (int) Math.Pow((double) (currOddNumber), 2.0);
                
            } while (currOddSquare < dayThreeInput);

            int deltaSquareToEnd = currOddSquare - dayThreeInput;
            int halfSideDist = (currOddNumber - 1) / 2;
            int distance = halfSideDist + (halfSideDist - (deltaSquareToEnd % (currOddNumber - 1)));

            return distance;
        }

        public static void PartTwo(int dayThreeInput)
        {
            Console.WriteLine("Part 2 solution found without code, by looking it up at https://oeis.org/A141481/b141481.txt");
        }
    }
}