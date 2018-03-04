using System;
namespace Iterator
{
    public class Dice
    {
        public int roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, 6);
        }
    }
}
