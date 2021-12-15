using System.Collections.Generic;

namespace AOC2021
{
    public class Day10
    {
        public string PartOne(List<string> input)
        {
            var opening = GetOpeningChunks();
            var closing = GetClosingChunks();

            var syntaxErrorsPoints = 0;
            
            foreach (var line in input)
            {
                var chunkStack = new Stack<char>();
                foreach (var character in line)
                {
                    if (opening.Contains(character))
                    {
                       chunkStack.Push(character);
                    }
                    
                    else if (opening.IndexOf(chunkStack.Peek()) == closing.IndexOf(character))
                    {
                        chunkStack.Pop();
                    }
                    else
                    {
                        syntaxErrorsPoints += CalculatePoints(character);
                        break;
                    }
                }
            }

            return syntaxErrorsPoints.ToString();
        }

        public string PartTwo(List<string> inputList)
        {
            var opening = GetOpeningChunks();
            var closing = GetClosingChunks();
            
            var listOfCorrectionPoints = new List<ulong>();

            foreach (var line in inputList)
            {
                ulong correctionPoints = 0;
                var chunkStack = new Stack<char>();
                foreach (var character in line)
                {
                    if (opening.Contains(character))
                    {
                        chunkStack.Push(character);
                    }

                    else if (opening.IndexOf(chunkStack.Peek()) == closing.IndexOf(character))
                    {
                        chunkStack.Pop();
                    }
                    else
                    {
                        correctionPoints = (correctionPoints * 5) + CorrectCorruption(character);
                        chunkStack.Pop();
                    }
                }

                while (chunkStack.Count > 0)
                {
                    correctionPoints = (correctionPoints * 5) + CorrectCorruption(closing[opening.IndexOf(chunkStack.Peek())]);
                    chunkStack.Pop();
                }
                listOfCorrectionPoints.Add(correctionPoints);
            }

            listOfCorrectionPoints.Sort();
            
            return listOfCorrectionPoints[listOfCorrectionPoints.Count / 2].ToString();
        }

        private ulong CorrectCorruption(char character)
        {
            return character switch
            {
                ')' => 1,
                ']' => 2,
                '}' => 3,
                '>' => 4,
                _ => 0
            };
        }

        private int CalculatePoints(char character)
        {
            return character switch
            {
                ')' => 3,
                ']' => 57,
                '}' => 1197,
                '>' => 25137,
                _ => 0
            };
        }

        private List<char> GetOpeningChunks()
        {
            var chunks = new List<char>
            {
                '(',
                '[',
                '{',
                '<'
            };
            return chunks;
        }
        
        private List<char> GetClosingChunks()
        {
            var chunks = new List<char>
            {
                ')',
                ']',
                '}',
                '>'
            };
            return chunks;
        }
    }
}