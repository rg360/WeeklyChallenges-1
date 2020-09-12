using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            throw new NotImplementedException();
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            else
            {

                int xEnding = numbers.Length - 1;

                if (xEnding < 1) return true;
                {
                    int aScend = numbers[0], i = 1;

                    while (i <= xEnding && aScend <= (aScend = numbers[i])) i++;

                    return i > xEnding;
                }
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            throw new NotImplementedException();

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            throw new NotImplementedException();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            throw new NotImplementedException();
        }
    }
}
