using System;
namespace Builder2
{
    public class StandarMaze : IMazeType
    {
        public bool isValid(int rooms, int doors)
        {
            if (rooms < 4 && (doors < rooms * 2))
            {
                return true;
            }
            return false;
        }
    }
}
