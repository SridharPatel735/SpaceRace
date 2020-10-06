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

        public SpaceShip(int _playerX, int _playerY)
        {
            X = _playerX;
            Y = _playerY;
            X = startX;
            Y = startY;
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
                leftRec.Y -= player1Speed;
                middleRec.Y -= player1Speed;
                rightRec.Y -= player1Speed;
                return (Y);
            }
            if (_direction == "Down")
            {
                Y += player1Speed;
                leftRec.Y += player1Speed;
                middleRec.Y += player1Speed;
                rightRec.Y += player1Speed;
                return (Y);
            }
            return (Y);
        }
        public int PlayerMoveLeftRight(int player1Speed, string _direction)
        {
            if (_direction == "Left")
            {
                X -= player1Speed;
                leftRec.X -= player1Speed;
                middleRec.X -= player1Speed;
                rightRec.X -= player1Speed;
                return (X);
            }
            if (_direction == "Right")
            {
                X += player1Speed;
                leftRec.X += player1Speed;
                middleRec.X += player1Speed;
                rightRec.X += player1Speed;
                return (X);
            }
            else
            {
                return (X);
            }
        }
        public void Collision(int bulletX, int bulletY, int width, int height)
        {
            Rectangle Bullets = new Rectangle(bulletX, bulletY, bulletWidth, bulletHeight);

            if (Bullets.IntersectsWith(leftRec) || Bullets.IntersectsWith(middleRec) || Bullets.IntersectsWith(rightRec))
            {
                X = width / 2 - 125;
                Y = height - 50;

                    
                //Rec1.X = Player1.X
                //Rec1.Y = Player1.Y + 25;
                //Rec2.X = Player1.X + sideRecWidth;
                //Rec2.Y = Player1.Y;
                //Rec3.X = Player1.X + sideRecWidth + middleRecWidth;
            }
            if (Bullets.IntersectsWith(leftRec) || Bullets.IntersectsWith(middleRec) || Bullets.IntersectsWith(rightRec))
            {
                X = width / 2 + 100;
                Y = height - 50;
            }
            
        }
    }
}