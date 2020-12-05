using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationLibrary
{
    public class World
    {
        public World(int width, int height)
        {
            Width = width;
            Height = height;
            Players = new List<PlayerObject>();
        }
        public List<PlayerObject> Players { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public bool IsInside(Coordinate coordinate)
        {
            return !(coordinate.X > Width || coordinate.Y > Height);
        }
    }
    
}
