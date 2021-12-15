using System;
using System.Collections.Generic;

namespace AOC2021.ScannerService
{
    public class Day2
    {
        public int PartOne(List<string> input, bool hasAim = false)
        {
            int x = 0, y = 0, aim = 0;

            foreach (var line in input)
            {
                var command = line.Split();
                if (command[0].Equals("forward"))
                {
                    x += Int32.Parse(command[1]);
                    if (hasAim)
                    {
                        y += aim * Int32.Parse(command[1]);
                    }
                }
                else if (command[0].Equals("up"))
                {
                    if (!hasAim)
                    {
                        y -= Int32.Parse(command[1]);
                    }
                    aim -= Int32.Parse(command[1]);
                }
                else if (command[0].Equals("down"))
                {
                    if (!hasAim)
                    {
                        y += Int32.Parse(command[1]);
                    }
                    aim += Int32.Parse(command[1]);
                }
            }

            return x * y;
        }

        public int PartTwo(List<string> input)
        {
            return PartOne(input, true);
        }
    }
}