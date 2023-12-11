using src.utils.interfaces;

namespace src._2023
{
    public class D2 : IAdventOfCode
    {
        public int P1(string[] inputs)
        {
            int maxRedCubes = 12;
            int maxGreenCubes = 13;
            int maxBlueCubes = 14;

            int possibleGames = 0;
            foreach (string line in inputs)
            {
                int gameID = int.Parse(line.Split(':')[0].Split(' ')[1]);

                string[] subsets = line.Split(':')[1].Split(';');

                int currentRedCubes = 0;
                int currentGreenCubes = 0;
                int currentBlueCubes = 0;
                foreach (string subset in subsets)
                {
                    string[] subsubsets = subset.Split(',');

                    foreach (string subsubset in subsubsets) 
                    {
                        int amountOfCubes = int.Parse(subsubset.Split(' ')[0]);
                        string cubeType = subsubset.Split(' ')[1];

                        if (cubeType == "red")
                        {
                            currentRedCubes += amountOfCubes;
                        }
                        else if (cubeType == "green")
                        {
                            currentGreenCubes += amountOfCubes;
                        }
                        else
                        {
                            currentBlueCubes += amountOfCubes;
                        }
                    }
                }

                if (currentRedCubes <= maxRedCubes && currentGreenCubes <= maxGreenCubes && currentBlueCubes <= maxBlueCubes) 
                {
                    possibleGames++;
                }
            }

            return possibleGames;
        }

        public int P2(string[] inputs)
        {
            throw new NotImplementedException();
        }
    }
}
