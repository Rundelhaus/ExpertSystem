using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigurePc.storage;

namespace ConfigurePc
{   /// <summary>
    /// 
    /// </summary>
   

    /// <summary>
    /// 
    /// </summary>
    public partial class MadeForm : Form
    {
        private string state = null;
        private string sourse = "sphere";

        private string[] normalP = new string[]
        {
        "Anaconda",
        "Photoshop",
        "DaVinci",
        "MS Office"
        };

        private string[] normal = new string[] 
        {
            "рядовой пользователь",
            "видеоредакор",
            "программист",
            "датасайнтист",
            "фоторедактор/художник"
        };

        private string[] gaming = new string[] {
        "DEATH STRANDING",
        "Red Dead Redemption 2"
        };



        public MadeForm(string state)
        {

            InitializeComponent();
            this.state = state;
            this.setListbox(state);
            if (this.state == "gaming")
            {
                this.changeButton.Hide();
                this.label2.Text = "Программы";
            }
            else
            {
                this.label2.Text = "Цели использования";
            }
            //for (int i = 0; i < ComputerCaseStorage.computerCase.Length; i++)
            //{
             //  textBox1.Text += ComputerCaseStorage.computerCase[i].getStats() + "\r\n";
            //}

        }

        private void setListbox(string state)
        {
            if (state == "normal" || state == "office")
            {
                if (this.sourse == "sphere")
                {
                    this.listBox1.Items.AddRange(this.normal);
                }
                else
                {
                    this.listBox1.Items.AddRange(this.normalP);
                }
            }
            else
            {
                this.listBox1.Items.AddRange(this.gaming);
            }
        }

        private void MadeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MadeForm_Load(object sender, EventArgs e)
        {

        }

        private void MakeButton_Click(object sender, EventArgs e)
        {
            Assembly ass = new Assembly();
            ass.makeAssembly(listBox1.SelectedItems[0].ToString());
            string[] fin = new string[] { ass.poleProc.ToString(), ass.poleMoth.ToString(), ass.poleRAM.ToString(), ass.poleGCard.ToString(), ass.poleMem.ToString(), ass.polePower.ToString(), ass.price.ToString()};
            for(int i = 0; i< fin.Length; i++)
            {
                this.textBox1.Text += fin[i] + "\r\n";
            }
            //this.textBox1.Text += listBox1.SelectedItems[i].ToString() + "\r\n";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LastQestion lastQestion = new LastQestion(this.state);
            lastQestion.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            if (this.sourse == "sphere")
            {
                this.sourse = "program";
                this.setListbox(this.state);
            }
            else
            {
                this.sourse = "sphere";
                this.setListbox(this.state);
            }
        }
    }
}

