using System;
namespace InterviewCake
{
    public class Question13
    {
        public int FindIndexOfRotation(string[] words)
        {
            string firstWord = words[0];

            int floorIndex = 0;
            int ceilingIndex = words.Length;

            while(floorIndex < ceilingIndex)
            {
                int guessIndex = floorIndex + ((ceilingIndex - floorIndex) / 2);

                if(string.Compare(words[guessIndex], firstWord, StringComparison.Ordinal) >= 0)
                {
                    floorIndex = guessIndex;
                }
                else
                {
                    ceilingIndex = guessIndex;
                }

                if(floorIndex +1 == ceilingIndex)
                {
                    break;
                }
            }

            return ceilingIndex;
        }
    }
}
