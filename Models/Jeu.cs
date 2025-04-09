using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleChimiqueWinform.Models;

class Jeu
{
    Board[] boards;

    Jeu()
    {
        boards = new Board[4];
        for (int i = 0; i < 2; i++)
        {
            boards[i] = new Board();
        }
    }
}
