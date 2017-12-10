using System;
using System.Linq;

namespace AoC_2017
{
    public class Day05
    {
        public static int PartOne(string[] input)
        {
            int steps = 0;
            int[] instructions = Array.ConvertAll(input, s => int.Parse(s));
            int pointer = 0;
            
            do
            {
                steps++;
                pointer = pointer + instructions[pointer]++;
                
            } while (pointer < instructions.Length);
            
            return steps;
        }
    }
}