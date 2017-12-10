﻿using System;
using System.Linq;

namespace AoC_2017
{
    public class Day04
    {
        public static int PartOne(string[] passphrases)
        {
            int numValid = 0;

            foreach (string passphrase in passphrases)
            {
                string[] words = passphrase.Split(' ');
                string[] distinctWords = words.Distinct().ToArray();
                if (distinctWords.Length == words.Length)
                {
                    numValid++;
                }
            }

            return numValid;
        }
    }
}