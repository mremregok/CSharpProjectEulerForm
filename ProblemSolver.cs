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
            List<long> numbers = new List<long>();

            for(int i = fromNumber; i <= toNumber; i++)
            {
                if (_func.isPrime(i))
                {
                    numbers.Add(i);
                }
                else
                {
                    for(int j = 2; j<i; j++)
                    {
                        if(_func.isPrime(j) && i%j == 0)
                        {
                            int temp = 1;
                            while (i%j == 0)
                            {
                                temp *= j;
                                i /= j;
                            }
                            numbers.Add(temp);
                            System.Windows.Forms.MessageBox.Show(temp.ToString());
                        }
                    }
                }
            }

            long returnNum = 1;

            foreach(var i in numbers)
            {
                returnNum *= i;
                System.Windows.Forms.MessageBox.Show(i.ToString());
            }

            return returnNum;
        }
    }
}
