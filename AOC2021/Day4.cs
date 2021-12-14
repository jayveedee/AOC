using System;
using System.Collections.Generic;
using AOC2021.ScannerService;

namespace AOC2021
{
    public class Day4
    {
        public string PartOne(List<string> input)
        {
            var bingoNumbers = input[0].Split(",", StringSplitOptions.RemoveEmptyEntries);
            var bingoBoards = BingoBoard.Build(input, (input.Count - 1) / 5, 5);

            return PlayBingo(bingoNumbers, bingoBoards, false);
        }

        public string PartTwo(List<string> input)
        {
            var bingoNumbers = input[0].Split(",", StringSplitOptions.RemoveEmptyEntries);
            var bingoBoards = BingoBoard.Build(input, (input.Count - 1) / 5, 5);
            
            return PlayBingo(bingoNumbers, bingoBoards, true);
        }

        private string PlayBingo(string[] bingoNumbers, BingoBoard?[] bingoBoards, bool winLast)
        {
            foreach (var bingoNumber in bingoNumbers)
            {
                for (var i = 0; i < bingoBoards.Length; i++)
                {
                    var bingoBoard = bingoBoards[i];
                    if (bingoBoard == null)
                    {
                        continue;
                    }
                    bingoBoard.TryAdd(bingoNumber);
                    if (bingoBoard.HasBingo())
                    {
                        if (!winLast || (CountWonBingoBoards(bingoBoards) == bingoBoards.Length - 1))
                        {
                            return bingoBoard.CalculatePoints(bingoNumber);
                        }
                        else
                        {
                            bingoBoards[i] = null;
                        }
                    }
                }
            }

            return "";
        }

        private int CountWonBingoBoards(BingoBoard?[] bingoBoards)
        {
            var counter = 0;
            foreach (var bingoBoard in bingoBoards)
            {
                if (bingoBoard == null)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}