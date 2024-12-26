
namespace CPROGPrelimGradeComputation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_textBox1 = new System.Windows.Forms.TextBox();
            this.pass_textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button1
            // 
            this.login_button1.BackColor = System.Drawing.Color.Transparent;
            this.login_button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button1.BackgroundImage")));
            this.login_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_button1.FlatAppearance.BorderSize = 0;
            this.login_button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_button1.Location = new System.Drawing.Point(255, 274);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(111, 45);
            this.login_button1.TabIndex = 1;
            this.login_button1.UseVisualStyleBackColor = false;
            this.login_button1.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(100, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(104, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // user_textBox1
            // 
            this.user_textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.user_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_textBox1.Location = new System.Drawing.Point(104, 138);
            this.user_textBox1.Name = "user_textBox1";
            this.user_textBox1.Size = new System.Drawing.Size(171, 27);
            this.user_textBox1.TabIndex = 4;
            // 
            // pass_textBox2
            // 
            this.pass_textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.pass_textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_textBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pass_textBox2.Location = new System.Drawing.Point(104, 214);
            this.pass_textBox2.Name = "pass_textBox2";
            this.pass_textBox2.PasswordChar = '*';
            this.pass_textBox2.Size = new System.Drawing.Size(171, 27);
            this.pass_textBox2.TabIndex = 5;
            this.pass_textBox2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkBlue;
            this.label4.Font = new System.Drawing.Font("MV Boli", 8.4F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(226, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Created by: Jamelah Ayen Tipon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkBlue;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Bold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "WELCOME KLASMEYT!";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.user_textBox1);
            this.groupBox1.Controls.Add(this.login_button1);
            this.groupBox1.Controls.Add(this.pass_textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(140, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 350);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(145, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(1, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 96);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 664);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in Page";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login_button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_textBox1;
        private System.Windows.Forms.TextBox pass_textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

