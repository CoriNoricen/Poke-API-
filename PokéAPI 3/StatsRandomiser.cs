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
    public partial class StatsRandomiser : Form
    {
        private ContextMenuStrip EndContextMenuStrip;
        private bool HPShown = true;
        private bool AtkShown = true;
        private bool DefShown = true;
        private bool SpAShown = true;
        private bool SpDShown = true;
        private bool SpeShown = true;

        public StatsRandomiser()
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
            ToolStripMenuItem HPStripMenuItem = new ToolStripMenuItem("Add/Remove HP", null, HPToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(HPStripMenuItem);
            ToolStripMenuItem AtkStripMenuItem = new ToolStripMenuItem("Add/Remove Atk", null, AtkToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(AtkStripMenuItem);
            ToolStripMenuItem DefStripMenuItem = new ToolStripMenuItem("Add/Remove Def", null, DefToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(DefStripMenuItem);
            ToolStripMenuItem SpAStripMenuItem = new ToolStripMenuItem("Add/Remove SpA", null, SpAToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(SpAStripMenuItem);
            ToolStripMenuItem SpDStripMenuItem = new ToolStripMenuItem("Add/Remove SpD", null, SpDToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(SpDStripMenuItem);
            ToolStripMenuItem SpeStripMenuItem = new ToolStripMenuItem("Add/Remove Spe", null, SpeToolStripMenuItem_Click, "");
            EditToolStripMenuItem.DropDownItems.Add(SpeStripMenuItem);

            ms.Dock = DockStyle.Top;

            this.Controls.Add(ms);

            if (Settings.NameShown)
            {
                pkmn1lbl.Visible = true;
                pkmn2lbl.Visible = true;
                pkmn3lbl.Visible = true;
            }
            if (Settings.ImageShown)
            {
                Sprite1pbx.Visible = true;
                Sprite2pbx.Visible = true;
                Sprite3pbx.Visible = true;
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
        private void HPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideHP();
        }
        private void AtkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideAtk();
        }
        private void DefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideDef();
        }
        private void SpAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideSpA();
        }
        private void SpDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideSpD();
        }
        private void SpeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideSpe();
        }

        private void HideHP()
        {
            if (HPShown)
            {
                HPShown = false;
                HP1txt.Visible = false;
                HP1lbl.Visible = false;
                HP2txt.Visible = false;
                HP2lbl.Visible = false;
                HP3txt.Visible = false;
                HP3lbl.Visible = false;
            }
            else
            {
                HPShown = true;
                HP1txt.Visible = true;
                HP1lbl.Visible = true;
                HP2txt.Visible = true;
                HP2lbl.Visible = true;
                HP3txt.Visible = true;
                HP3lbl.Visible = true;
            }
        }

        private void HideAtk()
        {
            if (AtkShown)
            {
                AtkShown = false;
                Atk1txt.Visible = false;
                Atk1lbl.Visible = false;
                Atk2txt.Visible = false;
                Atk2lbl.Visible = false;
                Atk3txt.Visible = false;
                Atk3lbl.Visible = false;
            }
            else
            {
                AtkShown = true;
                Atk1txt.Visible = true;
                Atk1lbl.Visible = true;
                Atk2txt.Visible = true;
                Atk2lbl.Visible = true;
                Atk3txt.Visible = true;
                Atk3lbl.Visible = true;
            }
        }

        private void HideDef()
        {
            if (DefShown)
            {
                DefShown = false;
                Def1txt.Visible = false;
                Def1lbl.Visible = false;
                Def2txt.Visible = false;
                Def2lbl.Visible = false;
                Def3txt.Visible = false;
                Def3lbl.Visible = false;
            }
            else
            {
                DefShown = true;
                Def1txt.Visible = true;
                Def1lbl.Visible = true;
                Def2txt.Visible = true;
                Def2lbl.Visible = true;
                Def3txt.Visible = true;
                Def3lbl.Visible = true;
            }
        }

        private void HideSpA()
        {
            if (SpAShown)
            {
                SpAShown = false;
                SpA1txt.Visible = false;
                SpA1lbl.Visible = false;
                SpA2txt.Visible = false;
                SpA2lbl.Visible = false;
                SpA3txt.Visible = false;
                SpA3lbl.Visible = false;
            }
            else
            {
                SpAShown = true;
                SpA1txt.Visible = true;
                SpA1lbl.Visible = true;
                SpA2txt.Visible = true;
                SpA2lbl.Visible = true;
                SpA3txt.Visible = true;
                SpA3lbl.Visible = true;
            }
        }

        private void HideSpD()
        {
            if (SpDShown)
            {
                SpDShown = false;
                SpD1txt.Visible = false;
                SpD1lbl.Visible = false;
                SpD2txt.Visible = false;
                SpD2lbl.Visible = false;
                SpD3txt.Visible = false;
                SpD3lbl.Visible = false;
            }
            else
            {
                SpDShown = true;
                SpD1txt.Visible = true;
                SpD1lbl.Visible = true;
                SpD2txt.Visible = true;
                SpD2lbl.Visible = true;
                SpD3txt.Visible = true;
                SpD3lbl.Visible = true;
            }
        }

        private void HideSpe()
        {
            if (SpeShown)
            {
                SpeShown = false;
                Spe1txt.Visible = false;
                Spe1lbl.Visible = false;
                Spe2txt.Visible = false;
                Spe2lbl.Visible = false;
                Spe3txt.Visible = false;
                Spe3lbl.Visible = false;
            }
            else
            {
                SpeShown = true;
                Spe1txt.Visible = true;
                Spe1lbl.Visible = true;
                Spe2txt.Visible = true;
                Spe2lbl.Visible = true;
                Spe3txt.Visible = true;
                Spe3lbl.Visible = true;
            }
        }
    }
}
