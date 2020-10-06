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
using System.Media;
using System.Runtime.CompilerServices;

namespace SpaceRace
{
    public partial class GameScreen2Player : UserControl
    {
        List<Bullets> bulletList = new List<Bullets>();
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SpaceShip Player1 = new SpaceShip();
        SpaceShip Player2 = new SpaceShip();
        Bullets bullet = new Bullets(0, 0, "");
        Image shipImage = Properties.Resources.Spaceship;
        int shipWidth = 25, shipHeight = 45;
        int player1X, player1Y, player2X, player2Y, player1Speed, player2Speed;
        int player1Points = 0;
        int player2Points = 0;
        string winner;
        int timerCounter, timerX, timerY;
        int resetPlayer1, resetPlayer2;
        int bulletCounter;
        Random randGen = new Random();
        int leftRecP1X = 295, leftRecP1Y = 784;
        int middleRecP1X = 302, middleRecP1Y = 784;
        int rightRecP1X = 310, rightRecP1Y = 784;
        int leftRecP2X = 495, leftRecP2Y = 784;
        int middleRecP2X = 502, middleRecP2Y = 784;
        int rightRecP2X = 510, rightRecP2Y = 784;

        Boolean reset1, reset2;
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
                    reset2 = false;
                    break;
                case 2:
                    reset2 = true;
                    resetPlayer2 = 3;
                    player1Speed = 2;
                    break;
            }

            switch (SelectionScreen.player2PowerUp)
            {
                case 1:
                    player2Speed = 4;
                    reset1 = false;
                    break;
                case 2:
                    reset1 = true;
                    resetPlayer1 = 3;
                    player2Speed = 2;
                    break;
            }

            player1X = this.Width / 2 - 125;
            player1Y = this.Height - 50;
            player2X = this.Width / 2 + 100;
            player2Y = this.Height - 50;

            timerX = this.Width / 2 - 5;
            timerY = this.Height;

            //add box
            for (int i = 0; i <= 10; i++)
            {
                Bullets newBulletLeft = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), "Left");
                bulletList.Add(newBulletLeft);
                Bullets newBulletRight = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), "Right");
                bulletList.Add(newBulletRight);
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
                    if (reset1 == true)
                    {
                        nDown = true;
                    }
                    break;
                case Keys.V:
                    if (reset2 == true)
                    {
                        vDown = true;
                    }
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
            foreach (Bullets x in bulletList)
            {
                Player1.Collision(x.bulletX, x.bulletY, this.Width, this.Height);
            }
            #endregion

            #region Adding Bullets
            if (bulletCounter == 8)
            {
                Bullets newBulletLeft = new Bullets(0 - 10, randGen.Next(0, this.Height - 100), "Left");
                bulletList.Add(newBulletLeft);
                Bullets newBulletRight = new Bullets(this.Width, randGen.Next(0, this.Height - 100), "Right");
                bulletList.Add(newBulletRight);
                bulletCounter = 0;
            }
            bulletCounter++;
            #endregion

            #region PowerUp
            if (resetPlayer1 >= 0 && vDown == true)
            {
                player1Y = this.Height - 50;
                resetPlayer1--;
                leftRecP1X = 295;
                leftRecP1Y = 784;
                middleRecP1X = 302;
                middleRecP1Y = 784;
                rightRecP1X = 310;
                rightRecP1Y = 784;
            }
            if (resetPlayer2 >= 0 && nDown == true)
            {
                player2Y = this.Height - 50;
                resetPlayer2--;
                leftRecP2X = 495;
                leftRecP2Y = 784;
                middleRecP2X = 502;
                middleRecP2Y = 784;
                rightRecP2X = 510;
                rightRecP2Y = 784;
            }
            #endregion

            #region Moving Players
            if (wDown == true)
            {
                player2Y = Player2.Player2MoveUpDown(player2Speed, "Up");
            }
            if (sDown == true && player2Y + shipHeight <= this.Height)
            {
                player2Y = Player2.Player2MoveUpDown(player2Speed, "Down");
            }
            if (aDown == true && player2X >= 0)
            {
                player2X = Player2.Player2MoveLeftRight(player2Speed, "Left");
            }
            if (dDown == true && player2X + shipWidth <= this.Width)
            {
                player2X = Player2.Player2MoveLeftRight(player2Speed, "Right");
            }

            if (upArrowDown == true)
            {
                player1Y = Player1.Player1MoveUpDown(player1Speed, "Up");
            }
            if (downArrowDown == true && player1Y + shipHeight <= this.Height)
            {
                player1Y = Player1.Player1MoveUpDown(player1Speed, "Down");
            }
            if (leftArrowDown == true && player1X >= 0)
            {
                player1X = Player1.Player1MoveLeftRight(player1Speed, "Left");
            }
            if (rightArrowDown == true && player1X + shipWidth <= this.Width)
            {
                player1X = Player1.Player1MoveLeftRight(player1Speed, "Right");
            }
            #endregion

            #region Moving Bullets
            foreach (Bullets x in bulletList)
            {
                x.bulletX = bullet.BulletsMove(x.direction, x.bulletX);
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
                Refresh();
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
            if (bulletList[0].bulletX >= this.Width || bulletList[0].bulletX <= 0)
            {
                bulletList.RemoveAt(0);
            }
            #endregion

            #region Score
            if (player1Y + shipHeight <= 0)
            {
                player1X = this.Width / 2 - 125;
                player1Y = this.Height - 50;
                player1Points++;
                player1Score.Text = "" + player1Points;
                Player1.Player1Score(player1X, player1Y);
            }
            if (player2Y + shipHeight <= 0)
            {
                player2X = this.Width / 2 + 100;
                player2Y = this.Height - 50;
                player2Points++;
                player2Score.Text = "" + player2Points;
                Player2.Player2Score(player2X, player2Y);
            }
            #endregion

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(redBrush, timerX, timerY, 10, this.Height);
            foreach (Bullets b in bulletList)
            {
                e.Graphics.FillRectangle(whiteBrush, b.bulletX, b.bulletY, b.bulletWidth, b.bulletHeight);
            }
            e.Graphics.DrawImage(shipImage, player1X, player1Y, shipWidth, shipHeight);
            e.Graphics.DrawImage(shipImage, player2X, player2Y, shipWidth, shipHeight);
        }
    }
}