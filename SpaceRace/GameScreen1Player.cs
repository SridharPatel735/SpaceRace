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
using System.Xml;

namespace SpaceRace
{
    public partial class GameScreen1Player : UserControl
    {
        //Creating Varibles
        List<Bullets> bulletList = new List<Bullets>();
        SpaceShip Player1 = new SpaceShip(533 / 2 - 125, 575 - 50);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Image shipImage = Properties.Resources.Spaceship;
        int shipWidth = 25;
        int shipHeight = 45;
        int bulletHeight = 5;
        int bulletWidth = 10;
        int player1Speed;
        int player1Points = 0;
        int bulletCounter;
        Random randGen = new Random();
        Boolean aDown, wDown, sDown, dDown;

        public GameScreen1Player()
        {
            InitializeComponent();
            SetParameters();
        }
        //Setting Gmae Values
        private void SetParameters()
        {
            winnerLabel.Text = "";
            player1Speed = 6;
            //add box
            for (int i = 0; i <= 10; i++)
            {
                Bullets newBulletLeft = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), "Left");
                bulletList.Add(newBulletLeft);
                Bullets newBulletRight = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), "Right");
                bulletList.Add(newBulletRight);
            }
            gameTimer.Start();
        }
        //KeyDown Method
        private void GameScreen1Player_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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
            }
        }
        //KeyUp Method
        private void GameScreen1Player_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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
            }
        }
        //GameTimer Tick Method
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Collision Code
            #region Collision
            foreach (Bullets x in bulletList)
            {
                if (Player1.Collision(x.bulletX, x.bulletY))
                {
                    gameTimer.Enabled = false;
                    winnerLabel.Text = "You scored " + player1Points + " points";
                    Refresh();
                    Thread.Sleep(4000);
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    // Create an instance of the SecondScreen 
                    MainScreen ms = new MainScreen();
                    // Add the User Control to the Form
                    f.Controls.Add(ms);
                }
            }
            #endregion
            //Adding Bullets Code
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
            //Updating Player position
            #region Moving Players
            if (wDown == true)
            {
                Player1.PlayerMoveUpDown(player1Speed, "Up");
            }
            if (sDown == true && Player1.Y + shipHeight <= this.Height)
            {
                Player1.PlayerMoveUpDown(player1Speed, "Down");
            }
            if (aDown == true && Player1.X >= 0)
            {
                Player1.PlayerMoveLeftRight(player1Speed, "Left");
            }
            if (dDown == true && Player1.X + shipWidth <= this.Width)
            {
                Player1.PlayerMoveLeftRight(player1Speed, "Right");
            }
            #endregion
            //Updating Bullet Position
            #region Moving Bullets
            foreach (Bullets x in bulletList)
            {
                x.BulletsMove();
            }
            #endregion
            //Removing Bullets
            #region Removing Bullets
            if (bulletList[0].bulletX >= this.Width || bulletList[0].bulletX <= 0)
            {
                bulletList.RemoveAt(0);
            }
            #endregion
            //Score Code
            #region Score
            if (Player1.Y + shipHeight <= 0)
            {
                Player1.PlayerScore();
                player1Points++;
                playerScore.Text = "" + player1Points;
            }
            #endregion
            //Calling the Paint Method
            Refresh();
        }
        //Painting the whole screen
        private void GameScreen1Player_Paint(object sender, PaintEventArgs e)
        {
            foreach (Bullets b in bulletList)
            {
                e.Graphics.FillRectangle(whiteBrush, b.bulletX, b.bulletY, b.bulletWidth, b.bulletHeight);
            }
            e.Graphics.DrawImage(shipImage, Player1.X, Player1.Y, shipWidth, shipHeight);
        }
    }
}