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
    public partial class OnlineOrderForm : Form
    {
        public OnlineOrderForm()
        {
            InitializeComponent();
        }

        private Point mouseLoc;
        private void panel1_MouseDown1(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;
        }

        private void panel1_MouseMove1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - mouseLoc.X;
                int dy = e.Location.Y - mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            GourounakiaForm gourounakiaform = new GourounakiaForm();
            gourounakiaform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            ToKafeThsGeitoniasForm toKafeThsGeitoniasForm = new ToKafeThsGeitoniasForm();
            toKafeThsGeitoniasForm.Show();
        }

        private void lb_profile_Click(object sender, EventArgs e)
        {
            Visible = false;
            profileForm profileform1 = new profileForm();
            profileform1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Visible = false;
            profileForm profileform1 = new profileForm();
            profileform1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Visible = false;
            PlhrwmForm plhrwmhform = new PlhrwmForm();
            plhrwmhform.Show();
            
        }

        private void lb_payment_Click(object sender, EventArgs e)
        {
            Visible = false;
            PlhrwmForm plhrwmhform = new PlhrwmForm();
            plhrwmhform.Show();
        }

        private void lb_agaphmena_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void account_button_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = account_button.Height;
            scrollPanel.Top = account_button.Top;
        }

        private void payment_button_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = payment_button.Height;
            scrollPanel.Top = payment_button.Top;
        }

        private void favourites_button_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = favourites_button.Height;
            scrollPanel.Top = favourites_button.Top;
        }

        private void history_button_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = history_button.Height;
            scrollPanel.Top = history_button.Top;
        }

        private void contacts_button_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = contacts_button.Height;
            scrollPanel.Top = contacts_button.Top;
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            OnlineOrderForm.ActiveForm.Hide();
            profileForm profileForm = new profileForm();
            profileForm.Show();
        }

        private void payment_button_Click(object sender, EventArgs e)
        {
            OnlineOrderForm.ActiveForm.Hide();
            PlhrwmForm plhrwmhForm = new PlhrwmForm();
            plhrwmhForm.Show();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            OnlineOrderForm.ActiveForm.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "110");
        }
    }
}
