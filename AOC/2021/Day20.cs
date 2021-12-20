using System;
using System.Collections.Generic;

namespace AOC._2021
{
    public class Day20
    {
        public int PartOne(string[] input)
        {
            var imageEnhancementAlgorithm = input[0];

            var inputImage = GetInputImage(input, 1);

            return EnhanceImageRecursion(imageEnhancementAlgorithm, inputImage, 0, -1, 0, 2, new string[inputImage.Length - 2]);
        }

        private int EnhanceImageRecursion(string imageEnhancementAlgorithm, string[] inputImage, int lightPixels, int x, int y, int enhanceHowOften, string[] newList)
        {
            if (inputImage.Length == y + 3 && inputImage[0].Length == x + 3)
            {
                PrintGrid(inputImage);
                if (enhanceHowOften > 1)
                {
                    enhanceHowOften--;
                    var newInputImage = GetInputImage(newList, 0);
                    return EnhanceImageRecursion(imageEnhancementAlgorithm, newInputImage, 0, -1, 0, enhanceHowOften, new string[newInputImage.Length - 2]);
                }
                return lightPixels;
            }
            
            if (inputImage[0].Length != x + 3)
            {
                x++;
            }
            else if (inputImage.Length != y + 3)
            {
                x = 0;
                y++;
            }

            var binaryString = "";
            for (int i = y; i < y + 3; i++)
            {
                for (int j = x; j < x + 3; j++)
                {
                    if (inputImage[i][j] == '.')
                    {
                        binaryString += 0;
                    }
                    else
                    {
                        binaryString += 1;
                    }
                }
            }

            var binaryConvertedToBaseTwo = Convert.ToInt32(binaryString, 2);

            if (imageEnhancementAlgorithm[binaryConvertedToBaseTwo] == '#')
            {
                newList[y] += "#";
                lightPixels++;
            }
            else
            {
                newList[y] += ".";
            }

            return EnhanceImageRecursion(imageEnhancementAlgorithm, inputImage, lightPixels, x, y, enhanceHowOften, newList);
        }

        private void PrintGrid(string[] inputImage)
        {
            foreach (var line in inputImage)
            {
                Console.WriteLine(line);
            }
        }

        private string[] GetInputImage(string[] input, int start)
        {
            var inputWithEnclosedDots = new string[input.Length + 4 - start];

            for (int i = start; i < input.Length; i++)
            {
                var newInput = ".." + input[i] + "..";
                input[i] = newInput;
            }

            AddToStartAndEnd(input, inputWithEnclosedDots, 0, 2);

            for (int i = 2; i < inputWithEnclosedDots.Length - 2; i++)
            {
                inputWithEnclosedDots[i] = input[i - 2 + start];
            }

            AddToStartAndEnd(input, inputWithEnclosedDots, inputWithEnclosedDots.Length - 2, inputWithEnclosedDots.Length);

            return inputWithEnclosedDots;
        }

        private static void AddToStartAndEnd(string[] input, string[] inputWithEnclosedDots, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                var newInput = ".";
                for (int j = 1; j < input[1].Length; j++)
                {
                    newInput += ".";
                }

                inputWithEnclosedDots[i] = newInput;
            }
        }
    }
}