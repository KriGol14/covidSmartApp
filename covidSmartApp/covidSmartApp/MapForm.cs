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
    public partial class MapForm : Form
    {
        public MapForm()
        {
            InitializeComponent();
            lb_date.Text = DateTime.Today.ToString("dd / MM / yyyy");
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

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MapForm.ActiveForm.Close();
            PlanForm planform2 = new PlanForm();
            planform2.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "95");
        }
    }
}
