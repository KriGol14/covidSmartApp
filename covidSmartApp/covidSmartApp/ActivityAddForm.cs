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
    public partial class ActivityAddForm : Form
    {
        public ActivityAddForm()
        {
            InitializeComponent();
            lb_date.Text = DateTime.Today.ToString("dd / MM / yyyy");
        }

        private Point mouseLoc;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for(int ix = 0; ix < checkedListBox2.Items.Count; ++ix)
            {
                if (ix != e.Index)
                {
                    checkedListBox2.SetItemChecked(ix, false);
                }
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
            {
                if (ix != e.Index)
                {
                    checkedListBox1.SetItemChecked(ix, false);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivityAddForm.ActiveForm.Close();
            PlanForm planform2 = new PlanForm();
            planform2.Show();
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            ActivityAddForm.ActiveForm.Close();
            PlanForm planform2 = new PlanForm();
            planform2.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "90");
        }
    }
}
