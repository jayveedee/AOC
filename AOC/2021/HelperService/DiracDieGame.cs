namespace AOC._2021.HelperService
{
    public class DiracDieGame
    {
        private readonly DiracPlayer[] _players;
        private long _totalDies;

        private DiracDieGame(DiracPlayer[] players, long totalDies)
        {
            _players = players;
            _totalDies = totalDies;
        }

        public static DiracDieGame Build(string[] input)
        {
            var players = new DiracPlayer[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                var playerInput = input[i];
                var player = new DiracPlayer(int.Parse(playerInput.Split()[4]));
                players[i] = player;
            }

            return new DiracDieGame(players, 0);
        }

        public long PlayDiracDieGame()
        {
            while (true)
            {
                foreach (var player in _players)
                {
                    _totalDies += 3;
                    player.AddNodes();
                }
            }

            return 0;
        }
    }

    public class DiracTreeNode
    {
        private long _nodeScore;
        private DiracPlayer _player;
        private DiracTreeNode _root;
        private DiracTreeNode[] _branches;

        public DiracTreeNode(DiracTreeNode root, DiracPlayer player)
        {
            _root = root;
            _player = player;
            _nodeScore = root._nodeScore;
            _branches = new DiracTreeNode[3];
        }
    }

    public class DiracPlayer
    {
        public long PlayerScore { get; private set; }
        public DiracTreeNode DiracTreeNode { get; private set; }

        public DiracPlayer(long playerScore)
        {
            PlayerScore = playerScore;
        }

        public void AddScore(long score)
        {
            PlayerScore += score;
        }

        public void AddNodes()
        {

        }
    }
}