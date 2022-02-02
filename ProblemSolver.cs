using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectEulerForm
{
    public class ProblemSolver : IProblem
    {
        private readonly IFunction _func = new Functionality();

        public int SumOfMultiples(int limit)
        {
            int sum = 0;

            for (int i = 3; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }

        public int SumOfEvenNumbersInFibonacci(int limit)
        {
            int first = 0, second = 1, sum = 0;

            while (sum < limit)
            {
                int tempSum = first + second;

                if (_func.isEven(tempSum))
                    sum += tempSum;

                first = second;

                second = tempSum;
            }

            return sum;
        }

        public long LargestPrimeFactor(long number)
        {
            long currentNum = number;
            long factor = 0;
            if (currentNum % 2 == 0)
                currentNum = currentNum / 2;
            for (long i = 3; i <= currentNum; i += 2)
            {
                if (currentNum % i > 0)
                    continue;
                else
                    currentNum = currentNum / i;

                if (_func.isPrime(i))
                {
                    factor = i;
                }
            }


            return factor;
        }

        public int LargestPalindrome()
        {
            int firstNum = 999, secondNum = 999, palindrome = 0;

            while(firstNum > 99)
            {
                secondNum = 999;
                while(secondNum > 99)
                {
                    if (_func.isPalindrome(firstNum, secondNum))
                        if(firstNum*secondNum > palindrome)
                            palindrome = firstNum * secondNum;
                    secondNum--;
                }
                firstNum--;
            }
            return palindrome;
        }

        public long SmallestEvenlyDivisibleNum(int fromNumber, int toNumber)
        {
            long returnNum = 1;


            for(int i = fromNumber; i <= toNumber; i++)
            {
                if (_func.isPrime(i))
                {
                    returnNum *= i;
                }
                else
                {
                    if(returnNum%i != 0)
                    {
                        var factorList = _func.FindFactors(i);

                        foreach(var factor in factorList)
                        {
                            returnNum *= factor;
                            if (returnNum % i == 0)
                                break;
                        }
                    }
                }
            }

            return returnNum;
        }

        public long SumSquareDifference(long number)
        {
            long sumOfSquares = 0;

            long squareOfSum = 0;

            for (int i = 1; i <= number; i++)
            {
                sumOfSquares += i * i;

                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            return squareOfSum - sumOfSquares;
        }

        public long FindPrimeNumber(int number)
        {
            if (number < 2)
                return 2;

            int count = 0, iter = 3;

            long prime = 0;

            while(count < number)
            {
                if (_func.isPrime(iter))
                {
                    prime = iter;
                    count++;
                }
                iter+=2;
            }

            return prime;
        }

        public long LargestProductInASeries(string serie, int number)
        {
            long maxNum = 0;
            string maxStr = "";

            for(int i = 0; i <= serie.Length-number; i++)
            {
                string str = serie.Substring(i, number);

                if(_func.ProductOfAdjacentNumber(str) > maxNum)
                {
                    maxNum = _func.ProductOfAdjacentNumber(str);
                    maxStr = str;
                }
            }

            long product = 1;

            foreach(var i in maxStr)
                product *= (i-48);

            return product;
        }

        public long SpecialPythagoreanTriplet(int number)
        {
            int a = 0, b = 0, c = 0;

            bool found = false;

            for(a = 0; a < number/3; a++)
            {
                for(b = 0; b < number/2; b++)
                {
                    c = number - a - b;

                    if(a*a+b*b == c * c)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                    break;
            }
            if (!found)
                return 0;
            return a * b * c;
        }

        public long SumOfPrimeNumbersToLimit(long limit)
        {
            if (limit == 2)
                return 2;

            int sum = 2;

            for (int i = 3; i < limit; i += 2)
            {
                if (_func.isPrime(i))
                    sum += i;
            }

            return sum;
        }
    }
}
