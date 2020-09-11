using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        private object arr;

        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            bool result;
            result = char.IsLetter(c);
            return result;

  
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //throw new NotImplementedException();

            //var elementCount = vals.Length();
            //int i = 0;
            //return vals.Count(x => (i % 2 == 0(x)));

            int elementCount = vals.GetLength(0);

       
            //    for (int i = 0; i <= vals.Length; i++)
            //{
            //    //if (i == 0)
            //    //{
                

            //    elementCount += i;
            //    //}
            //}
            return elementCount % 2 == 0;

        }

        public bool IsNumberEven(int number)
        {
            //throw new NotImplementedException();


            return number % 2 == 0;

        }

        public bool IsNumberOdd(int num)
        {
            //throw new NotImplementedException();

            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            //throw new NotImplementedException();

            double min = 0;
            double max = 0;
            double sumMinMax = 0;

            foreach (double i in numbers)
            {
                if (i >= max)
                {
                    max = i;
                }
                if (i <= min)
                {
                    min = i;
                }

            }
            return sumMinMax = max + min;


            //for (int i = 0; i < numbers; i++)
            //{
            //    min[i] = numbers;
            //}
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //throw new NotImplementedException();

            int shortStr = 0;

            if (str1.Length < str2.Length)
            {
                return shortStr = str1.Length;
            }
            else
            {
                return shortStr = str2.Length;
            }


        }

        public int Sum(int[] numbers)
        {
            //throw new NotImplementedException();
            int total = 0;
            foreach (int val in numbers)
            {
                total += val;
            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            //throw new NotImplementedException();


            //option 1
            //for (int i = 2; i < 100; i++)
            //{
            //    result.Add(i);
            //}
            //return result;

            //option 2
            int result = 0;
            foreach (int i in numbers)
                if (i % 2 == 0)
                {
                    result += i;
                }
            return result;

            //option 3
            //int even = 0;
            //int odd = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        even += numbers[i];

            //    } else
            //    {
            //        odd += numbers[i];
            //    }

            //}
            //return even;

        }

        public bool IsSumOdd(List<int> numbers)
        {
            //throw new NotImplementedException();
            int result = 0;
           

            foreach (int i in numbers)
                if (i % 2 != 0)
                {
                    result += i;
                    
                }

            return result % 2 != 0;


        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            //throw new NotImplementedException();

            int divisibleBy = 2;
            long countEr = 0;

            //if (number % divisibleBy != 0)
            //{
            //    countEr++;
            //}
            //for (int i = 0; i < number; i++)
            //{
            //    if (number % divisibleBy != 0)
            //    {
            //        countEr++;
            //    }

            //}
            //return countEr;
            if (number < 0)
            {
                return 0;
            }

            return number / 2;


            //long dividend = 0;

            //return dividend % 2;
        }

        //    long oddResult = 0;

        //    if (number % 2 != 0)
        //    {
        //        oddResult += number;
        //    }

        //    return oddResult;
        //}
    }
}
