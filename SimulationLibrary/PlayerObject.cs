﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimulationLibrary
{
    public class PlayerObject
    {
        public PlayerObject(Coordinate position)
        {
            Position = position;
            Direction = Direction.North;
        }

        public PlayerObject(int x, int y)
        {
            Position = new Coordinate(x,y);
            Direction = Direction.North;
        }

        public Direction Direction { get; set; }
        public Coordinate Position { get; set; }
        public Coordinate Command(int command)
        {
            switch (command)
            {
                case 0:
                    return Position;
                case 1: //Move Forward
                    switch (Direction)
                    {
                        case Direction.North:
                            Position.Y -= 1;
                            break;
                        case Direction.East:
                            Position.X += 1;
                            break;
                        case Direction.South:
                            Position.Y += 1;
                            break;
                        case Direction.West:
                            Position.X -= 1;
                            break;
                    }
                    return Position;
                case 2: //Move Backwards
                    switch (Direction)
                    {
                        case Direction.North:
                            Position.Y += 1;
                            break;
                        case Direction.East:
                            Position.X -= 1;
                            break;
                        case Direction.South:
                            Position.Y += 1;
                            break;
                        case Direction.West:
                            Position.X -= 1;
                            break;
                    }
                    return Position;
                case 3: //Turn Right
                    switch (Direction)
                    {
                        case Direction.North:
                            Direction = Direction.East;
                            break;
                        case Direction.East:
                            Direction = Direction.South;
                            break;
                        case Direction.South:
                            Direction = Direction.West;
                            break;
                        case Direction.West:
                            Direction = Direction.North;
                            break;
                    }
                    return Position;
                case 4: //Turn Left
                    switch (Direction)
                    {
                        case Direction.North:
                            Direction = Direction.West;
                            break;
                        case Direction.East:
                            Direction = Direction.North;
                            break;
                        case Direction.South:
                            Direction = Direction.East;
                            break;
                        case Direction.West:
                            Direction = Direction.South;
                            break;
                    }
                    return Position;
                default:
                    throw new ArgumentOutOfRangeException($"Invalid command! Avaialable commands: {Environment.NewLine} 1: Move forward{Environment.NewLine} 2: Move backward{Environment.NewLine} 3: Turn right{Environment.NewLine} 4: Turn left{Environment.NewLine}");
            }
        }
        public override string ToString()
        {
            return $"[{Position.X},{Position.Y}] facing {Direction}{Environment.NewLine}";
        }
    }
}
