using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace PokéAPI_3
{
    public partial class PokédexRandomiser : Form
    {
        private ContextMenuStrip EndContextMenuStrip;
        private bool DexNoShown = true;
        private bool DescShown = true;

        private int RoundCount = 0;
        private bool RoundDone = false;

        Random rnd = new Random();
        string[] Sprites;

        private string pick1;
        private string pick2;
        private string pick3;

        private bool p1p2 = true;
        private bool StayMove = true;

        private static int Counter;

        public PokédexRandomiser()
        {
            InitializeComponent();
            CenterToParent();
            Titlelbl.Text = BackgroundWork.Player1Name + ", Pick your Pokémon!";

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
            ToolStripMenuItem DexNoStripMenuItem = new ToolStripMenuItem("Add/Remove Pokédex No.", null, DexNoToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(DexNoStripMenuItem);
            ToolStripMenuItem DescStripMenuItem = new ToolStripMenuItem("Add/Remove Descriptions", null, DescToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(DescStripMenuItem);

            ms.Dock = DockStyle.Top;

            this.Controls.Add(ms);
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
        private void DexNoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DexNoShown)
            {
                DexNoShown = false;
                DexNo1lbl.Visible = false;
                DexNo2lbl.Visible = false;
                DexNo3lbl.Visible = false;
            }
            else
            {
                DexNoShown = true;
                DexNo1lbl.Visible = true;
                DexNo2lbl.Visible = true;
                DexNo3lbl.Visible = true;
            }
        }
        private void DescToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DescShown)
            {
                DescShown = false;
                Desc1lbx.Visible = false;
                Desc2lbx.Visible = false;
                Desc3lbx.Visible = false;
            }
            else
            {
                DescShown = true;
                Desc1lbx.Visible = true;
                Desc2lbx.Visible = true;
                Desc3lbx.Visible = true;
            }
        }

        private void ButtonChange(int tf)
        {
            if (tf == 0)
            {
                GoAgain();
                Randomisebtn.Visible = false;
                opt1btn.Visible = true;
                opt2btn.Visible = true;
                opt3btn.Visible = true;
            }
            else if (tf == 1)
            {
                Name1lbl.Visible = true;   
                Picture1pbx.Visible = true;
                opt1btn.Text = "Next Round";

                Name2lbl.Visible = true;
                Picture2pbx.Visible = true;
                opt2btn.Text = "Next Round";

                
                Name3lbl.Visible = true;
                Picture3pbx.Visible = true;
                opt3btn.Text = "Next Round";
            }
            else
            {
                Randomisebtn.Visible = true;

                Name1lbl.Visible = false; 
                Picture1pbx.Visible = false;
                opt1btn.Visible = false;
                opt1btn.Text = "Pick This Pokémon";
                DexNo1lbl.Text = "Dex Number: ???";
                Desc1lbx.Items.Clear();

                Name2lbl.Visible = false; 
                Picture2pbx.Visible = false;
                opt2btn.Visible = false;
                opt2btn.Text = "Pick This Pokémon";
                DexNo2lbl.Text = "Dex Number: ???";
                Desc2lbx.Items.Clear();

                Name3lbl.Visible = false;
                Picture3pbx.Visible = false;
                opt3btn.Visible = false;
                opt3btn.Text = "Pick This Pokémon";
                DexNo3lbl.Text = "Dex Number: ???";
                Desc3lbx.Items.Clear();

                RoundDone = BackgroundWork.MoveToEnd(RoundCount + 1);
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
                }
                else
                {
                Hide();
                new EndScreen().Show();
                }
            }
            
        }

        private void Randomisebtn_Click(object sender, EventArgs e)
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

        private void GoAgain()
        {
            string[] strings = ListCreator();
            for (int i = 0; i < strings.Count(); i++)
            {
                Desc1lbx.Items.Add(strings[i]);
            }

            DexNo1lbl.Text = "Dex Number: " + Convert.ToString(BackgroundWork.DexNo);

            pick1 = BackgroundWork.NameRandomiser(false);
            Name1lbl.Text = pick1;
            Name1lbl.Refresh();

            Sprites = BackgroundWork.ImageFinder(false);
            Picture1pbx.ImageLocation = Sprites[0];


            strings = ListCreator();
            for (int i = 0; i < strings.Count(); i++)
            {
                Desc2lbx.Items.Add(strings[i]);
            }
            DexNo2lbl.Text = "Dex Number: " + Convert.ToString(BackgroundWork.DexNo);

            pick2 = BackgroundWork.NameRandomiser(false);
            Name2lbl.Text = pick2;
            Name2lbl.Refresh();

            Sprites = BackgroundWork.ImageFinder(false);
            Picture2pbx.ImageLocation = Sprites[0];


            strings = ListCreator();
            for (int i = 0; i < strings.Count(); i++)
            {
                Desc3lbx.Items.Add(strings[i]);
            }
            DexNo3lbl.Text = "Dex Number: " + Convert.ToString(BackgroundWork.DexNo);

            pick3 = BackgroundWork.NameRandomiser(false);
            Name3lbl.Text = pick3;
            Name3lbl.Refresh();

            Sprites = BackgroundWork.ImageFinder(false);
            Picture3pbx.ImageLocation = Sprites[0];
        }

        private static string[] ListCreator()
        {
            Counter = 0;
            string[] SplitValue = new string[10];
            string ReplaceValue = BackgroundWork.DexRandomiser(true);

            ReplaceValue = ReplaceValue.Replace(@"\n", "~");
            ReplaceValue = ReplaceValue.Replace(@"\f", "");
            ReplaceValue = ReplaceValue.Replace("ã©", "é");
            ReplaceValue = ReplaceValue.Replace("â€™", "'");
            //REPLACE POKEMON'S NAME IN DESC
            ReplaceValue = ReplaceValue.Replace("\",\"language\":{\"name\":\"en\",\"url\":\"https://pokeapi.co/api/v2/language/9/", "");
            ReplaceValue = ReplaceValue.Replace(",{\"flavor_text\":\"", "");
            ReplaceValue = ReplaceValue.Replace("\"", "");
            ReplaceValue = ReplaceValue.Replace("â-", "-");

            string PkmnName = BackgroundWork.NameRandomiser(false);
            PkmnName = PkmnName.ToLower();
            ReplaceValue = ReplaceValue.Replace($"{PkmnName}", "this pokémon");

            SplitValue = ReplaceValue.Split('~');

            foreach (string s in SplitValue) { Counter++; }
            return SplitValue;
        }

        //FLAVOUR TEXT IS POKEDEX ENTRIES
        //GEN 5 "0" ENTRY IS IS FRENCH FOR SOME REASON???
    }
}
