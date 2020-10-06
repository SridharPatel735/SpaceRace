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
        public Rectangle leftRecP1, middleRecP1, rightRecP1, leftRecP2, middleRecP2, rightRecP2;
        int bulletWidth = 10, bulletHeight = 5;
        int player1X, player1Y, player2X, player2Y;
        public Image shipImage = Properties.Resources.Spaceship;
        int leftRecP1X = 295, leftRecP1Y = 784, leftRecP1Width = 10, leftRecP1Height = 24;
        int middleRecP1X = 302, middleRecP1Y = 784, middleRecP1Width = 10, middleRecP1Height = 43;
        int rightRecP1X = 310, rightRecP1Y = 784, rightRecP1Width = 10, rightRecP1Height = 24;
        int leftRecP2X = 495, leftRecP2Y = 784, leftRecP2Width = 10, leftRecP2Height = 24;
        int middleRecP2X = 502, middleRecP2Y = 784, middleRecP2Width = 10, middleRecP2Height = 43;
        int rightRecP2X = 510, rightRecP2Y = 784, rightRecP2Width = 10, rightRecP2Height = 24;

        public void Player1Score(int _player1X, int _player1Y)
        {
            leftRecP1X = 295;
            leftRecP1Y = 784;
            middleRecP1X = 302;
            middleRecP1Y = 784;
            rightRecP1X = 310;
            rightRecP1Y = 784;
            player1X = _player1X;
            player1Y = _player1Y;

            Rectangle leftRecP1 = new Rectangle(leftRecP1X, leftRecP1Y, leftRecP1Width, leftRecP1Height);
            Rectangle midRecP1 = new Rectangle(middleRecP1X, middleRecP1Y, middleRecP1Width, middleRecP1Height);
            Rectangle rightRecP1 = new Rectangle(rightRecP1X, rightRecP1Y, rightRecP1Width, rightRecP1Height);
        }
        public void Player2Score(int _player2X, int _player2Y)
        {
            leftRecP2X = 495;
            leftRecP2Y = 784;
            middleRecP2X = 502;
            middleRecP2Y = 784;
            rightRecP2X = 510;
            rightRecP2Y = 784;
            player1X = _player2X;
            player1Y = _player2Y;

            Rectangle leftRecP2 = new Rectangle(leftRecP2X, leftRecP2Y, leftRecP2Width, leftRecP2Height);
            Rectangle midRecP2 = new Rectangle(middleRecP2X, middleRecP2Y, middleRecP2Width, middleRecP2Height);
            Rectangle rightRecP2 = new Rectangle(rightRecP2X, rightRecP2Y, rightRecP2Width, rightRecP2Height);
        }
        public int Player1MoveUpDown(int player1Speed, string _direction)
        {
            if (_direction == "Up")
            {
                player1Y -= player1Speed;
                leftRecP1.Y -= player1Speed;
                middleRecP1.Y -= player1Speed;
                rightRecP1.Y -= player1Speed;
                return (player1Y);
            }
            if (_direction == "Down")
            {
                player1Y += player1Speed;
                leftRecP1.Y += player1Speed;
                middleRecP1.Y += player1Speed;
                rightRecP1.Y += player1Speed;
                return (player1Y);
            }
            else
            {
                return (player1Y);
            }
        }
        public int Player1MoveLeftRight(int player1Speed, string _direction)
        {
            if (_direction == "Left")
            {
                player1X -= player1Speed;
                leftRecP1.X -= player1Speed;
                middleRecP1.X -= player1Speed;
                rightRecP1.X -= player1Speed;
                return (player1X);
            }
            if (_direction == "Right")
            {
                player1X += player1Speed;
                leftRecP1.X += player1Speed;
                middleRecP1.X += player1Speed;
                rightRecP1.X += player1Speed;
                return (player1X);
            }
            else
            {
                return (player1X);
            }
        }
        public int Player2MoveUpDown(int player2Speed, string _direction)
        {
            if (_direction == "Up")
            {
                player2Y -= player2Speed;
                leftRecP2.Y -= player2Speed;
                middleRecP2.Y -= player2Speed;
                rightRecP2.Y -= player2Speed;
                return (player2Y);
            }
            if (_direction == "Down")
            {
                player2Y += player2Speed;
                leftRecP2.Y += player2Speed;
                middleRecP2.Y += player2Speed;
                rightRecP2.Y += player2Speed;
                return (player2Y);
            }
            else
            {
                return (player2Y);
            }
        }
        public int Player2MoveLeftRight(int player2Speed, string _direction)
        {
            if (_direction == "Left")
            {
                player2X -= player2Speed;
                leftRecP2.X -= player2Speed;
                middleRecP2.X -= player2Speed;
                rightRecP2.X -= player2Speed;
                return (player2X);
            }
            if (_direction == "Right")
            {
                player2X += player2Speed;
                leftRecP2.X += player2Speed;
                middleRecP2.X += player2Speed;
                rightRecP2.X += player2Speed;
                return (player2X);
            }
            else
            {
                return (player2X);
            }
        }
        public void Collision(int bulletX, int bulletY, int width, int height)
        {
                Rectangle Bullets = new Rectangle(bulletX, bulletY, bulletWidth, bulletHeight);

                if (Bullets.IntersectsWith(leftRecP1) || Bullets.IntersectsWith(middleRecP1) || Bullets.IntersectsWith(rightRecP1))
                {
                    player1X = width / 2 - 125;
                    player1Y = height - 50;

                    leftRecP1.X = 295;
                    leftRecP1.Y = 784;
                    leftRecP1.Width = 10;
                    leftRecP1.Height = 24;

                    middleRecP1.X = 302;
                    middleRecP1.Y = 784;
                    middleRecP1.Width = 10;
                    middleRecP1.Height = 43;

                    rightRecP1.X = 310;
                    rightRecP1.Y = 784;
                    rightRecP1.Width = 10;
                    rightRecP1.Height = 24;
                }
                if (Bullets.IntersectsWith(leftRecP2) || Bullets.IntersectsWith(middleRecP2) || Bullets.IntersectsWith(rightRecP2))
                {
                    player2X = width / 2 + 100;
                    player2Y = height - 50;

                    leftRecP2.X = 495;
                    leftRecP2.Y = 784;
                    leftRecP2.Width = 10;
                    leftRecP2.Height = 24;

                    middleRecP2.X = 502;
                    middleRecP2.Y = 784;
                    middleRecP2.Width = 10;
                    middleRecP2.Height = 43;

                    rightRecP2.X = 510;
                    rightRecP2.Y = 784;
                    rightRecP2.Width = 10;
                    rightRecP2.Height = 24;
                }
            
        }
    }
}