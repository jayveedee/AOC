using src.utils.interfaces;

namespace src._2023
{
    public class D3 : IAdventOfCode
    {
        public int P1(string[] inputs)
        {
            var result = 0;
            var currentNumber = "";
            for (int i = 0; i < inputs.Length; i++)
            {
                var currentLine = inputs[i];
                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentChar = currentLine[j];
                    if (char.IsDigit(currentChar))
                    {
                        currentNumber += char.ToString(currentChar);
                        continue;
                    } else if (currentChar == '.')
                    {
                        currentNumber = "";
                        continue;
                    }


                }
            }

            return result;
        }

        public int P2(string[] inputs)
        {
            throw new NotImplementedException();
        }
    }
}
