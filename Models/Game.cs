using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;

class Game
{
    private Player _Player;
    private bool _IsPlayer1Turn;

    public Game()
    {
        _Player = new Player();
        _IsPlayer1Turn = true;
    }

    public bool IsMyTurn
    {
        get => _IsPlayer1Turn;
    }
    public void SwitchTurn()
    {
        _IsPlayer1Turn = !_IsPlayer1Turn;
    }

}
