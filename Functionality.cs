﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProjectEulerForm
{
    public class Functionality : IFunction
    {
        public bool isEven(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }

        public bool isPalindrome(int firstNum, int secondNum)
        {
            int multiply = 0;
            string numString = "", firstHalf = "", secondHalf = "";

            multiply = firstNum * secondNum;

            numString = multiply.ToString();

            if (numString.Length % 2 == 0)
            {
                firstHalf = numString.Substring(0, numString.Length / 2);
                secondHalf = numString.Substring(numString.Length / 2);
                string temp = "";

                for (int i = secondHalf.Length - 1; i >= 0; i--)
                {
                    temp += secondHalf[i];
                }

                if (firstHalf == temp)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isPrime(int num)
        {
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        public bool isPrime(long num)
        {
            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}