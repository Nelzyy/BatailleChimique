using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models
{
    public class Coordinate
    {
        private int _X;
        private int _Y;

        public Coordinate(int x, int y)
        {
            this._X = x;
            this._Y = y;
        }

        public override string ToString()
        {
            return "X : " + _X + " Y : " + _Y;
        }

        public int X => _X;
        public int Y => _Y;
    }
}
