using System;
using System.Linq;

namespace AOC._2021
{
    public class Day07
    {
        public int PartOne(string[] input)
        {
            var crabs = Array.ConvertAll(input[0].Split(","), int.Parse);
            var median = GetMedian(crabs);

            var fuelSpent = 0;
            foreach (var crab in crabs)
            {
                if (crab != median)
                {
                    var diff = median >= crab ? median - crab : crab - median;
                    fuelSpent += diff;
                }
            }
            
            return fuelSpent;
        }

        public int PartTwo(string[] input)
        {
            var crabs = Array.ConvertAll(input[0].Split(","), int.Parse);
            var mean = GetMean(crabs);

            var fuelSpent = 0;
            foreach (var crab in crabs)
            {
                if (crab != mean)
                {
                    var diff = mean >= crab ? mean - crab : crab - mean;
                    for (int i = 1; i < diff + 1; i++)
                    {
                        fuelSpent += i;
                    }
                }
            }

            return fuelSpent;
        }

        private int GetMedian(int[] crabs)
        {
            var crabsLength = crabs.Length;
            
            Array.Sort(crabs);
            
            if (crabsLength % 2 != 0)
            {
                return crabs[crabsLength / 2];
            }

            return (crabs[(crabsLength - 1) / 2] + crabs[crabsLength / 2]) / 2;
        }

        private int GetMean(int[] crabs)
        {
            return Convert.ToInt32(Math.Round(crabs.Average())) - 1;
        }
    }
}