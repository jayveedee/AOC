using System;
using System.Collections.Generic;
using System.Linq;

namespace AOC2021
{
    public class Day3
    {

        public string PartOne(List<string> listOfInputs)
        {
            var listOfInputsT = Transpose(listOfInputs);

            string gammaBit = "", epsilonBit = "";
            foreach (var bits in listOfInputsT)
            {
                gammaBit += CalculateFrequency(bits, true);
                epsilonBit += CalculateFrequency(bits, false);
            }

            var gammaRate = Convert.ToInt32(gammaBit, 2);
            var epsilonRate = Convert.ToInt32(epsilonBit, 2);

            return (gammaRate * epsilonRate).ToString();
        }

        public string PartTwo(List<string> listOfInputs)
        {
            return "";
        }
        
        private List<string> Transpose(List<string> listOfInputs)
        {
            List<string> listOfInputsT = new List<string>();
            var line = listOfInputs[0];
            for (var i = 0; i < line.Length; i++)
            {
                listOfInputsT.Add("");
                for (int j = 0; j < listOfInputs.Count; j++)
                {
                    listOfInputsT[i] += line[j];
                }
            }

            return listOfInputsT;
        }
        
        private string CalculateFrequency(string bits, bool mostCommon)
        {
            var mostCommonBit = bits.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            if (mostCommon)
            {
                return mostCommonBit is '1' or '0' ? "1" : "0";
            }
            return mostCommonBit is not '1' or '0' ? "1" : "0";
        }
    }
}