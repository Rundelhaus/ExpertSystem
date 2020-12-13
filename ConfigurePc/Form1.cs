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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PersonalUseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalUse personalUse = new PersonalUse();
            personalUse.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void officeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LastQestion lastQestion = new LastQestion("office");
            lastQestion.Show();
        }
    }
}
