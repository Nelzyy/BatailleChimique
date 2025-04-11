namespace BatailleChimiqueWinform.Controller;
using BatailleChimiqueWinform.Models;

public class MainController
{
    private ChoseBoatScreen _ChoseBoatScreen;
    private Game _Game;
    public MainController()
    {
        this._ChoseBoatScreen = new();
        this._Game = new();
    }
    public void ShowChoseBoatScreen()
    {
        Application.EnableVisualStyles();
        Application.Run(this._ChoseBoatScreen);
    }
}
