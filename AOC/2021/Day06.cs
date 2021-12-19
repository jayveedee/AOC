using System.Linq;
using AOC._2021.HelperService;

namespace AOC._2021
{
    public class Day06
    {
        public long PartOneTwo(string[] input, int days)
        {
            var fishies = new long[9];
            foreach (int x in input[0].Split(',').Select(long.Parse))
            {
                fishies[x] += 1;
            }
            for (int _ = 0; _ < days; _++)
            {
                var fish0 = fishies[0];
                for (int j = 0; j < 8; j++)
                {
                    fishies[j] = fishies[j + 1];
                }
                fishies[6] += fish0;
                fishies[8] = fish0;
            }

            return fishies.Sum();
        }
    }
}