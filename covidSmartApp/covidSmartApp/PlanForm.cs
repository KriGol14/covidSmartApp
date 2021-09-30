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
    public partial class PlanForm : Form
    {
        public PlanForm()
        {
            InitializeComponent();
            lb_date.Text = DateTime.Today.ToString("dd / MM / yyyy");
        }

        private void btn_activityadd_Click(object sender, EventArgs e)
        {
            ActivityAddForm activityaddform = new ActivityAddForm();
            activityaddform.Show();
            Visible = false;
        }

        private void btn_activityadd_Click_1(object sender, EventArgs e)
        {
            ActivityAddForm activityaddform = new ActivityAddForm();
            activityaddform.Show();
            Visible = false;
        }

        private Point mouseLoc;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void btn_seemap_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
            MapForm mapform = new MapForm();
            mapform.Show();          
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PlanForm.ActiveForm.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "80");
        }
    }
}
