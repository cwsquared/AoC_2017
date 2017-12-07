using System;

namespace AoC_2017
{
    class DayTwo
    {
        public static void PartOne(string[] input)
        {
            int checksum = 0;

            foreach (string line in input)
            {
                int high = int.MinValue;
                int low = int.MaxValue;
                string[] values = line.Split('\t');

                for (int i = 0; i < values.Length; i++)
                {
                    int currentValue = int.Parse(values[i]);
                    if (currentValue >= high)
                    {
                        high = currentValue;
                    }
                    else if (currentValue < low)
                    {
                        low = currentValue;
                    }
                }

                checksum += (high - low);
            }

            Console.WriteLine($"The Day 2, Part 1 solution is: {checksum}");
        }

        public static void PartTwo(string[] input)
        {
            int sum = 0;



            Console.WriteLine($"The Day 2, Part 1 solution is: {sum}");
        }
    }
}