using System.Collections.Generic;

namespace AOC2021
{
    public class Day5
    {
        public string PartOne(List<string> input)
        {
            var grid = new int[999,999];

            foreach (var line in input)
            {
                var xFrom = line.Split()[0].Split(",")[0];
                var yFrom = line.Split()[0].Split(",")[1];
                var xTo = line.Split()[2].Split(",")[0];
                var yTo = line.Split()[2].Split(",")[1];
                
                
            }

            return "";
        }
    }
}