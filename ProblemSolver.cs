using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectEulerForm
{
    public class ProblemSolver
    {
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

                first = second;

                second = tempSum;

                if (tempSum % 2 == 0)
                    sum += tempSum;
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

                bool check = true;

                for (long j = 3; j < i; j += 2)
                {
                    if (i % j == 0)
                        check = false;
                }

                if (check)
                {
                    factor = i;
                }
            }


            return factor;
        }
    }
}
