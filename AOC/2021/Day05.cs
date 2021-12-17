using System;
using System.Collections.Generic;

namespace AOC._2021
{
    public class Day05
    {
        public int PartOne(string[] input)
        {
            return CalculateOverlaps(input);
        }

        public int PartTwo(string[] input)
        {
            return 0;
        }

        private int CalculateOverlaps(string[] input)
        {
            var grid = new int[10,10];
            var maxValueCounter = 0;
            foreach (var line in input)
            {
                var xFrom = Int32.Parse(line.Split()[0].Split(",")[0]);
                var yFrom = Int32.Parse(line.Split()[0].Split(",")[1]);
                var xTo = Int32.Parse(line.Split()[2].Split(",")[0]);
                var yTo = Int32.Parse(line.Split()[2].Split(",")[1]);
                
                if (xFrom != xTo && yFrom != yTo)
                {
                    continue;
                }
                
                for (int i = 0; i < GetDistance(line); i++)
                {
                    var tempXYValue = 0;
                    
                    if (xFrom == xTo || yFrom == yTo)
                    {
                        tempXYValue = GetTemporaryXYValue(line, grid, i);
                    }

                    if (tempXYValue == 2)
                    {
                        maxValueCounter++;
                    }
                }
            }

            return maxValueCounter;
        }

        private int GetDistance(string line)
        {
            var xFrom = Int32.Parse(line.Split()[0].Split(",")[0]);
            var yFrom = Int32.Parse(line.Split()[0].Split(",")[1]);
            var xTo = Int32.Parse(line.Split()[2].Split(",")[0]);
            var yTo = Int32.Parse(line.Split()[2].Split(",")[1]);
            
            // Vertical / Horizontal
            if (xFrom == xTo || yFrom == yTo)
            {
                if (xFrom == xTo)
                {
                    return yFrom > yTo ? yFrom - yTo : yTo - yFrom;
                }

                if (yFrom == yTo)
                {
                    return xFrom > xTo ? xFrom - xTo : xTo - xFrom;
                }
            }
            
            // Diagonal
            var xDiff = xFrom > xTo ? xFrom - xTo : xTo - xFrom;
            var yDiff = yFrom > yTo ? yFrom - yTo : yTo - yFrom;

            return xDiff == yDiff ? xDiff : 0;
        }

        private int GetTemporaryXYValue(string line, int[,] grid, int i)
        {
            var xFrom = Int32.Parse(line.Split()[0].Split(",")[0]);
            var yFrom = Int32.Parse(line.Split()[0].Split(",")[1]);
            var xTo = Int32.Parse(line.Split()[2].Split(",")[0]);
            var yTo = Int32.Parse(line.Split()[2].Split(",")[1]);
            
            
            
            
            if (xFromBigger || yFromBigger)
            {
                return GetXYValue(grid, xTo, xFrom, i, yTo, yFrom);
            }
            else
            {
                return GetXYValue(grid, xFrom, xTo, i, yFrom, yTo);
            }
        }

        private int GetXYValue(int[,] grid, int xFrom, int xTo, int i, int yFrom, int yTo)
        {
            return grid[GetXYPos(xFrom, xTo, i), GetXYPos(yFrom, yTo, i)] += 1;
        }

        private int GetXYPos(int from, int to, int i)
        {
            return from == to ? from : i + from;
        }
    }
}