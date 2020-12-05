using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using SimulationLibrary;
namespace SKY.Mill
{
    class Program
    {
        private static World _world;
        
        static void Main(string[] args)
        {
            if (args.Length != 1 )
            {
                Console.WriteLine($"Incorrect number of arguments: Expectes comma separated string of integers. Got {args.Length}");
                Environment.Exit(22);
            }
            int[] commands = null;
            try
            {
                commands = args[0].Split(",").Select(a => int.Parse(a)).ToArray();
            }
            catch (Exception)
            {
                Console.WriteLine($"Values must be integers");
                Environment.Exit(22);
            }
            
            InitializeSimulation(commands);
            
            Console.Out.WriteLine("Please enter commands: 1=Move forward, 2=Move backward, 3=Turn right, 4=Turn left, 0=Quit");
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

        public static void InitializeSimulation(int[] args)
        {
            _world = new World(args[0], args[1]);
            var player = new PlayerObject(args[2], args[3]);
            _world.Players.Add(player);
        }

        private static bool InputIsValid(string input)
        {
            return int.TryParse(input, out _);
        }
    }
}
