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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button1_Click(object sender, EventArgs e)
        {
            string username = user_textBox1.Text;
            string password = pass_textBox2.Text;
            if (username == "user" && password == "user ")
            {
                Form3 choices = new Form3();
                choices.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect credentials. Please try again.");
                pass_textBox2.Clear();
                user_textBox1.Clear();
            }
        }
    }
}
