using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAct2_Pellosis_BIT31
{
    public partial class Form1 : Form
    {
        private Timer quizTime;
        private int remTime = 60;
        private double ans;
        private string randOper;
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (remTime > 0)
            {
                remTime--;
                lblTimer.Text = "You have " + remTime.ToString() + " Seconds Left!";
            }
            else
            {
                quizTime.Stop();
                lblTimer.Text = "Times Up!";
            }
        }
        private void initialize()
        {
            generate();
            startTime();
        }

        private void startTime()
        {
            quizTime = new Timer();
            quizTime.Interval = 1000;
            quizTime.Tick += timer1_Tick;
            quizTime.Start();
        }

        private void generate()
        {
            Random rand = new Random();

            string[] operations = { "+", "-", "*", "/" };
            randOper = operations[rand.Next(operations.Length)];

            int num1 = rand.Next(1, 99);
            lbloper.Text = randOper.ToString();
            int num2 = rand.Next(1, 99);

            lblnum1.Text = num1.ToString();
            lblnum2.Text = num2.ToString();

            switch (randOper)
            {
                case "+":
                    ans = num1 + num2;
                    break;
                case "-":
                    ans = num1 - num2;
                    break;
                case "*":
                    ans = num1 * num2;
                    break;
                case "/":
                    ans = (double)num1 / num2;
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            generate();
            startTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double userInput;   

            if (double.TryParse(txtInput.Text, out userInput))
            {
                txtOutput.AppendText(lblnum1.Text.ToString() + " " + lbloper.Text.ToString() + " " + lblnum2.Text.ToString() + " Your answer is: " + txtInput.Text);
                if (Math.Abs(userInput - ans) < 0.01)
                {
                    txtOutput.AppendText("✔️\n");
                }
                else
                {
                    txtOutput.AppendText("❌\n");
                }
            }

            btnSubmit.Enabled = false; 
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            generate();
            remTime = 60;
        }
    }
}
