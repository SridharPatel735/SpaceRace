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
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        int shipWidth = 25;
        int shipHeight = 45;
        int player1X, player1Y, player2X, player2Y, player1Speed, player2Speed;
        int timerCounter, timerX, timerY;
        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aArrowDown, wArrowDown, sArrowDown, dArrowDown;

        public GameScreen()
        {
            InitializeComponent();
            SetParameters();
        }

        private void SetParameters()
        {
            Hero1.leftRecP1.X = 295;
            Hero1.leftRecP1.Y = 784;
            Hero1.leftRecP1.Width = 10;
            Hero1.leftRecP1.Height = 24;

            Hero1.middleRecP1.X = 302;
            Hero1.middleRecP1.Y = 784;
            Hero1.middleRecP1.Width = 10;
            Hero1.middleRecP1.Height = 43;

            Hero1.rightRecP1.X = 310;
            Hero1.rightRecP1.Y = 784;
            Hero1.rightRecP1.Width = 10;
            Hero1.rightRecP1.Height = 24;
            Hero1.shipImage = Properties.Resources.kindpng_490723;

            Hero2.leftRecP2.X = 495;
            Hero2.leftRecP2.Y = 784;
            Hero2.leftRecP2.Width = 10;
            Hero2.leftRecP2.Height = 24;

            Hero2.middleRecP2.X = 502;
            Hero2.middleRecP2.Y = 784;
            Hero2.middleRecP2.Width = 10;
            Hero2.middleRecP2.Height = 43;

            Hero2.rightRecP2.X = 510;
            Hero2.rightRecP2.Y = 784;
            Hero2.rightRecP2.Width = 10;
            Hero2.rightRecP2.Height = 24;
            Hero2.shipImage = Properties.Resources.kindpng_490723;

            player1X = this.Width / 2 - 125;
            player1Y = this.Height - 50;
            player2X = this.Width / 2 + 100;
            player2Y = this.Height - 50;

            timerX = this.Width / 2 - 5;
            timerY = 0;

            player1Speed = 10;
            player2Speed = 10;
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.A:
                    aArrowDown = true;
                    break;
                case Keys.W:
                    wArrowDown = true;
                    break;
                case Keys.S:
                    sArrowDown = true;
                    break;
                case Keys.D:
                    dArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.A:
                    aArrowDown = false;
                    break;
                case Keys.W:
                    wArrowDown = false;
                    break;
                case Keys.S:
                    sArrowDown = false;
                    break;
                case Keys.D:
                    dArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (wArrowDown == true)
            {
                player2Y -= player2Speed;
            }
            if (sArrowDown == true)
            {
                player2Y += player2Speed;
            }

            if (upArrowDown == true)
            {
                player1Y -= player1Speed;
            }
            if (downArrowDown == true)
            {
                player1Y += player1Speed;
            }

            if (timerCounter == 50)
            {
                timerY += 5;
            }

            timerCounter++;
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Hero1.shipImage, player1X, player1Y, shipWidth, shipHeight);
            e.Graphics.DrawImage(Hero2.shipImage, player2X, player2Y, shipWidth, shipHeight);
            e.Graphics.FillRectangle(whiteBrush, timerX, 0, 10, this.Height);
            e.Graphics.FillRectangle(blackBrush, timerX, 0, 10, timerY);
        }
    }
}
