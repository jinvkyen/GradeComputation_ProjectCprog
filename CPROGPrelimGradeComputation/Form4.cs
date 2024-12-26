using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPROGPrelimGradeComputation
{
    public partial class Form4 : Form
    {
        double q1, q2, averageq, averagelab, lab1, lab2, lab3, lab4;
        double assign1, assign2, assAVE, midExS, midEx, midG;

        private void clear_button_Click(object sender, EventArgs e)
        {
            textBox1_q1.Clear();
            textBox2_q2.Clear();
            textBox_lb1.Clear();
            textBox_ass1.Clear();
            textBox_ass2.Clear();
            labelAssign.Text = "";
            textBox_lb2.Clear();
            textBox_lb3.Clear();
            textBox_lb4.Clear();
            textBox_mE.Clear();
            labelQuiz.Text = "";
            ActivityLabel.Text = "";
            label_MidE.Text = "";
            labelMidGrade.Text = "";
        }

        private void all_answerbutton4_Click(object sender, EventArgs e)
        {
            midG = (averageq * 0.25) + (averagelab * 0.25) + (assAVE * 0.20) + (midEx * 0.30);
            Math.Round(midG);
            labelMidGrade.Text = "Your Midterm Grade: " + Math.Round(midG) + '%';

            if (midG >= 70)
            {
                Form5 passed = new Form5();
                passed.Show();
            }
            else
            {
                Form6 failed = new Form6();
                failed.Show();
            }
        }

        private void button_PrelimEx_Click(object sender, EventArgs e)
        {
            midExS = Convert.ToDouble(textBox_mE.Text);
            try
            {
                midEx = midExS / 40 * 100;
                label_MidE.Text = "Exam Average: " + midEx + '%';
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void Lab_actbutton_Click(object sender, EventArgs e)
        {
            lab1 = Convert.ToDouble(textBox_lb1.Text);
            lab2 = Convert.ToDouble(textBox_lb2.Text);
            lab3 = Convert.ToDouble(textBox_lb3.Text);
            lab4 = Convert.ToDouble(textBox_lb4.Text);
            try
            {
                averagelab = (lab1 + lab2 + lab3 + lab4) / 4;
                ActivityLabel.Text = "Average Lab Acts: " + averagelab + '%';
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void button_assign_Click(object sender, EventArgs e)
        {
            assign1 = Convert.ToDouble(textBox_ass1.Text);
            assign2 = Convert.ToDouble(textBox_ass2.Text);

            try
            {
                assAVE = (assign1 + assign2) / 2;
                labelAssign.Text = "Assignment: " + assAVE + '%';
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Form3 choices = new Form3();
            choices.Show();
            this.Hide();
        }
    
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Class_standbutton_Click(object sender, EventArgs e)
        {
            q1 = Convert.ToDouble(textBox1_q1.Text);
            q2 = Convert.ToDouble(textBox2_q2.Text);
            try
            {
                averageq = (q1 + q2) / 80 * 100;
                labelQuiz.Text = "Quiz standing: " + averageq + '%';
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input");
            }

        }
    }
}
