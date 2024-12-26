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
    public partial class Form2 : Form
    {
        double q1, q2, learnings, averageq, averagelab, lab1, lab2;
        double lab3, lab4, prelimE, prelimavE, prelimG;

        private void clear_button1_Click(object sender, EventArgs e)
        {
            textBox1_q1.Clear();
            textBox2_q2.Clear();
            textBox3_learn.Clear();
            textBox_lb1.Clear();
            textBox_lb2.Clear();
            textBox_lb3.Clear();
            textBox_lb4.Clear();
            textBox_pE.Clear();
            CLASS_STANDlabel12.Text = "";
            LABACTlabel13.Text = "";
            labelPrelimGrade.Text = "";
        }

        private void back_button4_Click(object sender, EventArgs e)
        {
            Form3 choices = new Form3();
            choices.Show();
            this.Hide();
        }
        
        private void all_answerbutton3_Click(object sender, EventArgs e)
        {
            try
                {
                prelimE = Convert.ToDouble(textBox_pE.Text);
                prelimavE = (prelimE / 60) * 100;
                exam_avelabel.Text = "Average Prelim Exam " + prelimavE + "%";
                prelimG = (averageq * 0.30) + (averagelab * 0.30) + (prelimavE * 0.40);
                labelPrelimGrade.Text = "Final Prelim Grade: " + prelimG;
                }
            catch (Exception)
            {
                MessageBox.Show("Invalid!");
            }
        }

        private void Lab_actbutton2_Click(object sender, EventArgs e)
        {
           
                lab1 = Convert.ToDouble(textBox_lb1.Text);
                lab2 = Convert.ToDouble(textBox_lb2.Text);
                lab3 = Convert.ToDouble(textBox_lb3.Text);
                lab4 = Convert.ToDouble(textBox_lb4.Text);
            try
            {
                averagelab = (lab1 + lab2 + lab3 + lab4) / 4;
                LABACTlabel13.Text = "Average Lab Acts: " + averagelab + "%";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid!");
            }

        }

        private void Class_standbutton1_Click(object sender, EventArgs e)
        {
            try
            { 
                q1 = Convert.ToDouble(textBox1_q1.Text);
                q2 = Convert.ToDouble(textBox2_q2.Text);
                learnings = Convert.ToDouble(textBox3_learn.Text);
            
                averageq = (q1 + q2 + learnings) / 90 * 100;
                CLASS_STANDlabel12.Text = "Average Class Standing: " + averageq + "%";
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid!");
            }

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
