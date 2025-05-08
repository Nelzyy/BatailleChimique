using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;

class Player
{
    private Board _PlayerBoard;
    private Board _OpponentBoard;
    private bool _IsTurn;

    public Player()
    {
        _PlayerBoard = new Board();
        _OpponentBoard = new Board();
        _PlayerBoard.InitBoard();
        _OpponentBoard.InitBoard();
        _IsTurn = false;
    }

    public Board PlayerBoard
    {
        get => _PlayerBoard;
    }

    public Board OpponentBoard
    {
        get => _OpponentBoard;
    }

    public bool IsTurn
    {
        get => _IsTurn;
        set => _IsTurn = value;
    }

    public void SwapTurn()
    {
        _IsTurn = !_IsTurn;
    }

    public void FillBoat(BoatPlacementPaquet paquet)
    {
        if (_PlayerBoard.BoatCount < Board._BoatMax)
        {
            Bateau boat = paquet.MaterialType switch
            {
                MaterialType.Cuivre => new Cuivrassé(paquet.IdBoat, paquet.Size, paquet.Head, paquet.Coordinates),
                MaterialType.Fer => new Ferox(paquet.IdBoat, paquet.Size, paquet.Head, paquet.Coordinates),
                MaterialType.Zinc => new Zinctor(paquet.IdBoat, paquet.Size, paquet.Head, paquet.Coordinates),
                _ => throw new ArgumentException("Invalid boat type.")
            };
            _PlayerBoard.AddBoat(boat);
        }
        else
        {
            throw new Exception("Maximum number of boats reached.");
        }
    }



    public int GetNumberOfBoat()
    {
        return _PlayerBoard.BoatCount;
    }

}
