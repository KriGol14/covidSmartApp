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
    public partial class elderlyHelp : Form
    {
        private int counter = 10;
        public elderlyHelp()
        {
            InitializeComponent();
        }

        private void exitLogo_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string title = "ΑΣΤΥΝΟΜΙΑ";
            string message = "ΚΑΛΟΥΜΕ ΤΗΝ ΑΣΤΥΝΟΜΙΑ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pills_form pills = new pills_form();
            pills.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string title = "ΙΑΤΡΙΚΗ ΠΕΡΙΘΑΛΨΗ";
            string message = "ΚΑΛΟΥΜΕ ΤΟΝ ΠΡΟΣΩΠΙΚΟ ΣΑΣ ΙΑΤΡΟ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string title = "ΕΠΕΙΓΟΝ";
            string message = "ΚΑΛΟΥΜΕ ΤΑ ΜΕΛΗ ΤΗΣ ΟΙΚΟΓΕΝΕΙΑΣ ΣΑΣ ΚΑΙ ΤΗΝ ΑΣΤΥΝΟΜΙΑ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ ΝΑ ΦΤΑΣΟΥΝ ΜΕΙΝΕΤΕ ΨΥΧΡΑΙΜΟΙ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string title = "ΑΣΘΕΝΟΦΟΡΟ";
            string message = "ΚΑΛΟΥΜΕ ΑΣΘΕΝΟΦΟΡΟ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ ΦΤΑΝΕΙ ΟΣΟ ΤΟ ΔΥΝΑΤΟΝ ΣΥΝΤΟΜΟΤΕΡΑ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string title = "ΤΗΛΕΦΩΝΗΜΑ ΣΕ ΜΕΛΟΣ ΟΙΚΟΓΕΝΕΙΑΣ";
            string message = "ΚΑΛΟΥΜΕ ΤΟΝ ΓΙΟ ΣΑΣ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ ΝΑ ΑΠΑΝΤΗΣΕΙ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string title = "ΤΗΛΕΦΩΝΗΜΑ ΣΕ ΜΕΛΟΣ ΟΙΚΟΓΕΝΕΙΑΣ";
            string message = "ΚΑΛΟΥΜΕ ΤΗ ΓΥΝΑΙΚΑ ΣΑΣ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ ΝΑ ΑΠΑΝΤΗΣΕΙ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string title = "ΤΗΛΕΦΩΝΗΜΑ ΣΕ ΜΕΛΟΣ ΟΙΚΟΓΕΝΕΙΑΣ";
            string message = "ΚΑΛΟΥΜΕ ΤΟΝ ΑΔΕΛΦΟ ΣΑΣ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ ΝΑ ΑΠΑΝΤΗΣΕΙ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string title = "ΤΗΛΕΦΩΝΗΜΑ ΣΕ ΜΕΛΟΣ ΟΙΚΟΓΕΝΕΙΑΣ";
            string message = "ΚΑΛΟΥΜΕ ΤΗΝ ΚΟΡΗ ΣΑΣ, ΠΑΡΑΚΑΛΩ ΠΕΡΙΜΕΝΕΤΕ ΝΑ ΑΠΑΝΤΗΣΕΙ!";
            MessageBox.Show(message, title);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(pictureBox8, "ΓΙΟΣ");
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(pictureBox7, "ΓΥΝΑΙΚΑ");
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(pictureBox4, "ΑΔΕΛΦΟΣ");
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip1 = new ToolTip();
            tip1.SetToolTip(pictureBox5, "ΚΟΡΗ");
        }

        private void questionsLogo_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\golem\source\repos\covidSmartApp\help_manuals\help_manual.chm", HelpNavigator.TopicId, "200");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            int counter = 10;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label7.Text = counter.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("ΔΙΑΠΙΣΤΩΘΗΚΕ ΚΑΤΑΣΤΑΣΗ ΚΙΝΔΥΝΟΥ ΚΑΘΩΣ ΔΕΝ ΑΝΤΑΠΟΚΡΙΝΕΣΤΕ, ΚΑΛΟΥΜΕ ΤΟΥΣ ΚΡΑΤΙΚΟΥΣ ΦΟΡΕΙΣ ΚΑΙ ΤΑ ΜΕΛΗ ΤΗΣ ΟΙΚΟΓΕΝΕΙΑΣ ΣΑΣ!", "EMERGENCY");
            }
            label7.Text = counter.ToString();
        }
    }
}
