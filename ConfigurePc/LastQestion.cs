using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurePc
{
    public partial class LastQestion : Form
    {
        private string state = null;
        public LastQestion(string state)
        {
            InitializeComponent();
            this.state = state;
        }

        private void LastQestion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backLQButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.state == "gaming" || this.state == "normal")
            {
                PersonalUse personalUse = new PersonalUse();
                personalUse.Show();
            }
            else {
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void ConfigureButton_Click(object sender, EventArgs e)
        {

        }

        private void MadeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (this.state == "gaming")
            {
                MadeForm madeForm = new MadeForm("gaming");
                madeForm.Show();
            }
            else if (this.state == "normal")
            {
                MadeForm madeForm = new MadeForm("normal");
                madeForm.Show();
            }
            else
            {
                MadeForm madeForm = new MadeForm("office");
                madeForm.Show();
            }
        }
    }
}
