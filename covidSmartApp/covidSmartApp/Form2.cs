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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // pictureBox1 represents the blue exit button, which by being pressed redirects the user to the initial form of the application
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // closing form2
            Visible = false;
            // creating an instance of Form1 and opening it using that
            Form1 form1 = new Form1();
            form1.Show();
        }

        // pressing the questions_logo button, the user can see information about the present form
        private void questionsLogo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "20");
        }

        // if the user hovers the mouse over pictureBox2 (the ring-bell button), a small text with information appears 
        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(pictureBox2, "Press to activate the temperature scanner");
        }

        // pressing the bell button, the temperature measurement procedure begins as the scanner is automatically activated
        // the user is redirected to a new form (Form3) with information about the procedure
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // closing the present form
            this.Close();
            // opening Form3 by creating an instance of it and using it
            Form3 form3 = new Form3();
            form3.Show();
        }

        // method that is used to change this form's background
        // this method is not actually called in this form, but by pressing a button in Form3 in case the temperature results where positive
        // and the user can get in the house
        public void updateBackground()
        {
            // full path of the picture
            Image openDoor = Image.FromFile(@"C:\Users\golem\source\repos\covidSmartApp\covidSmartApp\Resources\open_door.png");
            this.BackgroundImage = openDoor;
        }
    }
}
