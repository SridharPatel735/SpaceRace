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
    public partial class GameScreen : UserControl
    {
        List<Bullets> left = new List<Bullets>();
        List<Bullets> right = new List<Bullets>();
        Ship Hero1 = new Ship();
        Ship Hero2 = new Ship();
        SolidBrush brush = new SolidBrush(Color.White);
        int player1X = 295;
        int player1Y = 650;
        int player2X = 495;
        int player2Y = 650;
        int shipWidth = 25;
        int shipHeight = 45;

        public GameScreen()
        {
            InitializeComponent();
            SetParameters();
        }

        private void SetParameters()
        {
            Hero1.p11.X = 295;
            Hero1.p11.Y = 784;
            Hero1.p11.Width = 10;
            Hero1.p11.Height = 24;

            Hero1.p12.X = 302;
            Hero1.p12.Y = 784;
            Hero1.p12.Width = 10;
            Hero1.p12.Height = 43;

            Hero1.p13.X = 310;
            Hero1.p13.Y = 784;
            Hero1.p13.Width = 10;
            Hero1.p13.Height = 24;
            Hero1.shipImage = Properties.Resources.kindpng_490723;

            Hero2.p21.X = 495;
            Hero2.p21.Y = 784;
            Hero2.p21.Width = 10;
            Hero2.p21.Height = 24;

            Hero2.p22.X = 502;
            Hero2.p22.Y = 784;
            Hero2.p22.Width = 10;
            Hero2.p22.Height = 43;

            Hero2.p23.X = 510;
            Hero2.p23.Y = 784;
            Hero2.p23.Width = 10;
            Hero2.p23.Height = 24;
            Hero2.shipImage = Properties.Resources.kindpng_490723;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Hero1.shipImage, player1X, player1Y, shipWidth, shipHeight);
            e.Graphics.DrawImage(Hero2.shipImage, player2X, player2Y, shipWidth, shipHeight);
        }
    }
}
