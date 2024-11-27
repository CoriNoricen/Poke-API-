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
    public partial class EndScreen : Form
    {
        public EndScreen()
        {
            InitializeComponent();
            CenterToParent();
            if (BackgroundWork.Player1Name[BackgroundWork.Player1Name.Length - 1] != 's')
            {
                pkmnDisplaydgv.Columns[0].HeaderText = BackgroundWork.Player1Name + "'s Team";
            }
            else
            {
                pkmnDisplaydgv.Columns[0].HeaderText = BackgroundWork.Player1Name + "' Team";
            }

            if (BackgroundWork.Player2Name[BackgroundWork.Player2Name.Length - 1] != 's')
            {
                pkmnDisplaydgv.Columns[1].HeaderText = BackgroundWork.Player2Name + "'s Team";
            }
            else
            {
                pkmnDisplaydgv.Columns[1].HeaderText = BackgroundWork.Player2Name + "' Team";
            }

            try
            {
                for (int i = 0; i < BackgroundWork.RoundCount; i++)
                {
                    pkmnDisplaydgv.Rows.Add(BackgroundWork.P1Options[i], BackgroundWork.P2Options[i]);
                }
            }
            catch
            { 
                MessageBox.Show("Incomplete Data Available for teams.", "Round was Not Finished"); 
            }

        }

        private void PlayAgainbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Application.DoEvents();
        }

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
