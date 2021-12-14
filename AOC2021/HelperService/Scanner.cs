using System;
using System.Collections.Generic;

namespace AOC2021.ScannerService
{
    public interface IScanner
    {
        List<string> GetBasicInput();
        List<string> GetAdvancedInput();
    }
    
    public class Scanner : IScanner
    {
        
        public List<string> GetBasicInput()
        {
            Console.WriteLine("Enter dataset:");

            List<string> listOfInput = new List<string>();

            string input;
            while (!string.IsNullOrWhiteSpace(input = Console.ReadLine()!))
            {
                listOfInput.Add(input);
            }

            return listOfInput;
        }

        public List<string> GetAdvancedInput()
        {
            Console.WriteLine("Enter dataset:");

            List<string> listOfInput = new List<string>();
            
            while (true)
            {
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    if (input == "STOP")
                    {
                        break;
                    }
                    listOfInput.Add(input);
                }
            }

            return listOfInput;
        }
    }
}