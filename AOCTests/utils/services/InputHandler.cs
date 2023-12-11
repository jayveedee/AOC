using src.utils.interfaces;
using System.IO;

namespace src.utils.services
{
    public class InputHandler : IInputHandler
    {
        private readonly string _startPath;

        public InputHandler(int year)
        {
            _startPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + $@"\AOC\{year}\input\";
        }

        public string[] GetInput(int day, int part, bool isExample = false)
        {
            string fileName = "";

            if (isExample)
            {
                fileName = string.Format("d{0}e{1}", day, part);
            }
            else
            {
                fileName = string.Format("d{0}p{1}", day, part);
            }

            string filePath = _startPath + fileName;

            return File.ReadAllLines(filePath);
        }
    }
}

