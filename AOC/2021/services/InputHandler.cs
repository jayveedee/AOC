using System;
using System.IO;
using System.Linq;

namespace AOC.InputService
{

    public interface IInputHandler
    {
        string[] GetInput(int day, int part, bool isExample);
    }
    
    public class InputHandler : IInputHandler
    {
        private readonly string _startPath;
        private readonly string _examplePath;
        private readonly string _extPath;

        public InputHandler()
        {
            _startPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + @"\AOC\2021\Input\";
            _examplePath = "example";
            _extPath = ".txt";
        }

        public string[] GetInput(int day, int part, bool isExample)
        {
            var input = File.ReadAllLines(GetPath(day, part, isExample));
            return input.Where(line => !String.IsNullOrEmpty(line)).ToArray();
        }

        private string GetPath(int day, int part, bool isExample)
        {
            var dayPartPath = (day >= 10 ? day : "0" + day) + "." +  (isExample ? "1" : part);
            var fullPath = _startPath + dayPartPath + (isExample ? _examplePath + _extPath : _extPath);
            return fullPath;
        }
    }
}