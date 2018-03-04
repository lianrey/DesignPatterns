using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public class DiceEnumerable:IEnumerable
    {
        IList<Dice> diceList = new List<Dice>();

        public DiceEnumerable(IList<Dice> newDiceList){
            diceList = newDiceList;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var d in diceList)
            {
                yield return d.roll();
            }
        }
    }
}
