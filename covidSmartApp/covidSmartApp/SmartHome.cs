using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covidSmartApp
{
    public partial class SmartHome : Form
    {

        private int counter;

        public SmartHome() // Smart home is our form for smarthome
        {
            InitializeComponent();
            pictureBox5.Visible = true;
            pictureBox16.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

        }

        private void SmartHome_Load(object sender, EventArgs e)
        {
            counter = 25;
            labelCounter.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            counter += 1;
            labelCounter.Text = counter.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter -= 1;
            labelCounter.Text = counter.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            pictureBox6.Visible = false;
            pictureBox7.Enabled = true;
            pictureBox7.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox12.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            pictureBox11.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox13.Visible = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            pictureBox14.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SmartHome.ActiveForm.Hide();
            SmartHome_2_ smartHome_2 = new SmartHome_2_();
            smartHome_2.Show();

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            pictureBox5.Visible = true;
            pictureBox13.Visible = true;
            pictureBox11.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = true;
            pictureBox5.Visible = false;
            pictureBox13.Visible = false;
            pictureBox11.Visible = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox17.Visible = true;
            pictureBox18.Visible = false;
            pictureBox15.Visible = false;
            pictureBox14.Visible = true;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox18.Visible = true;
            pictureBox17.Visible = false;
            pictureBox15.Visible = true;
            pictureBox14.Visible = false;
        }

        private void exitLogo_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void questionsLogo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "195");
        }
    }
}
