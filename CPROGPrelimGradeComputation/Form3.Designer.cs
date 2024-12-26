
namespace CPROGPrelimGradeComputation
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.prelimButton = new System.Windows.Forms.RadioButton();
            this.midtermButton = new System.Windows.Forms.RadioButton();
            this.finalButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prelimButton
            // 
            this.prelimButton.AutoSize = true;
            this.prelimButton.Font = new System.Drawing.Font("Raleway Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelimButton.Location = new System.Drawing.Point(64, 75);
            this.prelimButton.Name = "prelimButton";
            this.prelimButton.Size = new System.Drawing.Size(293, 26);
            this.prelimButton.TabIndex = 0;
            this.prelimButton.TabStop = true;
            this.prelimButton.Text = "Prelim Grade Computation";
            this.prelimButton.UseVisualStyleBackColor = true;
            // 
            // midtermButton
            // 
            this.midtermButton.AutoSize = true;
            this.midtermButton.Font = new System.Drawing.Font("Raleway Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midtermButton.Location = new System.Drawing.Point(64, 116);
            this.midtermButton.Name = "midtermButton";
            this.midtermButton.Size = new System.Drawing.Size(313, 26);
            this.midtermButton.TabIndex = 1;
            this.midtermButton.TabStop = true;
            this.midtermButton.Text = "Midterm Grade Computation";
            this.midtermButton.UseVisualStyleBackColor = true;
            // 
            // finalButton
            // 
            this.finalButton.AutoSize = true;
            this.finalButton.Font = new System.Drawing.Font("Raleway Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalButton.Location = new System.Drawing.Point(64, 160);
            this.finalButton.Name = "finalButton";
            this.finalButton.Size = new System.Drawing.Size(276, 26);
            this.finalButton.TabIndex = 2;
            this.finalButton.TabStop = true;
            this.finalButton.Text = "Final Grade Computation";
            this.finalButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.prelimButton);
            this.groupBox1.Controls.Add(this.finalButton);
            this.groupBox1.Controls.Add(this.midtermButton);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(76, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHOOSE ONE OPERATION";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(8, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 48);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(308, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 58);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton prelimButton;
        private System.Windows.Forms.RadioButton midtermButton;
        private System.Windows.Forms.RadioButton finalButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}