
using System;
using AOC2021.ScannerService;

namespace AOC2021
{
    public static class Program
    {

        private static IScanner _scanner = new Scanner();
        
        public static void Main(String[] argv)
        {
            var basicInput = _scanner.GetBasicInput();
            // var advancedInput = _scanner.GetAdvancedInput();

            Day1 day1 = new Day1();
            // Console.WriteLine(day1.PartTwo(basicInput));

            Day2 day2 = new Day2();
            // Console.WriteLine(day2.PartOne(basicInput));
            // Console.WriteLine(day2.PartTwo(basicInput));

            Day3 day3 = new Day3();
            // Console.WriteLine(day3.PartOne(basicInput));

            Day4 day4 = new Day4();
            // Console.WriteLine(day4.PartOne(advancedInput));
            // Console.WriteLine(day4.PartTwo(advancedInput));

            Day5 day5 = new Day5();
            Console.WriteLine(day5.PartOne(basicInput));

            Day10 day10 = new Day10();
            // Console.WriteLine(day10.PartOne(basicInput));
            // Console.WriteLine(day10.PartTwo(basicInput)); NOT COMPLETE
        }
    }
}