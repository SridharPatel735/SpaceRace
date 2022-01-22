using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    class SpaceShip
    {
        //Creating Varibles
        public int X, Y, startX, startY;
        public Image shipImage = Properties.Resources.Spaceship;
        public int sideRecWidth = 7, middleRecWidth = 11, sideRecHeight = 20, middleRecHeight = 45;
        public int player1Speed, player2Speed;

        public SpaceShip(int _playerX, int _playerY)
        {
            X = _playerX;
            Y = _playerY;
            startX = _playerX;
            startY = _playerY;

            switch (SelectionScreen.player1PowerUp)
            {
                case 1:
                    GameScreen2Player.reset2 = true;
                    GameScreen2Player.resetPlayer2 = 8;
                    player1Speed = 4;
                    break;
                case 2:
                    player1Speed = 8;
                    GameScreen2Player.reset2 = false;
                    break;
            }

            switch (SelectionScreen.player2PowerUp)
            {
                case 1:
                    GameScreen2Player.reset1 = true;
                    GameScreen2Player.resetPlayer1 = 8;
                    player2Speed = 4;
                    break;
                case 2:
                    player2Speed = 8;
                    GameScreen2Player.reset1 = false;
                    break;
            }
        }

        //Score Method
        public void PlayerScore()
        {
            X = startX;
            Y = startY;
        }
        //Move method
        public int PlayerMoveUpDown(string _direction)
        {
            if (_direction == "Up")
            {
                Y -= player1Speed;
                return (Y);
            }
            if (_direction == "Down")
            {
                Y += player1Speed;
                return (Y);
            }
            return (Y);
        }
        //Move method
        public int PlayerMoveLeftRight(string _direction)
        {
            if (_direction == "Left")
            {
                X -= player1Speed;
                return (X);
            }
            if (_direction == "Right")
            {
                X += player1Speed;
                return (X);
            }
            else
            {
                return (X);
            }
        }
        //Collision method
        public Boolean Collision(Bullets bullets)
        {
            Rectangle Bullets = new Rectangle(bullets.bulletX, bullets.bulletY, bullets.bulletWidth, bullets.bulletHeight);
            Rectangle leftRec = new Rectangle(X, Y + 25, sideRecWidth, sideRecHeight);
            Rectangle middleRec = new Rectangle(X + sideRecWidth, Y, middleRecWidth, middleRecHeight);
            Rectangle rightRec = new Rectangle(X + sideRecWidth + middleRecWidth, Y + 25, sideRecWidth, sideRecHeight);

            if (Bullets.IntersectsWith(leftRec) || Bullets.IntersectsWith(middleRec) || Bullets.IntersectsWith(rightRec))
            {
                GameScreen2Player.backgroundPlayer.Stop();
                GameScreen2Player.collisionPlayer.Play();
                GameScreen2Player.afterCollision = true;
                X = startX;
                Y = startY;
                return true;
            }
            else
            {
                return false;
            }
        }
        //Reset method
        public void Reset()
        {
            X = startX;
            Y = startY;
        }
    }
}