
using System;
using AOC2021.ScannerService;

namespace AOC2021
{
    public static class Program
    {

        private static IScanner _scanner = new Scanner();
        
        public static void Main(String[] argv)
        {
            // var basicInput = _scanner.GetBasicInput();
            // var advancedInput = _scanner.GetAdvancedInput();

            Day3 day3 = new Day3();
            // Console.WriteLine(day3.PartOne(basicInput));

            Day4 day4 = new Day4();
            // Console.WriteLine(day4.PartOne(advancedInput));
            // Console.WriteLine(day4.PartTwo(advancedInput));
            
            
        }
    }
}