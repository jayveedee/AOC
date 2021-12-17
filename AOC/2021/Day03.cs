using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC._2021
{
    public class Day03
    {

        public int PartOne(string[] input)
        {
            var inputT = Transpose(input);

            string gammaBit = "", epsilonBit = "";
            foreach (var bits in inputT)
            {
                gammaBit += CalculateFrequency(bits, true);
                epsilonBit += CalculateFrequency(bits, false);
            }

            var gammaRate = Convert.ToInt32(gammaBit, 2);
            var epsilonRate = Convert.ToInt32(epsilonBit, 2);

            return gammaRate * epsilonRate;
        }

        private string[] Transpose(string[] input)
        {
            var inputT = new string[input[0].Length];
            for (var i = 0; i < inputT.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    var inputLine = input[j];
                    inputT[i] += inputLine[i];
                }
            }

            return inputT;
        }

        public int PartTwo(string[] input)
        {
            return 0;
        }

        private string CalculateFrequency(string bits, bool mostCommon)
        {
            var mostCommonBit = bits.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            if (mostCommon)
            {
                return mostCommonBit is '1' ? "1" : "0";
            }
            return mostCommonBit is not '1' ? "1" : "0";
        }
    }
}