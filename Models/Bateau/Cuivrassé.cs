using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;
class Cuivrassé : Bateau
{
    public Cuivrassé(int id, SizeBoat size, Coordinate head, List<Coordinate> coords) : base(id, size, head, coords)
    {
        _Type = MaterialType.Cuivre;
    }
}
