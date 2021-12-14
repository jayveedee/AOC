using System;
using System.Collections.Generic;

namespace AOC2021.ScannerService
{
    public class BingoBoard
    {
        private readonly BingoMember[] _row;
        private readonly BingoMember[] _column;

        private BingoBoard(BingoMember[] row, BingoMember[] column)
        {
            _row = row;
            _column = column;
        }

        public static BingoBoard?[] Build(List<string> input, int numberOfBoards, int numberOfMembers)
        {
            var bingoBoards = new BingoBoard?[numberOfBoards];
            for (int i = 0; i < numberOfBoards; i++)
            {
                var boardStart = numberOfMembers * i;
                var row = new BingoMember[numberOfMembers];
                var column = new BingoMember[numberOfMembers];
                for (int j = boardStart; j < boardStart + numberOfMembers; j++)
                {
                    var rowOffset = j - boardStart;
                    var numbers = input[j + 1].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    row[rowOffset] = new BingoMember(numbers);
                    
                    var columnString = new string[numberOfMembers];
                    
                    for (int k = boardStart; k < boardStart + numberOfMembers; k++)
                    {
                        var columnOffset = k - boardStart;
                        columnString[columnOffset] = input[k + 1].Split(" ", StringSplitOptions.RemoveEmptyEntries)[rowOffset];
                    }
                    column[j - boardStart] = new BingoMember(columnString);
                }

                bingoBoards[i] = new BingoBoard(row, column);
            }

            return bingoBoards;
        }

        public void TryAdd(string bingoNumber)
        {
            foreach (var row in _row)
            {
                row.TryAdd(bingoNumber);
            }
            
            foreach (var column in _column)
            {
                column.TryAdd(bingoNumber);
            }
        }

        public bool HasBingo()
        {
            foreach (var row in _row)
            {
                if (row.GetBingo())
                {
                    return true;
                }
            }
            
            foreach (var column in _column)
            {
                if (column.GetBingo())
                {
                    return true;
                }
            }

            return false;
        }

        public string CalculatePoints(string bingoNumber)
        {
            var unMarked = 0;
            foreach (var row in _row)
            {
                for (var i = 0; i < row.Numbers.Length; i++)
                {
                    if (!row.Marked[i])
                    {
                        unMarked += Int32.Parse(row.Numbers[i]);
                    }
                }
            }

            return (unMarked * Int32.Parse(bingoNumber)).ToString();
        }

        private class BingoMember
        {
            private readonly string[] _numbers;
            private bool[] _marked;

            public BingoMember(string[] numbers)
            {
                _numbers = numbers;
                _marked = new bool[numbers.Length];
            }

            public bool GetBingo()
            {
                var counter = 0;
                for (int i = 0; i < _numbers.Length; i++)
                {
                    if (_marked[i])
                    {
                        counter++;
                    }
                }

                return counter == 5;
            }

            public void TryAdd(string bingoNumber)
            {
                for (int i = 0; i < _numbers.Length; i++)
                {
                    if (_numbers[i] == bingoNumber)
                    {
                        _marked[i] = true;
                    }
                }
            }

            public string[] Numbers => _numbers;

            public bool[] Marked
            {
                get => _marked;
                set => _marked = value ?? throw new ArgumentNullException(nameof(value));
            }
        }
    }
}