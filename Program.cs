using System;
using System.IO;

namespace SKY.Mill
{
    class Program
    {
        private static World _world;
        
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                throw new ArgumentException($"Incorrect number of arguments: Expectes 4 integers. Got {args.Length}");
            }
            for (int i = 0; i < args.Length; i++)
            {
                if (!InputIsValid(args[i]))
                {
                    throw new ArgumentException($"Argument must be integer {args[i]}");
                }
            }

            InitializeSimulation(args);
            Console.Out.WriteLine("World initialzed!");
            

        }

        public static void InitializeSimulation(string[] args)
        {
            _world = new World(int.Parse(args[0]), int.Parse(args[1]));
            var player = new PlayerObject(int.Parse(args[2]), int.Parse(args[3]));
            _world.Players.Add(player);
        }

        private static bool InputIsValid(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
