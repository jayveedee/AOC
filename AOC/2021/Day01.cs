using System;

namespace AOC._2021
{
    public class Day01
    {
        public int PartOne(string[] input)
        {
            var lastNumber = -1;
            var increaseCounter = 0;
            foreach (var number in input)
            {
                if (lastNumber < Int32.Parse(number) && lastNumber > -1)
                {
                    increaseCounter += Int32.Parse(number);
                }
                lastNumber = Int32.Parse(number);
            }

            return increaseCounter;
        }
        
        public int PartTwo(string[] input)
        {
            var resultCounter = 0;

            var aCounter = 0;
            var aMeasurement = 0;
            var bCounter = -1;
            var bMeasurement = 0;
            var cCounter = -2;
            var cMeasurement = 0;
            var dCounter = -3;
            var dMeasurement = 0;
            
            foreach (var line in input)
            {
                var measurement = int.Parse(line);
                aCounter++;
                bCounter++;
                cCounter++;
                dCounter++;
                aMeasurement = IncreaseMeasurement(aCounter, measurement, aMeasurement);
                bMeasurement = IncreaseMeasurement(bCounter, measurement, bMeasurement);
                cMeasurement = IncreaseMeasurement(cCounter, measurement, cMeasurement);
                dMeasurement = IncreaseMeasurement(dCounter, measurement, dMeasurement);
                
                if (aCounter == 4 && bCounter == 3)
                {
                    resultCounter += Measure(aMeasurement, bMeasurement);
                    aCounter = 0;
                    aMeasurement = 0;
                }

                if (bCounter == 4 && cCounter == 3)
                {
                    resultCounter += Measure(bMeasurement, cMeasurement);
                    bCounter = 0;
                    bMeasurement = 0;
                }
                
                if (cCounter == 4 && dCounter == 3)
                {
                    resultCounter += Measure(cMeasurement, dMeasurement);
                    cCounter = 0;
                    cMeasurement = 0;
                }

                if (dCounter == 4 && aCounter == 3)
                {
                    resultCounter += Measure(dMeasurement, aMeasurement);
                    dCounter = 0;
                    dMeasurement = 0;
                }
            }

            return resultCounter;
        }

        private static int Measure(int previous, int next)
        {
            return previous < next ? 1 : 0;
        }

        private static int IncreaseMeasurement(int counter, int currentMeasurement, int calculatedMeasurement)
        {
            if (counter >= 1 && counter < 4)
            {
                calculatedMeasurement += currentMeasurement;
            }

            return calculatedMeasurement;
        }
    }
}