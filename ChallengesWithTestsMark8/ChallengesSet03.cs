using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //throw new NotImplementedException();

            bool checkBool = false;
            int pos = Array.IndexOf(vals, checkBool);
            if (pos > -1)
            {
                return true;
            }
                else
            {
                return false;
            }

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null)
            {
                return false;
            }
            else
            {
                int result = 0;


                foreach (int i in numbers)
                    if (i % 2 != 0)
                    {
                        result += i;
                    }


                return result % 2 != 0;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //throw new NotImplementedException();
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;
            for (int i = 0; i < password.Length
                && !(containsUpper && containsLower && containsNumber); i++)
            {
                char c = password[i];
                if (!containsUpper) containsUpper = char.IsUpper(c);
                if (!containsLower) containsLower = char.IsLower(c);
                if (!containsNumber) containsNumber = char.IsDigit(c);
            }
            return containsUpper && containsLower && containsNumber;

            //for (int i = 0; i < password.Length; i++)
            {

                //if (char.IsLower(password[i]) && char.IsUpper(password[i])
                //    && char.IsDigit(password[i]))
                //{
                //    return true;
                //}
            }
            //return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            //throw new NotImplementedException();
            char firstChar = val[0];
            return firstChar;
        }

        public char GetLastLetterOfString(string val)
        {
            //throw new NotImplementedException();

            char lastChar = val[val.Length - 1];

            return lastChar;

            //char lastChar = val.Last();

            //return lastChar;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            //throw new NotImplementedException();
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            //throw new NotImplementedException();

            int lastEl = nums[nums.Length - 1];
            int firstEl = nums[0];

            return lastEl - firstEl;

        }

        public int[] GetOddsBelow100()
        {

            //not started!!! 
            //throw new NotImplementedException();

            //attempt 1
            //int[] arr = new int[100];
            //int x = 0;
            //for (int i = 0; i < arr.Length; i ++)
            //{
            //    arr[i] = x;
            //    x += 3;
            //}
            //return arr;

            //attempt 2
            int[] oddsBelow100 = new int[50];
            int x = 1;
            for (int i = 0; i < oddsBelow100.Length; i++)
            {
                oddsBelow100[i] = x;
                x += 2;
            }
            return oddsBelow100;

        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //throw new NotImplementedException();
            //foreach (string wordUp in words)
            //    wordUp = words.ToUpper();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();

            }

        }
    }
}
