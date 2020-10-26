using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //throw new NotImplementedException();
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int evenResult = 0;
                int oddResult = 0;


                foreach (int i in numbers)

                    if (i % 2 == 0)
                    {
                        evenResult += i;
                    }
                    else
                    {
                        oddResult += i;
                    }

                //foreach (int i in numbers)
                //    if (i % 2 != 0)
                //    {
                //        oddResult -= i;
                //    }


                return evenResult - oddResult;
            }

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //throw new NotImplementedException();
            int shortString = 0;

            if (shortString > str1.Length)
            {
                shortString = str1.Length;
            }
            if (shortString > str2.Length)
            {
                shortString = str2.Length;
            }
            if (shortString > str3.Length)
            {
                shortString = str3.Length;
            }
            if (shortString > str4.Length)
            {
                shortString = str4.Length;
            }
            return shortString;

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //throw new NotImplementedException();

            int smallNum = number1;
            if (number2 < smallNum)
            {
                smallNum = number2;
            }
            if (number3 < smallNum)
            {
                smallNum = number3;
            }
            if (number4 < smallNum)
            {
                smallNum = number4;
            }
            
            return smallNum;

        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //throw new NotImplementedException();
            biz.Name = "TrueCoders";

            Console.WriteLine("TrueCoders");

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //throw new NotImplementedException();

            int side1 = sideLength1;
            int side2 = sideLength2;
            int side3 = sideLength3;

            if (((side1 + side2) > side3) && ((side2 + side3) > side1) && ((side3 + side1) > side2))
            {
               return true;

            }
            else return false;

        }

        public bool IsStringANumber(string input)
        {
            //throw new NotImplementedException();
            if (input == null || input.Length == 0)
            {
                return false;
            }
            else
            {

                return double.TryParse(input, out var value);
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //throw new NotImplementedException();

            double isNullVal = 0;
            double isNotNullVal = 0;
            int countNull = 0;

            foreach (var i in objs)
                if (i == null)
                {
                    isNullVal += 1;

                }
            else
                {
                    isNotNullVal += 1;
                }

            return (isNullVal > isNotNullVal);
        }

        public double AverageEvens(int[] numbers)
        {
            //throw new NotImplementedException();

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                double evenResult = 0;
                int countEven = 0;
                int oddResult = 0;


                foreach (int i in numbers)

                    if (i % 2 == 0)
                    {
                        evenResult += i;
                        countEven += 1;
                    }
                    else
                    {
                        oddResult += i;
                    }

                //foreach (int i in numbers)
                //    if (i % 2 != 0)
                //    {
                //        oddResult -= i;
                //    }


                return evenResult / countEven;
            }
        }

        public int Factorial(int number)
        {
            //throw new NotImplementedException();
            if (number == 0)
            {
                return 1;
            }
            else
            {

                int valFact = 1;
                while (number != 1)
                {
                    valFact = valFact * number;
                    number = number - 1;
                }

                return valFact;
            }
        }
    }
}
