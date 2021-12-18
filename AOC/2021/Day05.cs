using System;
using System.Collections.Generic;
using AOC._2021.HelperService;

namespace AOC._2021
{
    public class Day05
    {
        public int PartOne(string[] input)
        {
            Grid grid = new Grid(new int[999,999], false);
            foreach (var line in input)
            {
                var vents = line.Split();
                grid.TryAddLine(vents[0], vents[2]);
            }
            return grid.OverlappingLines;
        }

        public int PartTwo(string[] input, bool printGrid)
        {
            Grid grid = new Grid(new int[999,999], true);
            foreach (var line in input)
            {
                var vents = line.Split();
                grid.TryAddLine(vents[0], vents[2]);
            }

            if (printGrid)
            {
                grid.PrintGrid();
            }
            return grid.OverlappingLines;
        }
    }
}