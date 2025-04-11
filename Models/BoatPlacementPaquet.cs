using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models
{
    class BoatPlacementPaquet
    {
        private int? _IdBoat;
        private MaterialType? _MaterialType;
        private SizeBoat? _Size;
        private Coordinate? _Head;
        private List<Coordinate>? _Coordinate;

        public BoatPlacementPaquet()
        {
            _Coordinate = new List<Coordinate>();
        }

        public int? GetIdBoat()
        {
            return _IdBoat;
        }

        public void SetIdBoat(int id)
        {
            _IdBoat = id;
        }

        public void ClearIdBoat()
        {
            _IdBoat = null;
        }

        public SizeBoat? GetSize()
        {
            return _Size;
        }
        public void SetSize(SizeBoat size)
        {
            _Size = size;
        }
        public void ClearSize()
        {
            _Size = null;
        }
        public void clear()
        {
            ClearIdBoat();
        }
    }
}
