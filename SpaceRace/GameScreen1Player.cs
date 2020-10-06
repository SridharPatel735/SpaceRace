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
    public partial class GameScreen1Player : UserControl
    {
        List<Bullets> left = new List<Bullets>();
        List<Bullets> right = new List<Bullets>();
        List<HighScore> score = new List<HighScore>();
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Rectangle leftRec, middleRec, rightRec;
        Image shipImage = Properties.Resources.Spaceship;
        int shipWidth = 25;
        int shipHeight = 45;
        int bulletHeight = 5;
        int bulletWidth = 10;
        int player1X, player1Y, player1Speed;
        int player1Points = 0;
        int bulletCounter;
        Random randGen = new Random();
        Boolean aDown, wDown, sDown, dDown;

        public GameScreen1Player()
        {
            InitializeComponent();
            SetParameters();
        }

        private void SetParameters()
        {
            winnerLabel.Visible = false;
            leftRec.X = 295;
            leftRec.Y = 784;
            leftRec.Width = 10;
            leftRec.Height = 24;

            middleRec.X = 302;
            middleRec.Y = 784;
            middleRec.Width = 10;
            middleRec.Height = 43;

            rightRec.X = 310;
            rightRec.Y = 784;
            rightRec.Width = 10;
            rightRec.Height = 24;

            player1X = this.Width / 2 - 125;
            player1Y = this.Height - 50;

            player1Speed = 2;

            //add box
            for (int i = 0; i <= 10; i++)
            {
                Bullets newBulletLeft = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), "Left");
                left.Add(newBulletLeft);
                Bullets newBulletRight = new Bullets(randGen.Next(0, this.Width), randGen.Next(0, this.Height - 100), "Right");
                right.Add(newBulletRight);
            }
            gameTimer.Start();
        }

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

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            #region Collision
            //if (left.Count >= 22)
            //{
            //    for (int i = 0; i <= 22; i++)
            //    {
            //        Rectangle leftBullets = new Rectangle(left[i].bulletX, left[i].bulletY, left[i].bulletWidth, left[i].bulletHeight);
            //        Rectangle rightBullets = new Rectangle(right[i].bulletX, right[i].bulletY, right[i].bulletWidth, right[i].bulletHeight);

            //        if (leftBullets.IntersectsWith(leftRec) || leftBullets.IntersectsWith(middleRec) || leftBullets.IntersectsWith(rightRec) || rightBullets.IntersectsWith(leftRec) || rightBullets.IntersectsWith(middleRec) || rightBullets.IntersectsWith(rightRec))
            //        {
            //            gameTimer.Stop();
            //            winnerLabel.Visible = true;
            //            winnerLabel.Text = "You scored " + player1Points + "points";
            //            Thread.Sleep(4000);
            //            Form f = this.FindForm();
            //            f.Controls.Remove(this);
            //            // Create an instance of the SecondScreen 
            //            MainScreen ms = new MainScreen();
            //            // Add the User Control to the Form
            //            f.Controls.Add(ms);
            //        }
            //    }
            //}
            #endregion

            #region Adding Bullets
            if (bulletCounter == 8)
            {
                Bullets newBulletLeft = new Bullets(0 - 10, randGen.Next(0, this.Height - 100), "Left");
                left.Add(newBulletLeft);
                Bullets newBulletRight = new Bullets(this.Width, randGen.Next(0, this.Height - 100), "Right");
                right.Add(newBulletRight);
                bulletCounter = 0;
            }
            bulletCounter++;
            #endregion

            #region Moving Players
            if (wDown == true)
            {
                player1Y -= player1Speed;
                leftRec.Y -= player1Speed;
                middleRec.Y -= player1Speed;
                rightRec.Y -= player1Speed;
            }
            if (sDown == true && player1Y + shipHeight <= this.Height)
            {
                player1Y += player1Speed;
                leftRec.Y += player1Speed;
                middleRec.Y += player1Speed;
                rightRec.Y += player1Speed;
            }
            if (aDown == true && player1X >= 0)
            {
                player1X -= player1Speed;
                leftRec.X -= player1Speed;
                middleRec.X -= player1Speed;
                rightRec.X -= player1Speed;
            }
            if (dDown == true && player1X + shipWidth <= this.Width)
            {
                player1X += player1Speed;
                leftRec.X += player1Speed;
                middleRec.X += player1Speed;
                rightRec.X += player1Speed;
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
            if (player1Y + shipHeight <= 0)
            {
                player1Points++;
                playerScore.Text = "" + player1Points;

                HighScore hs = new HighScore(player1Points);
                score.Add(hs);

                player1X = this.Width / 2 - 125;
                player1Y = this.Height - 50;

                leftRec.X = 295;
                leftRec.Y = 784;
                leftRec.Width = 10;
                leftRec.Height = 24;

                middleRec.X = 302;
                middleRec.Y = 784;
                middleRec.Width = 10;
                middleRec.Height = 43;

                rightRec.X = 310;
                rightRec.Y = 784;
                rightRec.Width = 10;
                rightRec.Height = 24;
            }
            #endregion

            Refresh();
        }
        private void GameScreen1Player_Paint(object sender, PaintEventArgs e)
        {
            foreach (Bullets b in left)
            {
                e.Graphics.FillRectangle(whiteBrush, b.bulletX, b.bulletY, b.bulletWidth, b.bulletHeight);
            }
            foreach (Bullets b in right)
            {
                e.Graphics.FillRectangle(whiteBrush, b.bulletX, b.bulletY, b.bulletWidth, b.bulletHeight);
            }
            e.Graphics.DrawImage(shipImage, player1X, player1Y, shipWidth, shipHeight);
        }
    }
}