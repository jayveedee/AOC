using System;
using System.Collections.Generic;

namespace AOC._2021
{
    public class Day05
    {
        public string PartOne(List<string> input)
        {
            return CalculateOverlaps(input, false);
        }

        public string PartTwo(List<string> input)
        {
            return CalculateOverlaps(input, true);
        }

        private string CalculateOverlaps(List<string> input, bool alsoDiagonal)
        {
            var grid = new int[10,10];
            var maxValueCounter = 0;
            foreach (var line in input)
            {
                var xFrom = Int32.Parse(line.Split()[0].Split(",")[0]);
                var yFrom = Int32.Parse(line.Split()[0].Split(",")[1]);
                var xTo = Int32.Parse(line.Split()[2].Split(",")[0]);
                var yTo = Int32.Parse(line.Split()[2].Split(",")[1]);

                var isDiagonal = false;
                if (xFrom != xTo && yFrom != yTo)
                {
                    if (alsoDiagonal)
                    {
                        isDiagonal = true;
                    }
                    else
                    {
                        continue;
                    }
                }

                var angle = Convert.ToInt32(Math.Atan2(yTo - yFrom, xTo - xFrom) * (180 / Math.PI));
                for (int i = 0; i < GetDistance(xFrom, xTo, yFrom, yTo); i++)
                {
                    var tempXYValue = 0;

                    var hasTheAngle = angle is 45 or -45 || (angle > 0 ? angle - 180 == -45 : angle + 180 == 45);
                    if (xFrom == xTo || yFrom == yTo)
                    {
                        tempXYValue = GetTemporaryXYValue(xFrom, xTo, yFrom, yTo, grid, i, isDiagonal);
                    }
                    else if (xFrom != xTo && yFrom != yTo && hasTheAngle)
                    {
                        tempXYValue = GetTemporaryXYValue(xFrom, xTo, yFrom, yTo, grid, i, isDiagonal);
                    }

                    if (tempXYValue == 2)
                    {
                        maxValueCounter++;
                    }
                }
            }

            return maxValueCounter.ToString();
        }

        private int GetDistance(int xFrom, int xTo, int yFrom, int yTo)
        {
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

        private int GetTemporaryXYValue(int xFrom, int xTo, int yFrom, int yTo, int[,] grid, int i, bool isDiagonal)
        {
            int tempXYValue;
            if (xFrom > xTo || yFrom > yTo)
            {
                tempXYValue = GetXYValue(grid, xTo, xFrom, i, yTo, yFrom, isDiagonal);
            }
            else
            {
                tempXYValue = GetXYValue(grid, xFrom, xTo, i, yFrom, yTo, isDiagonal);
            }

            return tempXYValue;
        }

        private int GetXYValue(int[,] grid, int xFrom, int xTo, int i, int yFrom, int yTo, bool isDiagonal)
        {
            return grid[GetXYPos(xFrom, xTo, i, isDiagonal), GetXYPos(yFrom, yTo, i, isDiagonal)] += 1;
        }

        private int GetXYPos(int from, int to, int i, bool isDiagonal)
        {
            if (isDiagonal)
            {
                return from > to ? from - i : from == to ? from : from + i;
            }
            else
            {
                return from == to ? from : i + from;
            }
        }
    }
}