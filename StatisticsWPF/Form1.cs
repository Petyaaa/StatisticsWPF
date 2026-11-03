using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatisticsWPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblNumbers_Click(object sender, EventArgs e)
        {

        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

            var numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToList();
            var average = numbers.Average();
            lblOutput.Text = "Answer: " + average; 
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            var numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            double median;
            int count = numbers.Count;
            if (count % 2 == 0)
            {
                median = (numbers[count / 2 - 1] + numbers[count / 2]) / 2;
            }
            else
            {
                median = numbers[count / 2];
            }
            lblOutput.Text = "Answer: " + median;
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
          
            double median;
            var numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToList();

            var groups = numbers.GroupBy(n => n).ToList();
            int maxCount = groups.Max(g => groups.Count());
            List<double> modes = groups.Where(g => g.Count() == maxCount).Select(g => g.Key).ToList();


            var modeMultiple = numbers.GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .Where(g => g.Count() == numbers.GroupBy(n => n).Max(g2 => g2.Count()))
                .Select(g => g.Key)
                .ToList();

        }
    }
}
