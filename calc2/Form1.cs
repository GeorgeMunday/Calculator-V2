using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc2
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }


        // methods for operations 
        private void ceBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text = "0";
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text = "";
        }

        private void takeBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "-";
        }

        private void xBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "*";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "/";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "+";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            string input = calcBox.Text;
            string result = new DataTable().Compute(input, null).ToString();
            calcBox.Text = result;
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text = (Convert.ToDouble(calcBox.Text) * -1).ToString();
        }

        // methods for numbers
        private void oneBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcBox.Text += "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "9";
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            calcBox.Text += "0";
        }
    }
}
