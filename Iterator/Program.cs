using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IList<Dice> dice = new List<Dice>();
            dice.Add(new Dice());
            dice.Add(new Dice());
            DiceEnumerable en = new DiceEnumerable(dice);

            IEnumerator results = en.GetEnumerator();
            while(results.MoveNext()){
                Console.WriteLine(results.Current);
            }
        }
    }
}
