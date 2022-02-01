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

        private void btnProblem_1_Click(object sender, EventArgs e)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();

            ProblemSolver prob = new ProblemSolver();

            stopWatch.Start();

            var answer = prob.SumOfMultiples(1000);

            stopWatch.Stop();

            txtSonuc.Text = answer.ToString();

            txtSure.Text = stopWatch.ElapsedMilliseconds.ToString() + " milisaniye";
        }

        private void btnProblem_2_Click(object sender, EventArgs e)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();

            ProblemSolver prob = new ProblemSolver();

            stopWatch.Start();

            var answer = prob.SumOfEvenNumbersInFibonacci(4000000);

            stopWatch.Stop();

            txtSonuc.Text = answer.ToString();

            txtSure.Text = stopWatch.ElapsedMilliseconds.ToString() + " milisaniye";
        }

        private void btnProblem_3_Click(object sender, EventArgs e)
        {
            var stopWatch = new System.Diagnostics.Stopwatch();

            ProblemSolver prob = new ProblemSolver();

            stopWatch.Start();

            var answer = prob.LargestPrimeFactor(600851475143);

            stopWatch.Stop();

            txtSonuc.Text = answer.ToString();

            txtSure.Text = stopWatch.ElapsedMilliseconds.ToString() + " milisaniye";

            
        }
    }
}
