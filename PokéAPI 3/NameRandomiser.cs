using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokéAPI_3
{
    public partial class NameRandomiser : Form
    {
        private ContextMenuStrip EndContextMenuStrip;
        private bool NameShown = true;
        private bool ImageShown = true;

        private int RoundCount = 0;
        private bool RoundDone = false;

        Random rnd = new Random();
        string[] Sprites;

        private string pick1;
        private string pick2;
        private string pick3;

        private bool p1p2 = true;

        public NameRandomiser()
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
            ToolStripMenuItem NameStripMenuItem = new ToolStripMenuItem("Add/Remove Name", null, NameToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(NameStripMenuItem);
            ToolStripMenuItem ImageStripMenuItem = new ToolStripMenuItem("Add/Remove Images", null, ImageToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(ImageStripMenuItem);

            ms.Dock = DockStyle.Top;

            this.Controls.Add(ms);

            if (!Settings.Other1)
            {
                HideName();
            }
            if (!Settings.Other3)
            {
                HideImage();
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
        private void NameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideName();
        }
        private void ImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideImage();
        }

        private void HideName()
        {
            if (NameShown)
            {
                NameShown = false;
                pkmn1lbl.Visible = false;
                pkmn2lbl.Visible = false;
                pkmn3lbl.Visible = false;
            }
            else
            {
                NameShown = true;
                pkmn1lbl.Visible = true;
                pkmn2lbl.Visible = true;
                pkmn3lbl.Visible = true;
            }
        }

        private void HideImage()
        {
            if (ImageShown)
            {
                ImageShown = false;
                BackSprite1pbx.Visible = false;
                BackSprite2pbx.Visible = false;
                BackSprite3pbx.Visible = false;
                FrontSprite1pbx.Visible = false;
                FrontSprite2pbx.Visible = false;
                FrontSprite3pbx.Visible = false;
            }
            else
            {
                ImageShown = true;
                BackSprite1pbx.Visible = true;
                BackSprite2pbx.Visible = true;
                BackSprite3pbx.Visible = true;
                FrontSprite1pbx.Visible = true;
                FrontSprite2pbx.Visible = true;
                FrontSprite3pbx.Visible = true;
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

                pkmn1lbl.Text = BackgroundWork.NameRandomiser(true);
                pkmn1lbl.Refresh();

                pick1 = BackgroundWork.NameRandomiser(false);

                Sprites = BackgroundWork.ImageFinder(false);
                FrontSprite1pbx.ImageLocation = Sprites[0];
                BackSprite1pbx.ImageLocation = Sprites[1];

                pkmn2lbl.Text = BackgroundWork.NameRandomiser(true);
                pkmn2lbl.Refresh();

                pick2 = BackgroundWork.NameRandomiser(false);

                Sprites = BackgroundWork.ImageFinder(false);
                FrontSprite2pbx.ImageLocation = Sprites[0];
                BackSprite2pbx.ImageLocation = Sprites[1];

                pkmn3lbl.Text = BackgroundWork.NameRandomiser(true);
                pkmn3lbl.Refresh();

                pick3 = BackgroundWork.NameRandomiser(false);

                Sprites = BackgroundWork.ImageFinder(false);
                FrontSprite3pbx.ImageLocation = Sprites[0];
                BackSprite3pbx.ImageLocation = Sprites[1];
            }
            else
            {
                Hide();
                new EndScreen().Show();
            }
        } 

        private void pkmnbtn_Click(object sender, EventArgs e)
        {
            pkmnbtn.Visible = false;
            opt1btn.Visible = true;
            opt2btn.Visible = true;
            opt3btn.Visible = true;
            GoAgain();
        }

        private void opt1btn_Click(object sender, EventArgs e)
        {
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
            GoAgain();
        }

        private void opt2btn_Click(object sender, EventArgs e)
        {
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
            GoAgain();
        }

        private void opt3btn_Click(object sender, EventArgs e)
        {
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
            GoAgain();
        }
    }
}
