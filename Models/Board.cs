using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;

class Board
{
    public const int _BoatMax = 5;
    public const int _BoardSize = 8;
    private CaseBoard[,] _Board;
    private Bateau[] _Bateaux;
    private List<Coordinate>[] _BoatCoordinate;
    private int _BoatCount;

    public Board()
    {
        _Board = new CaseBoard[_BoardSize, _BoardSize];
        _Bateaux = new Bateau[_BoatMax];
        _BoatCoordinate = new List<Coordinate>[_BoatMax];
    }

    public int BoatCount
    {
        get => _BoatCount;
    }

    public void AddBoat(Bateau boat)
    {
        if (_BoatCount <= _BoatMax)
        {
            _Bateaux[_BoatCount] = boat;
            _BoatCoordinate[_BoatCount] = boat.Coordinates;
            _BoatCount++;
            foreach (Coordinate coord in boat.Coordinates)
            {
                CaseBoard currentCase = GetCase(coord.X, coord.Y);
                currentCase.AddBoat(boat);
            }
        }
        else
        {
            throw new Exception("Maximum number of boats reached.");
        }
    }

    public bool IsCoordinatesValid(List<Coordinate> coords)
    {
        foreach (Coordinate coord in coords)
        {
            bool isValid = true;
            isValid = (coord.X >= 0 && coord.X < _BoardSize && coord.Y >= 0 && coord.Y < _BoardSize);
            isValid &= _Board[coord.Y, coord.X].IsEmpty;
            if (!isValid)
            {
                return false;
            }
        }
        return true;
    }

    public void InitBoard()
    {
        for (int rowIndex = 0; rowIndex < _BoardSize; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < _BoardSize; columnIndex++)
            {
                _Board[rowIndex, columnIndex] = new CaseBoard(new Coordinate(columnIndex, rowIndex));
            }
        }
    }

    public CaseBoard GetCase(int x, int y)
    {
        if (x < 0 || x >= _BoardSize || y < 0 || y >= _BoardSize)
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds.");
        }
        return _Board[y, x];
    }


}
