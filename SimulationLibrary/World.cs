using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimulationLibrary
{//1,4,1,3,2,3,2,4,1,0
    public class World
    {
        public static readonly Coordinate OffBoard = new Coordinate(-1, -1);
        public World(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public static World SetUp(int[] setup)
        {
            World _world = null;
            _world = new World(setup[0], setup[1]);
            var player = new PlayerObject(setup[2], setup[3]);
            _world.Player = player;
            return _world;
        }

        public bool StartSimulation(int[] cómmands)
        {
            foreach (var command in cómmands)
            {
                Player.Command(command);
                Console.WriteLine($"command:{command} => {Player}");
                if (Player.Position == OffBoard)
                {
                    return false;
                }
            }
            return true;
        }

        
        public PlayerObject Player { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool ValidatePlayerPosition()
        {
                if (!IsInside(Player.Position))
                {
                    Player.Position = OffBoard;
                    return false;
                }                     
            return true;
        }
        private bool IsInside(Coordinate coordinate)
        {
            return !(coordinate.X > Width || coordinate.Y > Height);
        }
    }
    
}
