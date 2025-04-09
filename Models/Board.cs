using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;

class Board
{
    public const int _BoatMax = 5;
    private CaseBoard[,] _Board;
    private Bateau[] _Bateaux;
    private List<Coordinate>[] _BoatCoordinate;
    private int _BoatCount;

    public Board()
    {
        _Board = new CaseBoard[8, 8];
        _Bateaux = new Bateau[_BoatMax];
        _BoatCoordinate = new List<Coordinate>[_BoatMax];
    }

    public void AddBoat(Bateau boat)
    {
        if (_BoatCount <= _BoatMax)
        {
            _Bateaux[_BoatCount] = boat;
            _BoatCoordinate[_BoatCount] = boat.Coordinates;
            _BoatCount++;
        }
        else
        {
            throw new Exception("Maximum number of boats reached.");
        }
    }
}
