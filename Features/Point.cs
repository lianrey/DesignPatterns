using System;
namespace Features
{
    public class Point
    {
        public int Height
        {
            get;
            set;
        }

        public Point(int height){
            Height = height;
        }

        public static Point operator+ (Point a, Point b){
            Point point = new Point(a.Height + b.Height);
            return point;
        }

        public static Point operator- (Point a, Point b)
        {
            Point point = new Point(a.Height - b.Height);
            return point;
        }

        public static bool operator ==(Point a, Point b)
        {
            return (a.Height == b.Height);
        }

        public static bool operator !=(Point a, Point b)
        {
            return (a.Height != b.Height);
        }

    }
}
