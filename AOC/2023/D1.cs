using src.utils.interfaces;

namespace src._2023;

public class D1 : IAdventOfCode
{
    private readonly Dictionary<string, int> ListOfNumberWords = new Dictionary<string, int>();

    public D1()
    {
        ListOfNumberWords.Add("one", 1);
        ListOfNumberWords.Add("two", 2);
        ListOfNumberWords.Add("three", 3);
        ListOfNumberWords.Add("four", 4);
        ListOfNumberWords.Add("five", 5);
        ListOfNumberWords.Add("six", 6);
        ListOfNumberWords.Add("seven", 7);
        ListOfNumberWords.Add("eight", 8);
        ListOfNumberWords.Add("nine", 9);
    }

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
        int sumOfCalibrationValues = 0;
        foreach (var input in inputs)
        {
            int calibrationValue = FindNumberPair(input, true);
            sumOfCalibrationValues += calibrationValue;
        }

        return sumOfCalibrationValues;
    }

    private int FindNumberPair(string line, bool isNumberALetter = false)
    {
        string? firstNumber = "";
        string? lastNumber = "";

        // Start from left side
        for (int i = 0; i < line.Length; i++)
        {
            if (Char.IsDigit(line[i]))
            {
                firstNumber = char.ToString(line[i]);
                break;
            }
            if (Char.IsLetter(line[i]) && isNumberALetter)
            {
                int numberWord = FindNumberWord(line, i, false);
                if (numberWord != -1)
                {
                    firstNumber = "" + numberWord;
                    break;
                }
            }
        }

        if (line == "ddgjgcrssevensix37twooneightgt")
        {
            string test = "";
        }

        // Start from right side
        for (int i = line.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(line[i]))
            {
                lastNumber = char.ToString(line[i]);
                break;
            }
            if (Char.IsLetter(line[i]) && isNumberALetter)
            {
                int numberWord = FindNumberWord(line, i, true);
                if (numberWord != -1)
                {
                    lastNumber = "" + numberWord;
                    break;
                }
            }
        }

        Console.WriteLine(firstNumber + " " + lastNumber);
        return int.Parse(firstNumber + lastNumber);
    }

    private int FindNumberWord(string line, int startIndex, bool isReversed)
    {
        string word = "";
        string? numberWord = "";

        if (!isReversed)
        {
            for (int i = startIndex; i < line.Length; i++)
            {
                if (char.IsLetter(line[i]))
                {
                    word += line[i];
                    numberWord = CheckIfIsWord(word, false);
                    if (numberWord != null)
                    {
                        return int.Parse(numberWord);
                    }
                }
                else
                {
                    break;
                }
            }
        }
        else
        {
            for (int i = startIndex; i >= 0; i--)
            {
                if (char.IsLetter(line[i]))
                {
                    word += line[i];
                    numberWord = CheckIfIsWord(word, true);
                    if (numberWord != null)
                    {
                        return int.Parse(numberWord);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        return -1;
    }

    private string? CheckIfIsWord(string word, bool isReversed)
    {
        string? numberWord = null;
        try
        {
            if (!isReversed)
            {
                numberWord = "" + ListOfNumberWords[word.ToLower()];
            }
            else
            {
                char[] wordChar = word.ToCharArray();
                Array.Reverse(wordChar);
               
                numberWord = "" + ListOfNumberWords[new string(wordChar).ToLower()];
            }
        }
        catch (Exception)
        {

        }

        return numberWord; 
    }
}
