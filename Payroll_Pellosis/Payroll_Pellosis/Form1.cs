using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Pellosis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int daysWorked = (int)nmrDays.Value;

            double ratePerDay = 0.00;
            double sss = 0.00;
            double medicare = 0.00;
            double rateTax = 0.00;

            switch (cmbStatus.SelectedIndex)
            {
                case 0:
                    ratePerDay = 850.00;
                    sss = 500.00;
                    medicare = 350.00;
                    rateTax = 0.25;
                    break;
                case 1:
                    ratePerDay = 550.00;
                    sss = 400.00;
                    medicare = 250.00;
                    rateTax = 0.15;
                    break;
                case 2:
                    ratePerDay = 350.00;
                    sss = 100.00;
                    medicare = 100.00;
                    rateTax = 0.10;
                    break;
            }

            double grossPay = daysWorked * ratePerDay;
            double tax = rateTax * grossPay;
            double deduction = sss + medicare + tax;
            double netPay = grossPay - deduction;

            string output = $"Salary Calculation\n\n" +
                            $"Employee Name: {txtEmpName.Text}\n" +
                            $"Gross Pay: {grossPay}\n" +
                            $"Deduction: {deduction}\n" +
                            $"Net Pay: {netPay}\n\n" +
                            $"Date and Time of Salary Computation\n" + lblDate.Text + " " + lblTime.Text;

            if (string.IsNullOrEmpty(txtEmpName.Text))
            {
                outputPayroll.Text = "Invalid Employee Name. Please input a valid employee name.";
            }
            else if (cmbStatus.SelectedIndex == -1)
            {
                outputPayroll.Text = "Invalid Employee Status. Please input a valid employee status.";
            }
            else if (daysWorked <= 0)
            {
                outputPayroll.Text = "Invalid number of days worked. Please input a valid number of days worked by a employee.";
            }
            else
            {
                outputPayroll.Text = output;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputPayroll.Text = " ";
            txtEmpName.Text = " ";
            cmbStatus.SelectedIndex = -1;
            nmrDays.Value = 0;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void outputPayroll_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
