using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            throw new NotImplementedException();

            //not clear! 


        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            //throw new NotImplementedException();

            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }

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

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i] < numbers[i - 1])
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null)
            {
                return 0;

            }
            else
            {

                int sum = 0;

                for (int i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] % 2 == 0)
                    {
                        try
                        {
                            sum += numbers[i];
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    
                    }

                }
                return sum;
            }
            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //throw new NotImplementedException();
            var counter = 0;
            var newString = "";
            if (words == null)
            {
                return newString;
            }
            for (int i = 0; i < words.Length; i++)
            {
                counter++;
                if (words[i] == " " || words[i] == "" || words[i] == "  ")
                {
                    continue;
                }
                if (counter < words.Length)
                {
                    words[i] = words[i].Trim();
                    newString = newString + words[i] + " ";
                }
                if (counter == words.Length)
                {
                    words[i] = words[i].Trim();
                    newString += words[i] + ".";
                }
            }
            return newString;

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            //throw new NotImplementedException();

            if (elements == null)
            {
                return null;
            }
           
            List<double> fourthElement = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                fourthElement.Add(elements[i]);
            }

            return fourthElement.ToArray();

            
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
