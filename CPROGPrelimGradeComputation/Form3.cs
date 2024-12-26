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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string choices = "";
            if (prelimButton.Checked)
            {
                choices = prelimButton.Text;
                Form2 prelimG = new Form2();
                prelimG.Show();
                this.Hide();
            }
            if (midtermButton.Checked)
            {
                choices = midtermButton.Text;
                Form4 midG = new Form4();
                midG.Show();
                this.Hide();
            }

            /*if (finalButton.Checked)
             * {
                choices = finalButton.Text;
            Form5 finG = new Form5();
            finG.Show();
            this.Hide();}*/
        
        }
    }
}
