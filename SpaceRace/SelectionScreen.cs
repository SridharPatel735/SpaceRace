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
        public SelectionScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);
            // Create an instance of the SecondScreen 
            GameScreen gs = new GameScreen();
            // Add the User Control to the Form
            f.Controls.Add(gs);
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
        }

        private void quitButton_Enter(object sender, EventArgs e)
        {
            startButton.BackColor = Color.Black;
            quitButton.BackColor = Color.Red;
        }
    }
}
