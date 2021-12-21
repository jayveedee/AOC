namespace AOC._2021
{
    public class Day21
    {
        public int PartOne(string[] input)
        {
            var playerOnePos = int.Parse(input[0].Split()[4]);
            var playerTwoPos = int.Parse(input[1].Split()[4]);

            int playerOneScore = 0, playerTwoScore = 0;
            int totalDiesRolled = 0;
            while (true)
            {
                var currentDieValue = IncreaseDie(ref totalDiesRolled);
                playerOnePos = GetScore(playerOnePos, currentDieValue, ref playerOneScore);
                if (playerOneScore >= 1000)
                {
                    break;
                }

                currentDieValue = IncreaseDie(ref totalDiesRolled);
                playerTwoPos = GetScore(playerTwoPos, currentDieValue, ref playerTwoScore);
                if (playerTwoScore >= 1000)
                {
                    break;
                }
            }

            return playerOneScore < playerTwoScore ? playerOneScore * totalDiesRolled : playerTwoScore * totalDiesRolled;
        }

        public long PartTwo(string[] input)
        {

            return 0;
        }

        private int GetScore(int position, int die, ref int score)
        {
            position += die;
            while (position > 10)
            {
                position -= position switch
                {
                    > 1000 => 1000,
                    > 100 => 100,
                    > 20 => 20,
                    _ => 10
                };
            }

            score += position;
            return position;
        }

        private int IncreaseDie(ref int totalDiesRolled)
        {
            var dieRolls = 0;
            for (int i = totalDiesRolled + 1; i < totalDiesRolled + 4; i++)
            {
                dieRolls += i;
            }

            totalDiesRolled += 3;

            return dieRolls;
        }
    }
}