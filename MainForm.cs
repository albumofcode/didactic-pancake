//Wrote this in 15min for my friends final project during freshman year. Devious, but she got an A!
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace didacticpancake
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            txtFirstNum.Text = "Enter a number";
            txtSecondNum.Text = "Enter a number";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtFirstNum.Text, out double dblFirstNum) || !double.TryParse(txtSecondNum.Text, out double dblSecondNum))
            {
                txtFirstNum.Text = "You must enter a number";
                txtSecondNum.Text = "You must enter a numer";
            }

            else
            {
                lblComputedNum.Text = Convert.ToString(ComputeAddition(dblFirstNum, dblSecondNum));
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(txtFirstNum.Text, out double dblFirstNum) || !double.TryParse(txtSecondNum.Text, out double dblSecondNum))
            {
                txtFirstNum.Text = "You must enter a number";
                txtSecondNum.Text = "You must enter a number";
            }

            else
            {
                lblComputedNum.Text = Convert.ToString(ComputeSubtraction(dblFirstNum, dblSecondNum));
            }
        }

        public double ComputeAddition(double dblNum1, double dblNum2)
        {
            double compute = dblNum1 + dblNum2;

            return compute;
        }

        public double ComputeSubtraction(double dblNum1, double dblNum2)
        {
            double compute = dblNum1 - dblNum2;

            return compute;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
