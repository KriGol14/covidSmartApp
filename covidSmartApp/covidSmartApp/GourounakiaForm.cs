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
    public partial class GourounakiaForm : Form
    {
        public GourounakiaForm()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.BringToFront();
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.BringToFront();
            panel4.Visible = true;
            panel3.Visible = false;
            panel5.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
            panel5.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                listBox1.Items.Add("Πίττες με Γύρο Χοιρινό: " + numericUpDown1.Value.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (numericUpDown2.Value > 0)
            { 
                listBox1.Items.Add("Πίττες με Γύρο Κοτόπουλο: " + numericUpDown2.Value.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(numericUpDown3.Value > 0)
            {
                listBox1.Items.Add("Πίττες με Σουβλάκι Χοιρινό: " + numericUpDown3.Value.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(numericUpDown4.Value> 0)
            {
                listBox1.Items.Add("Πίττες με Κεμπάπ: " + numericUpDown4.Value.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (numericUpDown5.Value > 0)
            {
                listBox1.Items.Add("Γεμιστά: " + numericUpDown5.Value.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (numericUpDown6.Value > 0)
            {
                listBox1.Items.Add("Παστίτσιο: " + numericUpDown6.Value.ToString());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (numericUpDown7.Value > 0)
            {
                listBox1.Items.Add("Μακαρόνια με Κιμά: " + numericUpDown7.Value.ToString());
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (numericUpDown8.Value > 0)
            {
                listBox1.Items.Add("Κοτόπουλο με πατάτες στο φούρνο: " + numericUpDown8.Value.ToString());
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (numericUpDown12.Value > 0)
            {
                listBox1.Items.Add("Καλαμάκι Χοιρινό: " + numericUpDown12.Value.ToString());
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (numericUpDown11.Value > 0)
            {
                listBox1.Items.Add("Κεμπάπ: " + numericUpDown11.Value.ToString());
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (numericUpDown10.Value > 0)
            {
                listBox1.Items.Add("Καλαμάκι Κοτόπουλο: " + numericUpDown10.Value.ToString());
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (numericUpDown9.Value > 0)
            {
                listBox1.Items.Add("Κοτομπείκον: " + numericUpDown9.Value.ToString());
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0)
            {  
                GourounakiaForm.ActiveForm.Close();
                MessageBox.Show("Η παραγγελία σας στάλθηκε με επιτυχία!");
                OnlineOrderForm onlineorderform = new OnlineOrderForm();
                onlineorderform.Show();    
            }
            else
            {
                MessageBox.Show("Πρέπει να επιλέξετε κάποιο προϊόν.");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = button1.Height;
            scrollPanel.Top = button1.Top;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = button2.Height;
            scrollPanel.Top = button2.Top;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = button3.Height;
            scrollPanel.Top = button3.Top;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = button4.Height;
            scrollPanel.Top = button4.Top;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = button5.Height;
            scrollPanel.Top = button5.Top;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            scrollPanel.Height = button6.Height;
            scrollPanel.Top = button6.Top;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Visible = false;
            OnlineOrderForm order = new OnlineOrderForm();
            order.Show();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "160");
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "160");
        }
    }
}
