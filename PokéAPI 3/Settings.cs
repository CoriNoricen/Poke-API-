using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokéAPI_3
{
    public partial class Settings : Form
    {
        private int ScreenSelection;

        public static bool NameShown = false;
        public static bool ImageShown = false;
        public static bool Other1 = true;
        public static bool Other3 = true;

        public Settings(int i)
        {
            InitializeComponent();
            CenterToParent();

            ScreenSelection = i;

            switch (ScreenSelection)
            {
                case 0:
                    Other1lbl.Text = "Names Shown:";
                    Other2lbl.Text = "Images Shown:";

                    Namelbl.Visible = false; Imagelbl.Visible = false;
                    NameYescbx.Visible = false; NameNocbx.Visible = false;
                    ImageYescbx.Visible = false; ImageNocbx.Visible = false;
                    break;
                case 1:
                    Other1lbl.Text = "Height Shown:";
                    Other2lbl.Text = "Weight Shown:";
                    break;
                case 2:
                    Other1lbl.Text = "Dex Shown:";
                    Other2lbl.Text = "Description Shown:";
                    break;
            }
        }

        private void Beginbtn_Click(object sender, EventArgs e)
        {
            switch (ScreenSelection)
            {
                case 0:
                    Hide();
                    new NameRandomiser().Show(); break;
                case 1:
                    Hide();
                    new HWRandomiser().Show(); break;
                case 2:
                    Hide();
                    new PokédexRandomiser().Show(); break;
                case 3:
                    Hide();
                    /*new AbilityRandomiser().Show();*/ break;
                case 4:
                    Hide();
                    new StatsRandomiser().Show(); break;
                    //ADD OTHER FORMS HERE
            }
        }

        private void Other1Yescbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Other1Yescbx.Checked && Other1Nocbx.Checked)
            {
                Other1 = true;
                Other1Nocbx.Checked = false;
            }
            else if (!Other1Yescbx.Checked && !Other1Nocbx.Checked)
            {
                Other1 = true;
                Other1Yescbx.Checked = true;
                Other1Nocbx.Checked = false;
            }
        }

        private void Other1Nocbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Other1Yescbx.Checked && Other1Nocbx.Checked)
            {
                Other1 = false;
                Other1Yescbx.Checked = false;
            }
            else if (!Other1Yescbx.Checked && !Other1Nocbx.Checked)
            {
                Other1 = false;
                Other1Nocbx.Checked = true;
                Other1Yescbx.Checked = false;
            }
        }

        private void Other3Yescbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Other3Yescbx.Checked && Other3Nocbx.Checked)
            {
                Other3 = true;
                Other3Nocbx.Checked = false;
            }
            else if (!Other3Yescbx.Checked && !Other3Nocbx.Checked)
            {
                Other3 = true;
                Other3Yescbx.Checked = true;
                Other3Nocbx.Checked = false;
            }
        }

        private void Other3Nocbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Other3Yescbx.Checked && Other3Nocbx.Checked)
            {
                Other3 = false;
                Other3Yescbx.Checked = false;
            }
            else if (!Other3Yescbx.Checked && !Other3Nocbx.Checked)
            {
                Other3 = false;
                Other3Nocbx.Checked = true;
                Other3Yescbx.Checked = false;
            }
        }

        private void NameYescbx_CheckedChanged(object sender, EventArgs e)
        {
            if (NameYescbx.Checked && NameNocbx.Checked)
            {
                NameShown = true;
                NameNocbx.Checked = false;
            }
            else if (!NameYescbx.Checked && !NameNocbx.Checked)
            {
                NameShown = true;
                NameYescbx.Checked = true;
                NameNocbx.Checked = false;
            }
        }

        private void NameNocbx_CheckedChanged(object sender, EventArgs e)
        {
            if (NameYescbx.Checked && NameNocbx.Checked)
            {
                NameShown = false;
                NameYescbx.Checked = false;
            }
            else if (!NameYescbx.Checked && !NameNocbx.Checked)
            {
                NameShown = false;
                NameNocbx.Checked = true;
                NameYescbx.Checked = false;
            }
        }

        private void ImageYescbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageYescbx.Checked && ImageNocbx.Checked)
            {
                ImageShown = true;
                ImageNocbx.Checked = false;
            }
            else if (!ImageYescbx.Checked && !ImageNocbx.Checked)
            {
                ImageShown = true;
                ImageYescbx.Checked = true;
                ImageNocbx.Checked = false;
            }
        }

        private void ImageNocbx_CheckedChanged(object sender, EventArgs e)
        {
            if (ImageYescbx.Checked && ImageNocbx.Checked)
            {
                ImageShown = false;
                ImageYescbx.Checked = false;
            }
            else if (!ImageYescbx.Checked && !ImageNocbx.Checked)
            {
                ImageShown = false;
                ImageNocbx.Checked = true;
                ImageYescbx.Checked = false;
            }
        }
    }
}
