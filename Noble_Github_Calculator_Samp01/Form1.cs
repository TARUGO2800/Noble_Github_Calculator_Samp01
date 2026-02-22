using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Noble_Github_Calculator_Samp01
{
    public partial class Form1 : Form
    {
        CalculatorLogic calc = new CalculatorLogic();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.SelectedIndex = 0;

            lblAnswer.Text = "0";

            btnCalculate.Click += btnCalculate_Click;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum1.Text) ||
                string.IsNullOrWhiteSpace(txtNum2.Text))
            {
                MessageBox.Show("Please enter both numbers.");
                return;
            }

            if (!double.TryParse(txtNum1.Text, out double num1) ||
                !double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("Invalid number input.");
                return;
            }

            double result = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    result = calc.Add(num1, num2);
                    break;
                case "-":
                    result = calc.Subtract(num1, num2);
                    break;
            }

            lblAnswer.Text = result.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
