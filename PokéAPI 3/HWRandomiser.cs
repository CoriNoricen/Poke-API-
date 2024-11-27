using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PokéAPI_3
{
    public partial class HWRandomiser : Form
    {
        private ContextMenuStrip EndContextMenuStrip;
        private bool HeightShown = true;
        private bool WeightShown = true;

        private int RoundCount = 0;
        private bool RoundDone = false;

        Random rnd = new Random();
        string[] Sprites;

        private string pick1;
        private string pick2;
        private string pick3;

        private bool p1p2 = true;
        private bool StayMove = true;

        private string[] HW = new string[2];

        public HWRandomiser()
        {
            InitializeComponent();
            CenterToParent();
            Titlelbl.Text = BackgroundWork.Player1Name + ", Pick your Pokémon!";

            //CHANGE CONTEXTSTRIP TO SETTINGS SCREEN BEFOREHAND???
            EndContextMenuStrip = new ContextMenuStrip();

            MenuStrip ms = new MenuStrip();

            ToolStripMenuItem HelpToolStripMenuItem = new ToolStripMenuItem("Finish", null, null, "");
            ms.Items.Add(HelpToolStripMenuItem);
            ToolStripMenuItem EndStripMenuItem = new ToolStripMenuItem("End Randomiser", null, EndToolStripMenuItem_Click, "");
            HelpToolStripMenuItem.DropDownItems.Add(EndStripMenuItem);
            ToolStripMenuItem QuitStripMenuItem = new ToolStripMenuItem("Quit Program", null, QuitToolStripMenuItem_Click, "");
            HelpToolStripMenuItem.DropDownItems.Add(QuitStripMenuItem);

            ToolStripMenuItem EditToolStripMenuItem = new ToolStripMenuItem("Edit", null, null, "");
            ms.Items.Add(EditToolStripMenuItem);
            ToolStripMenuItem HeightStripMenuItem = new ToolStripMenuItem("Add/Remove Height", null, HeightToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(HeightStripMenuItem);
            ToolStripMenuItem WeightStripMenuItem = new ToolStripMenuItem("Add/Remove Weight", null, WeightToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(WeightStripMenuItem);

            ms.Dock = DockStyle.Top;

            this.Controls.Add(ms);

            if (!Settings.Other1)
            {
                HideHeight();
            }
            if (!Settings.Other3)
            {
                HideWeight();
            }
            if (Settings.NameShown)
            {
                pkmn1lbl.Visible = true;
                pkmn2lbl.Visible = true;
                pkmn3lbl.Visible = true;
            }
            if (Settings.ImageShown)
            {
                FrontSprite1pbx.Visible = true;
                FrontSprite2pbx.Visible = true;
                FrontSprite3pbx.Visible = true;
            }
        }
        private void EndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new EndScreen().Show();
        }
        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideHeight();
        }
        private void WeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideWeight();
        }

        private void HideHeight()
        {
            if (HeightShown)
            {
                HeightShown = false;
                Height1lbl.Visible = false;
                Height2lbl.Visible = false;
                Height3lbl.Visible = false;
            }
            else
            {
                HeightShown = true;
                Height1lbl.Visible = true;
                Height2lbl.Visible = true;
                Height3lbl.Visible = true;
            }
        }

        private void HideWeight()
        {
            if (WeightShown)
            {
                WeightShown = false;
                Weight1lbl.Visible = false;
                Weight2lbl.Visible = false;
                Weight3lbl.Visible = false;
            }
            else
            {
                WeightShown = true;
                Weight1lbl.Visible = true;
                Weight2lbl.Visible = true;
                Weight3lbl.Visible = true;
            }
        }

        private void GoAgain()
        {
            RoundDone = BackgroundWork.MoveToEnd(RoundCount);
            if (!RoundDone)
            {
                RoundCount++;
                if (p1p2)
                {
                    Titlelbl.Text = BackgroundWork.Player1Name + ", Pick your Pokémon!";
                }
                else
                {
                    Titlelbl.Text = BackgroundWork.Player2Name + ", Pick your Pokémon!";
                }

                HW = BackgroundWork.HeightWeightRandomiser(true);
                Height1lbl.Text = "Height: " + HW[0];
                Weight1lbl.Text = "Weight: " + HW[1];

                pkmn1lbl.Text = BackgroundWork.NameRandomiser(false);
                pkmn1lbl.Refresh();

                pick1 = BackgroundWork.NameRandomiser(false);

                Sprites = BackgroundWork.ImageFinder(false);
                FrontSprite1pbx.ImageLocation = Sprites[0];

                HW = BackgroundWork.HeightWeightRandomiser(true);
                Height2lbl.Text = "Height: " + HW[0];
                Weight2lbl.Text = "Weight: " + HW[1];

                pkmn2lbl.Text = BackgroundWork.NameRandomiser(false);
                pkmn2lbl.Refresh();

                pick2 = BackgroundWork.NameRandomiser(false);

                Sprites = BackgroundWork.ImageFinder(false);
                FrontSprite2pbx.ImageLocation = Sprites[0];

                HW = BackgroundWork.HeightWeightRandomiser(true);
                Height3lbl.Text = "Height: " + HW[0];
                Weight3lbl.Text = "Weight: " + HW[1];

                pkmn3lbl.Text = BackgroundWork.NameRandomiser(false);
                pkmn3lbl.Refresh();

                pick3 = BackgroundWork.NameRandomiser(false);

                Sprites = BackgroundWork.ImageFinder(false);
                FrontSprite3pbx.ImageLocation = Sprites[0];
            }
            else
            {
                Hide();
                new EndScreen().Show();
            }
        }

        private void ButtonChange(int tf)
        {
            if (tf == 0)
            {
                GoAgain();
                pkmnbtn.Visible = false;
                opt1btn.Visible = true;
                opt2btn.Visible = true;
                opt3btn.Visible = true;
            }
            else if (tf == 1)
            {
                pkmn1lbl.Visible = true;
                FrontSprite1pbx.Visible = true;
                opt1btn.Text = "Next Round";

                pkmn2lbl.Visible = true;
                FrontSprite2pbx.Visible = true;
                opt2btn.Text = "Next Round";


                pkmn3lbl.Visible = true;
                FrontSprite3pbx.Visible = true;
                opt3btn.Text = "Next Round";
            }
            else
            {
                pkmnbtn.Visible = true;

                opt1btn.Visible = false;
                opt1btn.Text = "Pick This Pokémon";
                Height1lbl.Text = "Height: ???";
                Weight1lbl.Text = "Weight: ???";
                
                opt2btn.Visible = false;
                opt2btn.Text = "Pick This Pokémon";
                Height2lbl.Text = "Height: ???";
                Weight2lbl.Text = "Weight: ???";
              
                opt3btn.Visible = false;
                opt3btn.Text = "Pick This Pokémon";
                Height3lbl.Text = "Height: ???";
                Weight3lbl.Text = "Weight: ???";

                if (!Settings.NameShown)
                {
                    pkmn1lbl.Visible = false;
                    pkmn2lbl.Visible = false;
                    pkmn3lbl.Visible = false;
                }
                if (!Settings.ImageShown)
                {
                    FrontSprite1pbx.Visible = false;
                    FrontSprite2pbx.Visible = false;
                    FrontSprite3pbx.Visible = false;
                }
            }

        }

        private void pkmnbtn_Click(object sender, EventArgs e)
        {
            ButtonChange(0);
        }

        private void opt1btn_Click(object sender, EventArgs e)
        {
            if (StayMove)
            {
                StayMove = false;
                if (p1p2 == true)
                {
                    BackgroundWork.P1Options.Add(pick1);
                    p1p2 = false;
                }
                else
                {
                    BackgroundWork.P2Options.Add(pick1);
                    p1p2 = true;
                }
                ButtonChange(1);
            }
            else
            {
                StayMove = true;
                ButtonChange(2);
            }
        }

        private void opt2btn_Click(object sender, EventArgs e)
        {
            if (StayMove)
            {
                StayMove = false;
                if (p1p2 == true)
                {
                    BackgroundWork.P1Options.Add(pick2);
                    p1p2 = false;
                }
                else
                {
                    BackgroundWork.P2Options.Add(pick2);
                    p1p2 = true;
                }
                ButtonChange(1);
            }
            else
            {
                StayMove = true;
                ButtonChange(2);
            }
        }

        private void opt3btn_Click(object sender, EventArgs e)
        {
            if (StayMove)
            {
                StayMove = false;
                if (p1p2 == true)
                {
                    BackgroundWork.P1Options.Add(pick3);
                    p1p2 = false;
                }
                else
                {
                    BackgroundWork.P2Options.Add(pick3);
                    p1p2 = true;
                }
                ButtonChange(1);
            }
            else
            {
                StayMove = true;
                ButtonChange(2);
            }
        }
        //Height x10 for cm when output, weight /10 for kg
    }
}

