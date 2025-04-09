using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;
enum Type
{
    Cuivre,
    Fer,
    Zinc
}
enum Size
{
    tiny,
    tinyMiddle,
    bigMiddle,
    big
}
class Bateau
{
    private int _Id;
    protected Type _Type;
    protected Size _Size;
    protected int _Length;
    private Coordinate _Head;
    private List<Coordinate> _Coordinate;

    protected Bateau(int id, Size size, Coordinate head, List<Coordinate> coords)
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

    private void SetSize(Size size)
    {
        switch (size)
        {
            case Size.tiny:
                _Length = 2;
                break;
            case Size.tinyMiddle:
                _Length = 3;
                break;
            case Size.bigMiddle:
                _Length = 4;
                break;
            case Size.big:
                _Length = 5;
                break;
        }
    }
}
