using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SpaceRace
{
    public partial class GameScreen2Player : UserControl
    {
        List<Bullets> left = new List<Bullets>();
        List<Bullets> right = new List<Bullets>();
        SpaceShip Players = new SpaceShip(Rectangle.Empty, Rectangle.Empty, Rectangle.Empty, Rectangle.Empty, Rectangle.Empty, Rectangle.Empty);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        int shipWidth = 25;
        int shipHeight = 45;
        int bulletHeight = 5;
        int bulletWidth = 10;
        int player1X, player1Y, player2X, player2Y, player1Speed, player2Speed;
        int player1Points = 0;
        int player2Points = 0;
        string winner;
        int timerCounter, timerX, timerY;
        int resetPlayer1, resetPlayer2;
        int bulletCounter;
        Random randGen = new Random();

        Boolean rightArrowDown, leftArrowDown, upArrowDown, downArrowDown, aDown, wDown, sDown, dDown, nDown, vDown;

        public GameScreen2Player()
        {
            InitializeComponent();
            SetParameters();
        }

        private void SetParameters()
        {
            winnerLabel.Visible = false;
            switch (SelectionScreen.player1PowerUp)
            {
                case 1:
                    player1Speed = 4;
                    break;
                case 2:
                    resetPlayer2 = 2;
                    player1Speed = 2;
                    break;
            }

            switch (SelectionScreen.player2PowerUp)
            {
                case 1:
                    player2Speed = 4;
                    break;
                case 2:
                    resetPlayer1 = 2;
                    player2Speed = 2;
                    break;
            }

            Players.leftRecP1.X = 295;
            Players.leftRecP1.Y = 784;
            Players.leftRecP1.Width = 10;
            Players.leftRecP1.Height = 24;

            Players.middleRecP1.X = 302;
            Players.middleRecP1.Y = 784;
            Players.middleRecP1.Width = 10;
            Players.middleRecP1.Height = 43;

            Players.rightRecP1.X = 310;
            Players.rightRecP1.Y = 784;
            Players.rightRecP1.Width = 10;
            Players.rightRecP1.Height = 24;
            Players.shipImage = Properties.Resources.kindpng_490723;

            Players.leftRecP2.X = 495;
            Players.leftRecP2.Y = 784;
            Players.leftRecP2.Width = 10;
            Players.leftRecP2.Height = 24;

            Players.middleRecP2.X = 502;
            Players.middleRecP2.Y = 784;
            Players.middleRecP2.Width = 10;
            Players.middleRecP2.Height = 43;

            Players.rightRecP2.X = 510;
            Players.rightRecP2.Y = 784;
            Players.rightRecP2.Width = 10;
            Players.rightRecP2.Height = 24;
            Players.shipImage = Properties.Resources.kindpng_490723;

            player1X = this.Width / 2 - 125;
            player1Y = this.Height - 50;
            player2X = this.Width / 2 + 100;
            player2Y = this.Height - 50;

            timerX = this.Width / 2 - 5;
            timerY = 25;

            //add box
            for (int i = 0; i <= 22; i++)
            {
                Bullets newBulletLeft = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), bulletWidth, bulletHeight);
                left.Add(newBulletLeft);
                Bullets newBulletRight = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), bulletWidth, bulletHeight);
                right.Add(newBulletRight);
            }
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
                    aDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.V:
                    vDown = true;
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
                    aDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.V:
                    vDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Collisions
            //if (left.Count >= 22)
            //{
            //    for (int i = 0; i <= 22; i++)
            //    {
            //        Rectangle leftBullets = new Rectangle(left[i].bulletX, left[i].bulletY, left[i].bulletWidth, left[i].bulletHeight);
            //        Rectangle rightBullets = new Rectangle(right[i].bulletX, right[i].bulletY, right[i].bulletWidth, right[i].bulletHeight);

            //        if (leftBullets.IntersectsWith(Players.leftRecP1) || leftBullets.IntersectsWith(Players.middleRecP1) || leftBullets.IntersectsWith(Players.rightRecP1) || rightBullets.IntersectsWith(Players.leftRecP1) || rightBullets.IntersectsWith(Players.middleRecP1) || rightBullets.IntersectsWith(Players.rightRecP1))
            //        {
            //            player1X = this.Width / 2 - 125;
            //            player1Y = this.Height - 50;

            //            Players.leftRecP1.X = 295;
            //            Players.leftRecP1.Y = 784;
            //            Players.leftRecP1.Width = 10;
            //            Players.leftRecP1.Height = 24;

            //            Players.middleRecP1.X = 302;
            //            Players.middleRecP1.Y = 784;
            //            Players.middleRecP1.Width = 10;
            //            Players.middleRecP1.Height = 43;

            //            Players.rightRecP1.X = 310;
            //            Players.rightRecP1.Y = 784;
            //            Players.rightRecP1.Width = 10;
            //            Players.rightRecP1.Height = 24;
            //        }
            //        if (leftBullets.IntersectsWith(Players.leftRecP2) || leftBullets.IntersectsWith(Players.middleRecP2) || leftBullets.IntersectsWith(Players.rightRecP2) || rightBullets.IntersectsWith(Players.leftRecP2) || rightBullets.IntersectsWith(Players.middleRecP2) || rightBullets.IntersectsWith(Players.rightRecP2))
            //        {
            //            player2X = this.Width / 2 + 100;
            //            player2Y = this.Height - 50;

            //            Players.leftRecP2.X = 495;
            //            Players.leftRecP2.Y = 784;
            //            Players.leftRecP2.Width = 10;
            //            Players.leftRecP2.Height = 24;

            //            Players.middleRecP2.X = 502;
            //            Players.middleRecP2.Y = 784;
            //            Players.middleRecP2.Width = 10;
            //            Players.middleRecP2.Height = 43;

            //            Players.rightRecP2.X = 510;
            //            Players.rightRecP2.Y = 784;
            //            Players.rightRecP2.Width = 10;
            //            Players.rightRecP2.Height = 24;
            //        }
            //    }
            //}
            #endregion

            #region Adding Bullets
            if (bulletCounter == 5)
            {
                Bullets newBulletLeft = new Bullets(0 - bulletWidth, randGen.Next(0, this.Height - 100), bulletWidth, bulletHeight);
                left.Add(newBulletLeft);

                Bullets newBulletRight = new Bullets(this.Width, randGen.Next(0, this.Height - 100), bulletWidth, bulletHeight);
                right.Add(newBulletRight);
                bulletCounter = 0;
            }
            bulletCounter++;
            #endregion

            #region PowerUp
            if (resetPlayer1 > 0 && vDown == true)
            {
                player1Y = this.Height - 50;
            }
            if (resetPlayer2 > 0 && nDown == true)
            {
                player2Y = this.Height - 50;
            }
            #endregion

            #region Moving Players
            if (wDown == true)
            {
                player2Y -= player2Speed;
                Players.leftRecP2.Y -= player2Speed;
                Players.middleRecP2.Y -= player2Speed;
                Players.rightRecP2.Y -= player2Speed;
            }
            if (sDown == true)
            {
                player2Y += player2Speed;
                Players.leftRecP2.Y += player2Speed;
                Players.middleRecP2.Y += player2Speed;
                Players.rightRecP2.Y += player2Speed;
            }
            if (aDown == true)
            {
                player2X -= player2Speed;
                Players.leftRecP2.X -= player2Speed;
                Players.middleRecP2.X -= player2Speed;
                Players.rightRecP2.X -= player2Speed;
            }
            if (dDown == true)
            {
                player2X += player2Speed;
                Players.leftRecP2.X += player2Speed;
                Players.middleRecP2.X += player2Speed;
                Players.rightRecP2.X += player2Speed;
            }

            if (upArrowDown == false)
            {
                player1Y -= player1Speed;
                Players.leftRecP1.Y -= player1Speed;
                Players.middleRecP1.Y -= player1Speed;
                Players.rightRecP1.Y -= player1Speed;
            }
            if (downArrowDown == true)
            {
                player1Y += player1Speed;
                Players.leftRecP1.Y += player1Speed;
                Players.middleRecP1.Y += player1Speed;
                Players.rightRecP1.Y += player1Speed;
            }
            if (leftArrowDown == true)
            {
                player1X -= player1Speed;
                Players.leftRecP1.X -= player1Speed;
                Players.middleRecP1.X -= player1Speed;
                Players.rightRecP1.X -= player1Speed;
            }
            if (rightArrowDown == true)
            {
                player1X += player1Speed;
                Players.leftRecP1.X += player1Speed;
                Players.middleRecP1.X += player1Speed;
                Players.rightRecP1.X += player1Speed;
            }
            #endregion

            #region Moving Bullets
            foreach (Bullets x in left)
            {
                x.bulletX += 5;
            }
            foreach (Bullets x in right)
            {
                x.bulletX -= 5;
            }
            #endregion

            #region Timer Update
            if (timerCounter == 50)
            {
                timerY -= 10;
                timerCounter = 0;
            }
            timerCounter++;
            #endregion

            #region Timer Finish
            if (timerY == -5)
            {
                gameTimer.Stop();
                winnerLabel.Visible = true;
                if (player1Points > player2Points)
                {
                    winner = "Player 1 is the Winner!";
                }
                else if (player2Points > player1Points)
                {
                    winner = "Player 2 is the Winner!";
                }
                else
                {
                    winner = "It's a Tie!";
                }
                winnerLabel.Text = winner;
                Thread.Sleep(4000);
                Form f = this.FindForm();
                f.Controls.Remove(this);
                // Create an instance of the SecondScreen 
                MainScreen ms = new MainScreen();
                // Add the User Control to the Form
                f.Controls.Add(ms);
            }
            #endregion

            #region Removing Bullets
            if (left[0].bulletX >= this.Width)
            {
                left.RemoveAt(0);
            }
            if (right[0].bulletX + bulletWidth <= 0)
            {
                right.RemoveAt(0);
            }
            #endregion

            #region Score
            if (player1Y + shipHeight <= 0 )
            {
                player1Points++;
                player1Score.Text = "" + player1Points; 

                player1X = this.Width / 2 - 125;
                player1Y = this.Height - 50;

                Players.leftRecP1.X = 295;
                Players.leftRecP1.Y = 784;
                Players.leftRecP1.Width = 10;
                Players.leftRecP1.Height = 24;

                Players.middleRecP1.X = 302;
                Players.middleRecP1.Y = 784;
                Players.middleRecP1.Width = 10;
                Players.middleRecP1.Height = 43;

                Players.rightRecP1.X = 310;
                Players.rightRecP1.Y = 784;
                Players.rightRecP1.Width = 10;
                Players.rightRecP1.Height = 24;
            }
            if (player2Y + shipHeight <= 0)
            {
                player2Points++;
                player2Score.Text = "" + player2Points;

                player2X = this.Width / 2 + 100;
                player2Y = this.Height - 50;

                Players.leftRecP2.X = 495;
                Players.leftRecP2.Y = 784;
                Players.leftRecP2.Width = 10;
                Players.leftRecP2.Height = 24;

                Players.middleRecP2.X = 502;
                Players.middleRecP2.Y = 784;
                Players.middleRecP2.Width = 10;
                Players.middleRecP2.Height = 43;

                Players.rightRecP2.X = 510;
                Players.rightRecP2.Y = 784;
                Players.rightRecP2.Width = 10;
                Players.rightRecP2.Height = 24;
            }
            #endregion

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(redBrush, timerX, timerY, 10, this.Height);
            foreach (Bullets b in left)
            {
                e.Graphics.FillRectangle(whiteBrush, b.bulletX, b.bulletY, b.bulletWidth, b.bulletHeight);
            }
            foreach (Bullets b in right)
            {
                e.Graphics.FillRectangle(whiteBrush, b.bulletX, b.bulletY, b.bulletWidth, b.bulletHeight);
            }
            e.Graphics.DrawImage(Players.shipImage, player1X, player1Y, shipWidth, shipHeight);
            e.Graphics.DrawImage(Players.shipImage, player2X, player2Y, shipWidth, shipHeight);
        }
    }
}