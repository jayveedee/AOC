using System;

namespace AOC._2021.HelperService
{
    public class Grid
    {
        private readonly int[,] _fields;
        private bool _diagonalToo;
        public int OverlappingLines { get; private set; }

        public Grid(int[,] fields, bool diagonalToo, int overlappingLines = 0)
        {
            _fields = fields;
            _diagonalToo = diagonalToo;
            OverlappingLines = overlappingLines;
        }

        public void TryAddLine(string from, string to)
        {
            var xyFrom = GetXYValues(from);
            var xyTo = GetXYValues(to);
            
            // Horizontal / Vertical
            if (xyFrom[0] == xyTo[0])
            {
                CheckOverlapsHV(xyFrom, xyTo, false);
            } 
            else if (xyFrom[1] == xyTo[1])
            {
                CheckOverlapsHV(xyFrom, xyTo, true);
            }
            // Diagonal
            else if (_diagonalToo)
            {
                CheckOverlapsD(xyFrom, xyTo);
            }
        }

        private int[] GetXYValues(string values)
        {
            var xyValues = new int[2];
            xyValues[0] = Convert.ToInt32(values.Split(",")[0]);
            xyValues[1] = Convert.ToInt32(values.Split(",")[1]);
            return xyValues;
        }

        private void CheckOverlapsHV(int[] xyFrom, int[] xyTo, bool isHorizontal)
        {
            int from, to;
            if (isHorizontal)
            {
                from = xyFrom[0] < xyTo[0] ? xyFrom[0] : xyTo[0];
                to = xyFrom[0] > xyTo[0] ? xyFrom[0] : xyTo[0];
            }
            else
            {
                from = xyFrom[1] < xyTo[1] ? xyFrom[1] : xyTo[1];
                to = xyFrom[1] > xyTo[1] ? xyFrom[1] : xyTo[1];
            }
            
            for (int i = 0; i < to - from + 1; i++)
            {
                if (isHorizontal)
                {
                    _fields[i + from, xyFrom[1]] += 1;
                    if (_fields[i + from, xyFrom[1]] == 2)
                    {
                        OverlappingLines++;
                    }
                }
                else
                {
                    _fields[xyFrom[0], i + from] += 1;
                    if (_fields[xyFrom[0], i + from] == 2)
                    {
                        OverlappingLines++;
                    }
                }
                
            }
        }
        
        private void CheckOverlapsD(int[] xyFrom, int[] xyTo)
        {
            var from = xyFrom[0] < xyTo[0] ? xyFrom : xyTo;
            var to = xyFrom[0] > xyTo[0] ? xyFrom : xyTo;

            var goUp = from[0] < to[0] && from[1] < to[1];
            if (goUp)
            {
                for (int i = 0; i < to[0] - from[0] + 1; i++)
                {
                    _fields[from[0] + i, from[1] + i] += 1;
                    if (_fields[from[0] + i, from[1] + i] == 2)
                    {
                        OverlappingLines++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < to[0] - from[0] + 1; i++)
                {
                    _fields[from[0] + i, from[1] - i] += 1;
                    if (_fields[from[0] + i, from[1] - i] == 2)
                    {
                        OverlappingLines++;
                    }
                }
            }
        }

        public void PrintGrid()
        {
            for (int i = 0; i < _fields.GetLength(0); i++)
            {
                for (int j = 0; j < _fields.GetLength(1); j++)
                {
                    Console.Write("{0} ", _fields[i,j]);
                }
                Console.Write(Environment.NewLine);
            }
            
        }
    }
}