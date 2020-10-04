using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceRace
{
    class Bullets
    {
        public int bulletX, bulletY, bulletWidth, bulletHeight;

        public Bullets(int _bulletX, int _bulletY, int _bulletWidth, int _bulletHeight)
        {
            bulletX = _bulletX;
            bulletY = _bulletY;
            bulletWidth = _bulletWidth;
            bulletHeight = _bulletHeight;
        }
    }
}
