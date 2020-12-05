using System;
using System.Collections.Generic;
using System.Text;

namespace SKY.Mill
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
                            Direction = Direction.West;
                            break;
                        case Direction.East:
                            Direction = Direction.South;
                            break;
                        case Direction.South:
                            Direction = Direction.East;
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
                    throw new ArgumentOutOfRangeException("Invalid command! Avaialable commands: 1 Move forward, 2 Move backward, 3 Turn right, 4 Turn left");
            }
        }
            
    }
}
