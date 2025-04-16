using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;
public enum MaterialType
{
    Cuivre,
    Fer,
    Zinc
}
public enum SizeBoat
{
    tiny,
    tinyMiddle,
    bigMiddle,
    big
}
class Bateau
{
    private int _Id;
    protected MaterialType _Type;
    protected SizeBoat _Size;
    protected int _Length;
    private Coordinate _Head;
    private List<Coordinate> _Coordinate;

    protected Bateau(int id, SizeBoat size, Coordinate head, List<Coordinate> coords)
    {
        _Id = id;
        _Size = size;
        SetSize(size);
        _Head = head;
        _Coordinate = coords;
    }

    public List<Coordinate> Coordinates
    {
        get => _Coordinate;
    }

    private void SetSize(SizeBoat size)
    {
        switch (size)
        {
            case SizeBoat.tiny:
                _Length = 2;
                break;
            case SizeBoat.tinyMiddle:
                _Length = 3;
                break;
            case SizeBoat.bigMiddle:
                _Length = 4;
                break;
            case SizeBoat.big:
                _Length = 5;
                break;
        }
    }
}
