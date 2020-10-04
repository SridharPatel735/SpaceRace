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
        public Image shipImage;

        public SpaceShip(Rectangle _leftRecP1, Rectangle _middleRecP1, Rectangle _rightRecP1, Rectangle _leftRecP2, Rectangle _middleRecP2, Rectangle _rightRecP2)
        {
            leftRecP1 = _leftRecP1;
            middleRecP1 = _middleRecP1;
            rightRecP1 = _rightRecP1;
            leftRecP2 = _leftRecP2;
            middleRecP2 = _middleRecP2;
            rightRecP2 = _rightRecP2;
        }
    }
}
