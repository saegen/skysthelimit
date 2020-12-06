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
        
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            int[] setup = null;
            int[] commands = null;
            try
            {
                //Inte den mest lättlästa koden...
                setup = args[1].Split("=")[1].Split(",").Select(a => int.Parse(a)).ToArray(); ;
                commands = args[2].Split("=")[1].Split(",").Select(a => int.Parse(a)).ToArray(); ;
            }
            catch (Exception)
            {
                Console.WriteLine($"Incorrect usage: SSKY.Simulation setup=int,int,int,int commands=int,int...,int");
                Environment.Exit(22);
            }

            _world = World.SetUp(setup);
            var succes =_world.StartSimulation(commands);
            Console.WriteLine($"{_world.Player.Position}");
            Environment.Exit(0);


            Console.Out.WriteLine("Please enter commands: 1=Move forward, 2=Move backward, 3=Turn right, 4=Turn left, 0=Quit");
            string command;
            var player = _world.Player;
            Console.Out.Write($"Player start: {player}{Environment.NewLine}");
            do
            {
                command = Console.In.ReadLine();
                player.Command(int.Parse(command));
                Console.Out.Write($"Player after command: {player}{Environment.NewLine}");

            } while (command != "0");
        }

        
    }
}
