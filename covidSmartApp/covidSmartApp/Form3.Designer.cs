
namespace covidSmartApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.goInButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.laterButton = new System.Windows.Forms.Button();
            this.carefulButton = new System.Windows.Forms.Button();
            this.questionsLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(151, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 20);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 20);
            this.panel2.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label1.Location = new System.Drawing.Point(120, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "You activated the scanner!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label2.Location = new System.Drawing.Point(88, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please stand in front of the scanner and wait";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.label3.Location = new System.Drawing.Point(71, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(485, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "for the results of your temperature measurement.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(87, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 40);
            this.label4.TabIndex = 5;
            // 
            // goInButton
            // 
            this.goInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.goInButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.goInButton.Location = new System.Drawing.Point(276, 352);
            this.goInButton.Name = "goInButton";
            this.goInButton.Size = new System.Drawing.Size(99, 37);
            this.goInButton.TabIndex = 6;
            this.goInButton.Text = "GO IN!";
            this.goInButton.UseVisualStyleBackColor = true;
            this.goInButton.Click += new System.EventHandler(this.goInButton_Click);
            this.goInButton.MouseHover += new System.EventHandler(this.goInButton_MouseHover);
            // 
            // helpButton
            // 
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.helpButton.ForeColor = System.Drawing.Color.Red;
            this.helpButton.Location = new System.Drawing.Point(276, 352);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(99, 37);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "HELP!";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            this.helpButton.MouseHover += new System.EventHandler(this.helpButton_MouseHover);
            // 
            // laterButton
            // 
            this.laterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.laterButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.laterButton.ForeColor = System.Drawing.Color.Yellow;
            this.laterButton.Location = new System.Drawing.Point(251, 352);
            this.laterButton.Name = "laterButton";
            this.laterButton.Size = new System.Drawing.Size(147, 37);
            this.laterButton.TabIndex = 8;
            this.laterButton.Text = "TRY LATER!";
            this.laterButton.UseVisualStyleBackColor = true;
            this.laterButton.Click += new System.EventHandler(this.laterButton_Click);
            this.laterButton.MouseHover += new System.EventHandler(this.laterButton_MouseHover);
            // 
            // carefulButton
            // 
            this.carefulButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carefulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carefulButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.carefulButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.carefulButton.Location = new System.Drawing.Point(251, 352);
            this.carefulButton.Name = "carefulButton";
            this.carefulButton.Size = new System.Drawing.Size(147, 37);
            this.carefulButton.TabIndex = 9;
            this.carefulButton.Text = "BE CAREFUL!";
            this.carefulButton.UseVisualStyleBackColor = true;
            this.carefulButton.Click += new System.EventHandler(this.carefulButton_Click);
            this.carefulButton.MouseHover += new System.EventHandler(this.carefulButton_MouseHover);
            // 
            // questionsLogo
            // 
            this.questionsLogo.BackColor = System.Drawing.Color.Transparent;
            this.questionsLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.questionsLogo.Image = ((System.Drawing.Image)(resources.GetObject("questionsLogo.Image")));
            this.questionsLogo.Location = new System.Drawing.Point(0, 0);
            this.questionsLogo.Name = "questionsLogo";
            this.questionsLogo.Size = new System.Drawing.Size(32, 28);
            this.questionsLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionsLogo.TabIndex = 11;
            this.questionsLogo.TabStop = false;
            this.questionsLogo.Click += new System.EventHandler(this.questionsLogo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(655, 433);
            this.Controls.Add(this.questionsLogo);
            this.Controls.Add(this.carefulButton);
            this.Controls.Add(this.laterButton);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.goInButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.questionsLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button goInButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button laterButton;
        private System.Windows.Forms.Button carefulButton;
        private System.Windows.Forms.PictureBox questionsLogo;
    }
}