using System;
using System.Collections.Generic;
namespace Builder2
{
    public class MazeBuilder
    {
        public IMazeType _type { get; set; }
        public int _rooms { get; set; }
        public int _doors { get; set; }

        public MazeBuilder Type(IMazeType type)
        {
            this._type = type;
            return this;
        }

        public MazeBuilder Rooms(int rooms)
        {
            this._rooms = (_type.isValid(rooms, _doors)) ? rooms: 0;
            return this;
        }

        public MazeBuilder Doors(int doors)
        {
            this._doors = (_type.isValid(_rooms, doors)) ? doors : 0;
            return this;
        }

        public Maze Builder(){
            return new Maze(_rooms, _doors);
        }
    }
}
