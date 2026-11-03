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
    }
}
