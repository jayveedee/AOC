using src.utils.interfaces;

namespace src._2023;

public class D1 : IAdventOfCode
{
    public int P1(string[] inputs)
    {
        int sumOfCalibrationValues = 0;
        foreach (var input in inputs)
        {
            int calibrationValue = FindNumberPair(input);
            sumOfCalibrationValues += calibrationValue;
        }

        return sumOfCalibrationValues;
    }

    public int P2(string[] inputs)
    {
        throw new NotImplementedException();
    }

    private int FindNumberPair(string line)
    {
        char firstNumber = FindFirstNumber(line);

        char[] lineChar = line.ToCharArray();
        Array.Reverse(lineChar);
        char lastNumber = FindFirstNumber(new string(lineChar));

        return int.Parse(char.ToString(firstNumber) + char.ToString(lastNumber));
    }

    private char FindFirstNumber(string line)
    {
        foreach (var character in line)
        {
            if (Char.IsDigit(character))
            {
                return character;
            }
        }
        return ' ';
    }
}
