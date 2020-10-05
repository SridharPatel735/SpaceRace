using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceRace
{
    public partial class SelectionScreen : UserControl
    {
        public static int player1PowerUp, player2PowerUp;
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (player1PowerUp > 0 && player2PowerUp > 0)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);
                // Create an instance of the SecondScreen 
                GameScreen2Player gs = new GameScreen2Player();
                // Add the User Control to the Form
                f.Controls.Add(gs);
                gs.Focus();
            }
            else
            {
                outputLabel.Text = "Please select your powerups";
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the SecondScreen 
            MainScreen ms = new MainScreen();
            // Add the User Control to the Form
            f.Controls.Add(ms);
        }

        private void startButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Lime;
            quitButton.BackColor = Color.Black;
            doubleSpeedPlayer1.BackColor = Color.Black;
            resetPlayer2.BackColor = Color.Black;
            doubleSpeedPlayer2.BackColor = Color.Black;
            resetPlayer1.BackColor = Color.Black;
        }

        private void quitButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Red;
            doubleSpeedPlayer1.BackColor = Color.Black;
            resetPlayer2.BackColor = Color.Black;
            doubleSpeedPlayer2.BackColor = Color.Black;
            resetPlayer1.BackColor = Color.Black;
        }

        private void doubleSpeedPlayer2_Click(object sender, EventArgs e)
        {
            player2PowerUp = 1;
            doubleSpeedPlayer2.Enabled = false;
            doubleSpeedPlayer2.Visible = false;
            resetPlayer1.Enabled = false;
            resetPlayer1.Visible = false;
        }

        private void resetPlayer1_Click(object sender, EventArgs e)
        {
            player2PowerUp = 2;
            doubleSpeedPlayer2.Enabled = false;
            doubleSpeedPlayer2.Visible = false;
            resetPlayer1.Enabled = false;
            resetPlayer1.Visible = false;
        }

        private void doubleSpeedPlayer1_Click(object sender, EventArgs e)
        {
            player1PowerUp = 1;
            doubleSpeedPlayer1.Enabled = false;
            doubleSpeedPlayer1.Visible = false;
            resetPlayer2.Enabled = false;
            resetPlayer2.Visible = false;
        }

        private void doubleSpeedPlayer2_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Black;
            doubleSpeedPlayer1.BackColor = Color.Black;
            resetPlayer2.BackColor = Color.Black;
            doubleSpeedPlayer2.BackColor = Color.Lime;
            resetPlayer1.BackColor = Color.Black;
        }

        private void resetPlayer1_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Black;
            doubleSpeedPlayer1.BackColor = Color.Black;
            resetPlayer2.BackColor = Color.Black;
            doubleSpeedPlayer2.BackColor = Color.Black;
            resetPlayer1.BackColor = Color.Lime;
        }

        private void doubleSpeedPlayer1_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Black;
            doubleSpeedPlayer1.BackColor = Color.Lime;
            resetPlayer2.BackColor = Color.Black;
            doubleSpeedPlayer2.BackColor = Color.Black;
            resetPlayer1.BackColor = Color.Black;
        }

        private void resetPlayer2_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Black;
            doubleSpeedPlayer1.BackColor = Color.Black;
            resetPlayer2.BackColor = Color.Lime;
            doubleSpeedPlayer2.BackColor = Color.Black;
            resetPlayer1.BackColor = Color.Black;
        }

        private void resetPlayer2_Click(object sender, EventArgs e)
        {
            player1PowerUp = 2;
            doubleSpeedPlayer1.Enabled = false;
            doubleSpeedPlayer1.Visible = false;
            resetPlayer2.Enabled = false;
            resetPlayer2.Visible = false;
        }
    }
}
