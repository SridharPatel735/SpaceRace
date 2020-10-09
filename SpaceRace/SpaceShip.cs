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
        public Rectangle leftRec, middleRec, rightRec;
        int bulletWidth = 10, bulletHeight = 5;
        public int X, Y, startX, startY;
        public Image shipImage = Properties.Resources.Spaceship;
        public int sideRecWidth = 7, middleRecWidth = 11, sideRecHeight = 20, middleRecHeight = 45;

        public SpaceShip(int _playerX, int _playerY)
        {
            X = _playerX;
            Y = _playerY;
            startX = _playerX;
            startY = _playerY;
        }

        public void PlayerScore()
        {
            X = startX;
            Y = startY;
        }
        public int PlayerMoveUpDown(int player1Speed, string _direction)
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
        public int PlayerMoveLeftRight(int player1Speed, string _direction)
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
        public Boolean Collision(int bulletX, int bulletY)
        {
            Rectangle Bullets = new Rectangle(bulletX, bulletY, bulletWidth, bulletHeight);
            Rectangle leftRec = new Rectangle(X, Y + 25, sideRecWidth, sideRecHeight);
            Rectangle middleRec = new Rectangle(X + sideRecWidth, Y, middleRecWidth, middleRecHeight);
            Rectangle rightRec = new Rectangle(X + sideRecWidth + middleRecWidth, Y + 25, sideRecWidth, sideRecHeight);

            if (Bullets.IntersectsWith(leftRec) || Bullets.IntersectsWith(middleRec) || Bullets.IntersectsWith(rightRec))
            {
                X = startX;
                Y = startY;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Reset()
        {
            X = startX;
            Y = startY;
        }
    }
}