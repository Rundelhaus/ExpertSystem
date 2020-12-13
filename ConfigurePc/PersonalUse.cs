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
    public partial class PersonalUse : Form
    {
        public PersonalUse()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 personalUse = new Form1();
            personalUse.Show();
        }

        private void PersonalUse_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CasualButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LastQestion lastQestion = new LastQestion("normal");
            lastQestion.Show();
        }

        private void GamingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LastQestion lastQestion = new LastQestion("gaming");
            lastQestion.Show();
        }
    }
}
