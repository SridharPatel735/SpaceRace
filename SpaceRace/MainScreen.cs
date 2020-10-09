using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpaceRace
{
    public partial class MainScreen : UserControl
    {
        List<HighScore> highScoreList2Player = new List<HighScore>();
        List<HighScore> highScoreList1Player = new List<HighScore>();
        public MainScreen()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play2PlayerButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the SecondScreen 
            SelectionScreen ss = new SelectionScreen();
            // Add the User Control to the Form
            f.Controls.Add(ss);
            ss.Focus();
        }

        private void quitButton_Enter(object sender, EventArgs e)
        {
            play2PlayerButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Red;
            play1PlayerButton.BackColor = Color.Black;
            highScoreButton.BackColor = Color.Black;
        }

        private void play2PlayerButton_Enter(object sender, EventArgs e)
        {
            play2PlayerButton.BackColor = Color.Lime;
            quitButton.BackColor = Color.Black;
            play1PlayerButton.BackColor = Color.Black;
            highScoreButton.BackColor = Color.Black;
        }

        private void play1PlayerButton_Enter(object sender, EventArgs e)
        {
            play1PlayerButton.BackColor = Color.Lime;
            quitButton.BackColor = Color.Black;
            play2PlayerButton.BackColor = Color.Black;
            highScoreButton.BackColor = Color.Black;
        }

        private void play1PlayerButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the SecondScreen 
            GameScreen1Player gs = new GameScreen1Player();
            // Add the User Control to the Form
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void highScoreButton_Enter(object sender, EventArgs e)
        {
            play1PlayerButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Black;
            play2PlayerButton.BackColor = Color.Black;
            highScoreButton.BackColor = Color.Orange;
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {

        }
    }
}
