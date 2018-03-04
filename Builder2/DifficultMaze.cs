using System;
namespace Builder2
{
    public class DifficultMaze: IMazeType
    {
        public bool isValid(int rooms, int doors)
        {
            if (rooms > 4 && (doors < rooms * 4))
            {
                return true;
            }
            return false;
        }
    }
}
