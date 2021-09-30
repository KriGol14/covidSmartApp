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
    public partial class Form3 : Form
    {
        Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }

        ToolTip tip1 = new ToolTip();

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label4.Visible = false;
            goInButton.Visible = false;
            helpButton.Visible = false;
            laterButton.Visible = false;
            carefulButton.Visible = false;
        }


        // timer1 is used for the orange loading bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            // in each timer tick the panel moves 2 pixels
            panel2.Left += 1;

            // creating a random temperature number between 35 and 40 °C
            Random rnd = new Random();
            double temperature = (rnd.NextDouble() * (40 - 35) + 35);
            temperature = (double)System.Math.Round(temperature, 1);

            // conditions about the possible temperature numbers
            if (temperature <= 36.6)
            {
                label4.ForeColor = System.Drawing.Color.Green;
            }
            else if (temperature > 36.6 && temperature <= 37.2)
            {
                label4.ForeColor = System.Drawing.Color.Yellow;
            }
            else if (temperature > 37.2 && temperature <= 38)
            {
                label4.ForeColor = System.Drawing.Color.Orange;
            }
            else if (temperature > 38)
            {
                label4.ForeColor = System.Drawing.Color.Red;
            }
               
            
            // when the loading bar is completed it returns in the initial position and the timer is disabled
            if (panel2.Left > 250)
            {
                panel2.Left = 0;
                timer1.Enabled = false;
                label4.Visible = true;

                label4.Text = "Your temperature is " + temperature + "°C.";

                // conditions about the temperature result
                if (temperature <= 36.6)
                {
                    goInButton.Visible = true;
                }
                else if (temperature > 36.6 && temperature <= 37.2)
                {
                    laterButton.Visible = true;
                }
                else if (temperature > 37.2 && temperature <= 38)
                {
                    carefulButton.Visible = true;
                }
                else if (temperature > 38)
                {
                    helpButton.Visible = true;
                }
            }            
        }


        // button actions for every possible temperature result
        private void goInButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            form2.updateBackground();
            form2.ShowDialog();
        }

        private void goInButton_MouseHover(object sender, EventArgs e)
        {
            tip1.SetToolTip(goInButton, "Your temperature is normal, press to enter the house!");
        }

        private void laterButton_Click(object sender, EventArgs e)
        {
            this.Close();
            form2.ShowDialog();
        }

        private void laterButton_MouseHover(object sender, EventArgs e)
        {
            tip1.SetToolTip(laterButton, "Your temperature is a little above normal, please try again later!");
        }

        private void carefulButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.Start("https://www.who.int/emergencies/diseases/novel-coronavirus-2019/advice-for-public");
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void carefulButton_MouseHover(object sender, EventArgs e)
        {
            tip1.SetToolTip(carefulButton, "Your temperature is a a bit high, please take care, for now you are not allowed to enter the house!");
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Diagnostics.Process.Start("https://coronavirus.health.ny.gov/find-test-site-near-you");
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void helpButton_MouseHover(object sender, EventArgs e)
        {
            tip1.SetToolTip(helpButton, "Your temperature is too high, it is recommended you do a covid-19 test, you are not allowed to enter!");
        }

        private void questionsLogo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "50");
        }
    }
}
