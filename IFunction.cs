using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectEulerForm
{
    public interface IFunction
    {
        bool isPalindrome(int firstNum, int secondNum);

        bool isPrime(int num);

        bool isPrime(long num);

        bool isEven(int num);
    }
}
