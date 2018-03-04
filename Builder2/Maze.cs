using System;
namespace Builder2
{
    public class Maze
    {
        public int _rooms { get; set; }
        public int _doors { get; set; }

        public Maze(int rooms, int doors)
        {
            _rooms = rooms;
            _doors = doors;
        }
    }
}
