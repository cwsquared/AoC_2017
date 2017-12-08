using System;
using System.Runtime.CompilerServices;

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

            foreach (string line in input)
            {
                string[] values = line.Split('\t');
                int value = 0;

                for (int i = 0; i < values.Length; i++)
                {
                    int iValue = int.Parse(values[i]);
                    for (int j = 0; j < values.Length; j++)
                    {
                        int jValue = int.Parse(values[j]);
                        if (iValue > jValue && iValue % jValue == 0)
                        {
                            value = iValue / jValue;
                            break;
                        }
                    }

                }

                sum += value;
            }

            Console.WriteLine($"The Day 2, Part 2 solution is: {sum}");
        }
    }
}