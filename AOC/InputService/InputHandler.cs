using System;
using System.Collections.Generic;

namespace AOC.InputService
{

    public interface IInputHandler
    {
        string[] GetInput(int day, int part, bool isExample);
    }
    
    public class InputHandler : IInputHandler
    {
        private readonly string _startPath = @"C:\Users\fo0391\RiderProjects\AOC\AOC\2021\Input\";
        private readonly string _examplePath = "example";
        private readonly string _extPath = ".txt";

        public string[] GetInput(int day, int part, bool isExample)
        {
            return System.IO.File.ReadAllLines(GetPath(day, part, isExample));
        }

        private string GetPath(int day, int part, bool isExample)
        {
            var dayPartPath = (day >= 10 ? day : "0" + day) + "." +  (isExample ? "1" : part);
            var fullPath = _startPath + dayPartPath + (isExample ? _examplePath + _extPath : _extPath);
            return fullPath;
        }
    }
}