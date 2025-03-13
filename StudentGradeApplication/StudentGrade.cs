using System;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram: Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public double calculateGrades(params double[] number)
        {
            double res = 0;
            foreach(double numbers in number)
            {
                res += numbers;
            }
            return res / number.Length;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double getEnglish = Convert.ToDouble(txtEnglish.Text);
            double getMath = Convert.ToDouble(txtMath.Text);
            double getScience = Convert.ToDouble(txtScience.Text);
            double getFilipino = Convert.ToDouble(txtFilipino.Text);
            double getHistory = Convert.ToDouble(txtHistory.Text);
            double res = calculateGrades(getEnglish, getMath, getScience, getFilipino, getHistory);
            string check = null;
            if (res <= 75)
            {
                check = "failed";
            } else {
                check = "passed";
            }
            txtOutput.Text = "The student " + check + ". \n" + "The general average of " + txtName.Text + " is " + res + ".";
        }
    }
}
