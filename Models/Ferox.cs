using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;

class Ferox : Bateau
{
    public Ferox(int id, Size size, Coordinate head, List<Coordinate> coords) : base(id, size, head, coords)
    {
        this._Type = Type.Fer;
    }
}
