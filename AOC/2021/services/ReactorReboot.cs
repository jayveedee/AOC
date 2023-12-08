namespace AOC._2021.HelperService
{
    public class ReactorReboot
    {
        private List<ReactorCube> _reactorCubes;

        private ReactorReboot(List<ReactorCube> reactorCubes)
        {
            _reactorCubes = reactorCubes;
        }

        public static ReactorReboot Build(string[] input)
        {
            var reactorCubes = new List<ReactorCube>();
            foreach (var currentReactorCubes in input)
            {
                var reactorCubeSetting = currentReactorCubes.Split()[0];
                var cubeXCoords = currentReactorCubes.Split()[1].Split(",")[0].Split("=")[1].Split("..");
                var cubeYCoords = currentReactorCubes.Split()[1].Split(",")[1].Split("=")[1].Split("..");
                var cubeZCoords = currentReactorCubes.Split()[1].Split(",")[2].Split("=")[1].Split("..");

                reactorCubes.AddRange(ReactorCube.BuildCubes(reactorCubeSetting, cubeXCoords, cubeYCoords, cubeZCoords));
            }

            return new ReactorReboot(reactorCubes);
        }
    }

    public class ReactorCube
    {
        private readonly int X, Y, Z;
        private bool IsOn;

        private ReactorCube(int x, int y, int z, bool isOn)
        {
            X = x;
            Y = y;
            Z = z;
            IsOn = isOn;
        }

        public static List<ReactorCube> BuildCubes(string isOn, string[] xRange, string[] yRange, string[] zRange)
        {
            var reactorCubes = new List<ReactorCube>();

            int xInterval = int.Parse(xRange[1]) - int.Parse(xRange[0]);
            int yInterval = int.Parse(yRange[1]) - int.Parse(yRange[0]);
            int zInterval = int.Parse(zRange[1]) - int.Parse(zRange[0]);

            int i = 0, k = 0, j = 0;
            while (true)
            {
                if (i == xInterval && k == yInterval && j == zInterval)
                {
                    break;
                }
                if (i == xInterval)
                {
                    i = 0;
                    k++;
                }
                else if (k == yInterval)
                {
                    k = 0;
                    j++;
                }
                else
                {
                    i++;
                }
                var cube = new ReactorCube(int.Parse(xRange[0]) + i, int.Parse(yRange[0]) + k, int.Parse(zRange[0]) + j, isOn == "on");
                if (reactorCubes.Contains(cube))
                {
                    reactorCubes.Find(cube)
                }
            }

            return reactorCubes;
        }

        public int X1 => X;

        public int Y1 => Y;

        public int Z1 => Z;

        public bool IsOn1
        {
            get => IsOn;
            set => IsOn = value;
        }
    }
}