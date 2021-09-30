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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            greece_chart.Visible = true; 
        }


        // using the worlwide_label and greece_label, the user can choose to view covid-19 information either for Greece or globally
        private void worldwide_label_Click(object sender, EventArgs e)
        {
            if (world_chart.Visible == true)
            {
                world_chart.Visible = false;
                greece_chart.Visible = true;
            }
        }

        private void greece_label_Click(object sender, EventArgs e)
        {
            if (greece_chart.Visible == true)
            {
                greece_chart.Visible = false;
                world_chart.Visible = true;
            }
        }

        private void thermometerButton_Click(object sender, EventArgs e)
        {
            // if the user presses the thermometerButton (ring-bell), he is redirected to a new form and the initial form closes
            Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            OnlineOrderForm onlineorderform = new OnlineOrderForm();
            onlineorderform.Show();
        }

        private void plannerButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            PlanForm planform1 = new PlanForm();
            planform1.Show();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            SmartHome smartHome = new SmartHome();
            smartHome.Show();
               
        }

        private void elderlyButton_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            elderlyHelp form = new elderlyHelp();
            form.Show();
        }

        // mouseHover event for the buttons, creating a scrollbar
        private void thermometerButton_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = thermometerButton.Height;
            scrollPanel.Top = thermometerButton.Top;
        }

        private void orderButton_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = orderButton.Height;
            scrollPanel.Top = orderButton.Top;
        }

        private void plannerButton_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = plannerButton.Height;
            scrollPanel.Top = plannerButton.Top;
        }

        private void controlButton_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = controlButton.Height;
            scrollPanel.Top = controlButton.Top;
        }

        private void elderlyButton_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = elderlyButton.Height;
            scrollPanel.Top = elderlyButton.Top;
        }


        // if the user presses the purple help button, the help manual of the application should appear
        private void questionsLogo_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(this, @"C:\Users\golem\Desktop\help_manuals\help_manual.chm", HelpNavigator.TopicId, "10");
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "10"); 
        }

        // if the user presses the exitLogo (blue exit button), the application closes
        private void exitLogo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
