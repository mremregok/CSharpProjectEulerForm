using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectEulerForm
{
    public interface IProblem
    {
        int SumOfMultiples(int limit);

        int SumOfEvenNumbersInFibonacci(int limit);

        long LargestPrimeFactor(long number);

        int LargestPalindrome();

        long SmallestEvenlyDivisibleNum(int fromNumber, int toNumber);
    }
}
