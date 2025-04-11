using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatailleChimiqueWinform.Controller;

namespace BatailleChimiqueWinform
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MainController mainController = new();
            mainController.ShowChoseBoatScreen();
        }
    }
}
