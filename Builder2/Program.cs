using System;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            var standard = new MazeBuilder()
                .Type(new StandarMaze())
                .Rooms(3)
                .Doors(4)
                .Builder();

            var standard2 = new MazeBuilder()
                .Type(new StandarMaze())
                .Rooms(30)
                .Doors(40)
                .Builder();

            var dificult = new MazeBuilder()
               .Type(new StandarMaze())
               .Rooms(30)
               .Doors(40)
               .Builder();
            
        }
    }
}
