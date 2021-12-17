using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC._2021
{
    public class Day03
    {

        public int PartOne(string[] input)
        {
            return CalculateBits(Transpose(input));
        }

        public int PartTwo(string[] input)
        {
            var oxyRating = CalculateRatingRecursion(input, true, 0);
            var scrubRating = CalculateRatingRecursion(input, false, 0);
            
            return Convert.ToInt32(oxyRating, 2) * Convert.ToInt32(scrubRating, 2);
        }

        private int CalculateBits(string[] inputT)
        {
            string gammaBit = "", epsilonBit = "";

            foreach (var bitsT in inputT)
            {
                var mostCommonBit = CalculateFrequency(bitsT, true);
                var mostUnCommonBit = CalculateFrequency(bitsT, false);

                gammaBit += mostCommonBit;
                epsilonBit += mostUnCommonBit;
            }
            
            return Convert.ToInt32(gammaBit, 2) * Convert.ToInt32(epsilonBit, 2);
        }

        private string CalculateRatingRecursion(string[] input, bool isMostCommon, int bitsToEval)
        {
            if (input.Length == 1)
            {
                return input[0];
            }
            
            var inputT = Transpose(input);
            var bitsT = inputT[bitsToEval];
            
            var mostCommonBit = CalculateFrequency(bitsT, true);
            var mostUnCommonBit = CalculateFrequency(bitsT, false);

            var filteredInputList = new List<string>();
            foreach (var bits in input)
            {
                var bitEval = isMostCommon ? mostCommonBit : mostUnCommonBit;
                if (bitEval[0] == bits[bitsToEval])
                {
                    filteredInputList.Add(bits);
                }
            }

            bitsToEval++;
            return CalculateRatingRecursion(filteredInputList.ToArray(), isMostCommon, bitsToEval);
        }

        private string[] Transpose(string[] input)
        {
            var inputT = new string[input[0].Length];
            for (var i = 0; i < inputT.Length; i++)
            {
                foreach (var inputLine in input)
                {
                    inputT[i] += inputLine[i];
                }
            }

            return inputT;
        }

        private string CalculateFrequency(string bits, bool mostCommon)
        {
            int counter0 = 0, counter1 = 0;
            foreach (var bit in bits)
            {
                if (bit == '0')
                {
                    counter0++;
                }
                else
                {
                    counter1++;
                }
            }
            var mostCommonBit = counter0 == counter1 ? '1' : (counter0 > counter1 ? '0' : '1');
            if (mostCommon)
            {
                return mostCommonBit is '1' ? "1" : "0";
            }
            return mostCommonBit is not '1' ? "1" : "0";
        }
    }
}