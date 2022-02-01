using System;
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

        public void FuncCaller(Func<int, int, int> func, int start, int end)
        {
            StartDate = DateTime.Now;

            var answer = func(start, end);

            EndDate = DateTime.Now;

            txtSonuc.Text = answer.ToString();

            txtSure.Text = ((int)(EndDate - StartDate).TotalMilliseconds).ToString() + " miliseconds";
        }

        private void btnProblem_1_Click(object sender, EventArgs e)
        {
            FuncCaller(prob.SumOfMultiples, 1000);
        }

        private void btnProblem_2_Click(object sender, EventArgs e)
        {
            FuncCaller(prob.SumOfEvenNumbersInFibonacci, 4000000);
        }

        private void btnProblem_3_Click(object sender, EventArgs e)
        {
            FuncCaller(prob.LargestPrimeFactor, 600851475143);
        }

        private void btnProblem_4_Click(object sender, EventArgs e)
        {
            FuncCaller(prob.LargestPalindrome);
        }

        private void btnProblem_5_Click(object sender, EventArgs e)
        {
            FuncCaller(prob.SmallestEvenlyDivisibleNum, 1, 20);
        }
    }
}
