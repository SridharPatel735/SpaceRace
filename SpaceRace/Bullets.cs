using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    class Bullets
    {
        public int bulletX, bulletY, bulletWidth = 10, bulletHeight = 5, bulletSpeed = 5;
        public string direction;

        public Bullets(int _bulletX, int _bulletY, string _direction)
        {
            bulletX = _bulletX;
            bulletY = _bulletY;
            direction = _direction;
        }
        public int BulletsMove(string direction, int bulletX)
        {
            if (direction == "Right")
            {
                bulletX -= bulletSpeed;
            }
            else
            {
                bulletX += bulletSpeed;
            }
            return (bulletX);
        }
    }
}
