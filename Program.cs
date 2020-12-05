using System;
using System.Diagnostics;
using System.IO;
using SimulationLibrary;
namespace SKY.Mill
{
    class Program
    {
        private static World _world;
        
        static void Main(string[] args)
        {
            if (args.Length != 4)
            {
                Console.WriteLine($"Incorrect number of arguments: Expectes 4 integers. Got {args.Length}");
                Environment.Exit(22);
            }
            for (int i = 0; i < args.Length; i++)
            {
                if (!InputIsValid(args[i]))
                {
                    Console.WriteLine($"Argument {i}: is not an integer {args[i]}");
                    Environment.Exit(22);
                }
            }

            InitializeSimulation(args);
            
            Console.Out.WriteLine("Please enter commands: 1=Move forward, 2=Move backward, 3=Turn right, 4=Turn left, 0=Quit");
            int t = -1;
            string command;
            var player = _world.Players[0];
            Console.Out.Write($"Player start: {player}{Environment.NewLine}");
            do
            {
                command = Console.In.ReadLine();
                //Console.Out.WriteLine(command);
                //Console.Out.Write($"command: {int.Parse(command)}{Environment.NewLine}");
                
                //Console.Out.Write($"Player before command: {player}{Environment.NewLine}");
                player.Command(int.Parse(command));
                Console.Out.Write($"Player after command: {player}{Environment.NewLine}");
                
            } while (command != "0");
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
