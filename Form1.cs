﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpProjectEulerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IProblem prob = new ProblemSolver();

        DateTime StartDate;

        DateTime EndDate;

        public void FuncCaller(Func<long, long> func, long num)
        {
            StartDate = DateTime.Now;

            var answer = func(num);

            EndDate = DateTime.Now;

            txtSonuc.Text = answer.ToString();

            txtSure.Text = ((int)(EndDate-StartDate).TotalMilliseconds).ToString() + " miliseconds";
        }

        public void FuncCaller(Func<int, int> func, int num)
        {
            StartDate = DateTime.Now;

            var answer = func(num);

            EndDate = DateTime.Now;

            txtSonuc.Text = answer.ToString();

            txtSure.Text = ((int)(EndDate - StartDate).TotalMilliseconds).ToString() + " miliseconds";
        }

        public void FuncCaller(Func<int> func)
        {
            StartDate = DateTime.Now;

            var answer = func();

            EndDate = DateTime.Now;

            txtSonuc.Text = answer.ToString();

            txtSure.Text = ((int)(EndDate - StartDate).TotalMilliseconds).ToString() + " miliseconds";
        }

        public void FuncCaller(Func<int, int, long> func, int start, int end)
        {
            StartDate = DateTime.Now;

            var answer = func(start, end);

            EndDate = DateTime.Now;

            txtSonuc.Text = answer.ToString();

            txtSure.Text = ((int)(EndDate - StartDate).TotalMilliseconds).ToString() + " miliseconds";
        }

        private void btnProblem_1_Click(object sender, EventArgs e)
        {
            txtSoru.Text = "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23." 
                + Environment.NewLine
                + "Find the sum of all the multiples of 3 or 5 below 1000.";
            FuncCaller(prob.SumOfMultiples, 1000);
        }

        private void btnProblem_2_Click(object sender, EventArgs e)
        {
            txtSoru.Text = "Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:"
               + Environment.NewLine
               + "1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ..."
               + Environment.NewLine
               + "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms."; 
            FuncCaller(prob.SumOfEvenNumbersInFibonacci, 4000000);
        }

        private void btnProblem_3_Click(object sender, EventArgs e)
        {
            txtSoru.Text = "The prime factors of 13195 are 5, 7, 13 and 29."
                + Environment.NewLine
                + "What is the largest prime factor of the number 600851475143 ?";
            FuncCaller(prob.LargestPrimeFactor, 600851475143);
        }

        private void btnProblem_4_Click(object sender, EventArgs e)
        {
            txtSoru.Text = "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99."
                + Environment.NewLine
                + "Find the largest palindrome made from the product of two 3-digit numbers.";
            FuncCaller(prob.LargestPalindrome);
        }

        private void btnProblem_5_Click(object sender, EventArgs e)
        {
            txtSoru.Text = "2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder."
                + Environment.NewLine
                + "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
            FuncCaller(prob.SmallestEvenlyDivisibleNum, 1, 20);
        }
    }
}
