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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the SecondScreen 
            SelectionScreen ss = new SelectionScreen();
            // Add the User Control to the Form
            f.Controls.Add(ss);
        }

        private void quitButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Red;
        }

        private void playAgainButton_Enter(object sender, EventArgs e)
        {
            playAgainButton.BackColor = Color.Green;
            quitButton.BackColor = Color.Black;
        }
    }
}
