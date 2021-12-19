using System;
using System.Linq;

namespace AOC._2021
{
    public class Day08
    {
        public int PartOne(string[] input)
        {
            var patterns = new int[4] {2, 3, 4, 7};

            var counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                counter += input[i].Split("|")[1].Split().Sum(segment => patterns.Count(pattern => pattern == segment.Length));
            }

            return counter;
        }

        public int PartTwo(string[] input)
        {
            var decodedSegments = new DecodedSegment[9];
            while (true)
            {
                foreach (var segmentLine in input)
                {
                    var encodedLines = segmentLine.Split("|")[0];
                    for (int j = 0; j < encodedLines.Length; j++)
                    {
                        DecodedSegment? segment = null;
                        var encodedSegment = encodedLines.Split()[j];
                        switch (Convert.ToInt32(encodedSegment))
                        {
                            case 2:
                                segment = new DecodedSegment(encodedSegment, 2);
                                decodedSegments[2] = segment;
                                break;
                            case 3:
                                segment = new DecodedSegment(encodedSegment, 3);
                                decodedSegments[3] = segment;
                                break;
                            case 4:
                                segment = new DecodedSegment(encodedSegment, 4);
                                decodedSegments[4] = segment;
                                break;
                            case 7:
                                segment = new DecodedSegment(encodedSegment, 7);
                                decodedSegments[7] = segment;
                                break;
                        }

                        if (segment != null)
                        {
                            break;
                        }
                        
                    }
                }
            }
            
            return 0;
        }
        
        public class DecodedSegment
        {
            private readonly string _name;
            private readonly int _type;

            public DecodedSegment(string name, int type)
            {
                _name = name;
                _type = type;
            }

            public string Name => _name;

            public int Type => _type;
        }
    }
}