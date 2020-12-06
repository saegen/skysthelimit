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
            bool showPath = false;
            try
            {
                //Inte den mest lättlästa koden...
                setup = args[1].Split("=")[1].Split(",").Select(a => int.Parse(a)).ToArray();
                commands = args[2].Split("=")[1].Split(",").Select(a => int.Parse(a)).ToArray();
                showPath = args.Length == 4;
            }
            catch (Exception)
            {
                Console.WriteLine($"Incorrect usage: SSKY.Simulation setup=int,int,int,int commands=int,int...,int");
                Environment.Exit(22);
            }

            try
            {
                _world = World.SetUp(setup);
                var succes = _world.StartSimulation(commands, showPath);
                Console.WriteLine($"{_world.Player.Position}");
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                Environment.Exit(13);
            }
            

        }

        
    }
}
