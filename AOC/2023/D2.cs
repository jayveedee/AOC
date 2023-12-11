using src.utils.interfaces;

namespace src._2023
{
    public class D2 : IAdventOfCode
    {
        private readonly int MAX_RED_CUBES = 12;
        private readonly int MAX_GREEN_CUBES = 13;
        private readonly int MAX_BLUE_CUBES = 14;

        public int P1(string[] inputs)
        {
            return FindPossibleGamesAmount(inputs, false);
        }

        public int P2(string[] inputs)
        {
            return FindPossibleGamesAmount(inputs, true);
        }

        private int FindPossibleGamesAmount(string[] inputs, bool findMinimumViableGame)
        {
            int possibleGames = 0;
            foreach (string line in inputs)
            {
                int gameID = int.Parse(line.Split(':')[0].Split(' ')[1]);

                string[] subsets = line.Split(':')[1].Split(';');

                bool impossibleGame = false;

                int currentMaximumRedCubes = 0;
                int currentMaximumGreenCubes = 0;
                int currentMaximumBlueCubes = 0;

                foreach (string subset in subsets)
                {
                    string[] subsubsets = subset.Split(',');

                    int currentRedCubes = 0;
                    int currentGreenCubes = 0;
                    int currentBlueCubes = 0;

                    foreach (string subsubset in subsubsets)
                    {
                        string cleanedSet = subsubset.TrimStart(' ');
                        int amountOfCubes = int.Parse(cleanedSet.Split(' ')[0]);
                        string cubeType = cleanedSet.Split(' ')[1];

                        if (cubeType == "red")
                        {
                            currentRedCubes += amountOfCubes;
                            if (amountOfCubes > currentMaximumRedCubes)
                            {
                                currentMaximumRedCubes = amountOfCubes;
                            }
                        }
                        else if (cubeType == "green")
                        {
                            currentGreenCubes += amountOfCubes;
                            if (amountOfCubes > currentMaximumGreenCubes)
                            {
                                currentMaximumGreenCubes = amountOfCubes;
                            }
                        }
                        else
                        {
                            currentBlueCubes += amountOfCubes;
                            if (amountOfCubes > currentMaximumBlueCubes)
                            {
                                currentMaximumBlueCubes = amountOfCubes;
                            }
                        }

                        if ((currentRedCubes > MAX_RED_CUBES || currentGreenCubes > MAX_GREEN_CUBES || currentBlueCubes > MAX_BLUE_CUBES) && !findMinimumViableGame)
                        {
                            impossibleGame = true;
                            break;
                        }
                    }

                    if (impossibleGame && !findMinimumViableGame)
                    {
                        break;
                    }
                }

                if (!impossibleGame || findMinimumViableGame)
                {
                    if (findMinimumViableGame)
                    {
                        possibleGames += (currentMaximumRedCubes * currentMaximumGreenCubes * currentMaximumBlueCubes);
                    } else
                    {
                        possibleGames += gameID;
                    }
                }
            }

            return possibleGames;
        }
    }
}
