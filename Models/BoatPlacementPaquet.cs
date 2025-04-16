using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models
{
    public class BoatPlacementPaquet
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

        public int IdBoat
        {
            get => (int)_IdBoat!;
            set => _IdBoat = value;
        }

        public void ClearIdBoat()
        {
            _IdBoat = null;
        }

        public MaterialType MaterialType
        {
            get => (MaterialType)_MaterialType!;
            set => _MaterialType = value;
        }

        public void ClearMaterialType()
        {
            _MaterialType = null;
        }

        public SizeBoat Size
        {
            get => (SizeBoat)_Size!;
            set => _Size = value;
        }


        public void ClearSize()
        {
            _Size = null;
        }

        public Coordinate Head
        {
            get => _Head!;
            set => _Head = value;
        }

        public void ClearHead()
        {
            _Head = null;
        }

        public List<Coordinate> Coordinates
        {
            get => _Coordinate!;
            set => _Coordinate = value;
        }
        public int IdTemp { get; set; }

        public void ClearCoordinates()
        {
            _Coordinate?.Clear();
        }

        public bool CanBeUsed()
        {
            bool isValid = true;
            isValid &= (_IdBoat != null) && (_Size != null) && (_MaterialType != null) && (_Head != null) && (_Coordinate != null);
            return isValid;
        }

        public void Clear()
        {
            ClearIdBoat();
            ClearMaterialType();
            ClearSize();
            ClearHead();
            ClearCoordinates();
        }

        public bool GetIsSizeChose()
        {
            return _Size != null;
        }

        public bool GetIsTypeChose()
        {
            return _MaterialType != null;
        }

        public bool GetHeadChose()
        {
            return _Head != null;
        }

        public bool GetIsPlacementValid(List<BoatPlacementPaquet> paquetPlaced)
        {
            foreach (Coordinate coord in _Coordinate!)
            {
                bool isCoordinateValid = coord.X >= 0 &&
                                         coord.Y >= 0 &&
                                         coord.X < Board._BoardSize &&
                                         coord.Y < Board._BoardSize;
                if (!isCoordinateValid)
                {
                    return false;
                }
            }
            foreach (BoatPlacementPaquet paquet in paquetPlaced)
            {
                foreach (Coordinate coord in paquet.Coordinates)
                {
                    foreach (Coordinate coord2 in _Coordinate!)
                    {
                        if (coord == coord2)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
