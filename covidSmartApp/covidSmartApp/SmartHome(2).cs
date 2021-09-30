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
    public partial class SmartHome_2_ : Form
    {
        public SmartHome_2_()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox6.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox6.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox13.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox13.Visible = false;
            pictureBox11.Visible = true;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox7.Visible = true;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox14.Visible = false;
            pictureBox15.Visible = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox15.Visible = false;
            pictureBox14.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SmartHome_2_.ActiveForm.Hide();
            SmartHome smartHome = new SmartHome();
            smartHome.Show();
        }

        private void exitLogo_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void questionsLogo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "190");
        }
    }
}
