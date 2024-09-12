using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT31_Pellosis_EA1_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1 = 0, ans = 0;
        int count = 0;
        bool resultsDisplay = false;
        bool newOperation = true;

        Button myButtonInput;
        void CreateUserInput(object sender)
        {
            if (resultsDisplay)
            {
                txtOutput.Clear();
                resultsDisplay = false;
            }
            myButtonInput = (Button)sender;
            txtOutput.Text += myButtonInput.Text;
            newOperation = false;
        }

        private void btnInputNumber_Click(object sender, EventArgs e)
        {
            CreateUserInput(sender);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            resultsDisplay = false;
            newOperation = true;
            num1 = 0;
            count = 0;
        }

        void compute()
        {
            float num2;

            if (float.TryParse(txtOutput.Text, out num2))
            {
                switch (count)
                {
                    case 1:
                        ans = num1 + num2;
                        break;
                    case 2:
                        ans = num1 - num2;
                        break;
                    case 3:
                        ans = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            txtOutput.Text = "Error Calculation";
                            resultsDisplay = true;
                            return;
                        }
                        ans = num1 / num2;
                        break;
                    default:
                        txtOutput.Text = "Error! No operations selected!";
                        break;
                }
                txtOutput.Text = ans.ToString();
                resultsDisplay = true;
                count = 0;
            }
            else
            {
                txtOutput.Text = "Invalid Inputs";
                resultsDisplay = true;
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text) && !resultsDisplay)
            {
                if (!newOperation)
                {
                    compute();
                    newOperation = true;
                } 
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!resultsDisplay)
            {
                if (txtOutput.Text.Length > 0)
                {
                    txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1);
                }

                if(txtOutput.Text.Length == 0)
                {
                    newOperation = true;
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!resultsDisplay)
            {
                if (string.IsNullOrEmpty(txtOutput.Text) || txtOutput.Text == "-")
                {
                    txtOutput.Text = "-";
                    newOperation = false;
                }
                else
                {
                    if(float.TryParse(txtOutput.Text, out num1))
                    {
                        txtOutput.Clear();
                        count = 2;
                        newOperation = false;
                    }
                    else
                    {
                        txtOutput.Text = "Invalid Inputs";
                    }
                }
            }
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            if (!resultsDisplay)
            {
                num1 = float.Parse(txtOutput.Text);
                txtOutput.Clear();
                count = 3;
                newOperation = false;
            }
            else
            {
                txtOutput.Text = "Invalid Inputs";
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!resultsDisplay)
            {
                num1 = float.Parse(txtOutput.Text);
                txtOutput.Clear();
                count = 4;
                newOperation = false;
            }
            else
            {
                txtOutput.Text = "Invalid Inputs";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (!resultsDisplay)
            {
                num1 = float.Parse(txtOutput.Text);
                txtOutput.Clear();
                count = 1;
                newOperation = false;
            }
            else
            {
                txtOutput.Text = "Invalid Inputs";
            }
        }
    }
}
