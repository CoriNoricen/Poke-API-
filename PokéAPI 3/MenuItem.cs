using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokéAPI_3
{
    public partial class MenuItem : Form
    {
        public MenuItem()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void RoundCounter(bool AddMinus)
        {
            if (BackgroundWork.RoundCount >= 1 && BackgroundWork.RoundCount <= 30)
            {
                if (AddMinus == true) 
                {
                    if (BackgroundWork.RoundCount != 30)
                    {
                        BackgroundWork.RoundCount++;
                    }
                }
                else
                {
                    if (BackgroundWork.RoundCount != 1)
                    {
                        BackgroundWork.RoundCount--;
                    }
                }
            }
        }

        private bool MoveOn()
        {
            if (p1txt.Text != "" && p2txt.Text != "")
            {
                return true;
            }
            else { return false; }
        }

        private void p1txt_TextChanged(object sender, EventArgs e)
        {
            BackgroundWork.Player1Name = p1txt.Text;
        }

        private void p2txt_TextChanged(object sender, EventArgs e)
        {
            BackgroundWork.Player2Name = p2txt.Text;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            RoundCounter(true);
            if (BackgroundWork.RoundCount < 10)
            {
                PkmnNumbtn.Text = "0" + Convert.ToString(BackgroundWork.RoundCount);
            }
            else
            {
                PkmnNumbtn.Text = Convert.ToString(BackgroundWork.RoundCount);
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            RoundCounter(false);
            if (BackgroundWork.RoundCount < 10)
            {
                PkmnNumbtn.Text = "0" + Convert.ToString(BackgroundWork.RoundCount);
            }
            else
            {
                PkmnNumbtn.Text = Convert.ToString(BackgroundWork.RoundCount);
            }
        }

        private void NameRandomiserbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(0).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void HWbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(1).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void Pokédexbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(2).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void Abilitiesbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(3).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void BSTbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(4).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void LimitedBSTbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(5).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void LowestStatbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(6).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }

        private void HighestStatbtn_Click(object sender, EventArgs e)
        {
            bool yn = MoveOn();
            if (yn == true)
            {
                Hide();
                new Settings(7).Show();
            }
            else
            {
                MessageBox.Show("Please enter a name.", "Name fields are empty.");
            }
        }
    }
}
