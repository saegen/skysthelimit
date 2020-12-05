using System;
using System.Collections.Generic;
using System.Text;

namespace SKY.Console
{
    public class World
    {
        private int[,] _world = null;
                
        public World(int width, int height)
        {
            Width = width;
            Height = height;
            _world = new int[width, height];
        }
        public List<PlayerObject> Players { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
    
}
