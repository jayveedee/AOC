using System;

namespace AOC._2021
{
    public class Day02
    {
        public int PartOne(string[] input, bool hasAim)
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

        public int PartTwo(string[] input)
        {
            return PartOne(input, true);
        }
    }
}