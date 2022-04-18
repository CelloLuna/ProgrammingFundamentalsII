using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultLbl.Text = "";
            msgLbl.Text = "";
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //validate whether both weight and height balues are entered by the user 
                if (weightInput.Text == "" || heightInput.Text == "")
                {
                    msgLbl.Text = "Please enter the weight and Height \n to calculate your BMI";
                } else
                {
                    //parse input into double
                    double weight = double.Parse(weightInput.Text);
                    double height = double.Parse(heightInput.Text);
                    double bmi = (weight * 703) / (height * height);

                    //display the result in the result label
                    resultLbl.Text = "Your BMI: " + String.Format("{0:f}", bmi);

                    if (bmi < 18.5)
                    {
                        msgLbl.Text = "You are under-weight. \n";
                        msgLbl.Text += "Take more nutritious food to get your ideal weight. \n";
                    } else if (bmi >= 18.5 && bmi <= 24.9){
                        msgLbl.Text = "Good! Your weight is normal. \n";
                    } else if (bmi >= 25 && bmi <= 29.9)
                    {
                        msgLbl.Text = "You are over-weight. \n";
                        msgLbl.Text += "Focus on diet and workout. \n";
                    } else if (bmi >= 30)
                    {
                        msgLbl.Text = "You are obese. \n";
                        msgLbl.Text += "Consult with a doctor immediately. \n";
                    } else
                    {
                        msgLbl.Text = "Please probide valid data to claculate.";
                    }

                    msgLbl.Text += "Stay Healthy! Happy Living!";
                }
                
            } catch (Exception ex)
            {
                msgLbl.Text = ex.ToString();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            weightInput.Text = "";
            heightInput.Text = "";
            resultLbl.Text = "";
            msgLbl.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
