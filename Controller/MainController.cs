namespace BatailleChimiqueWinform.Controller;

using System.Windows.Forms;
using BatailleChimiqueWinform.Models;
using BatailleChimiqueWinform.Views;
using Socket_client;

public class MainController : ChoseBoatScreen.Ilistener
{
    private gameScreen _gameScreen;
    private ChoseBoatScreen _ChoseBoatScreen;
    private Player _Player;
    private BoatPlacementPaquet _CurrentPaquet;
    private bool _ExtremityMode;
    private bool _IsVerticalPlacement;
    private int _NbRotate;
    private List<BoatPlacementPaquet> _PaquetPlaced;
    private bool _DeletePaquet;
    private List<int> _IdDisable;
    private Client _Client;
    private IpAsk _IpAskScreen;
    private bool _IsConnected;
    public MainController()
    {
        this._ChoseBoatScreen = new(this);
        this._Player = new();
        this._CurrentPaquet = new();
        this._ExtremityMode = true;
        this._IsVerticalPlacement = true;
        this._NbRotate = 0;
        this._PaquetPlaced = new();
        this._IdDisable = new();
        this._Client = new(this);
        this._IpAskScreen = new(this);
        this._IsConnected = false;
    }

    #region code ethanol

    public bool GetIsConnected()
    {
        return _IsConnected;
    }
    public async Task LaunchCLientAsync()
    {
        _IpAskScreen.ShowDialog();

    }
    public void ShowChoseBoatScreen()
    {
        Application.EnableVisualStyles();
        Application.Run(this._ChoseBoatScreen);
    }

    public void ChoseBoatSize(int boatSizeChosen)
    {
        if (_CurrentPaquet.GetIsSizeChose())
        {
            _CurrentPaquet.ClearSize();
            return;
        }
        switch (boatSizeChosen)
        {
            case 2:
                _CurrentPaquet.Size = SizeBoat.tiny;
                break;
            case 3:
                _CurrentPaquet.Size = SizeBoat.tinyMiddle;
                break;
            case 4:
                _CurrentPaquet.Size = SizeBoat.bigMiddle;
                break;
            case 5:
                _CurrentPaquet.Size = SizeBoat.big;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    public void ChoseBoatType(string boatTypeChosen)
    {
        if (_CurrentPaquet.GetIsTypeChose())
        {
            _CurrentPaquet.ClearMaterialType();
            return;
        }
        switch (boatTypeChosen)
        {
            case "Cuivrassé":
                _CurrentPaquet.MaterialType = MaterialType.Cuivre;
                break;
            case "Ferox":
                _CurrentPaquet.MaterialType = MaterialType.Fer;
                break;
            case "Zinctor":
                _CurrentPaquet.MaterialType = MaterialType.Zinc;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public void ChoseBoatOrientation(string text)
    {
        _ExtremityMode = text == "Extrémité";
        CheckAndRotate();
    }

    public void RotateBoatPreview()
    {
        _IsVerticalPlacement = !_IsVerticalPlacement;
        _NbRotate = (_NbRotate + 1) % 4;
        CheckAndRotate();
    }

    private void CheckAndRotate()
    {
        if (_CurrentPaquet.GetHeadChose() && GetCanPlaced())
        {
            UpdatePreviewBoatCoordinate();
        }
    }


    public void ClearPaquet()
    {
        _CurrentPaquet.Clear();
    }


    public void ChoseCase(Coordinate coord)
    {
        if (_DeletePaquet)
        {
            FindAndDeleteGoodPaquet(coord);
            return;
        }
        if (!_CurrentPaquet.GetIsTypeChose() || !_CurrentPaquet.GetIsSizeChose())
        {
            MessageBox.Show("Veuillez choisir le type et la taille du bateau avant de le placer.");
            return;
        }
        _CurrentPaquet.Head = coord;
        UpdatePreviewBoatCoordinate();
    }

    private void FindAndDeleteGoodPaquet(Coordinate coordSelect)
    {
        foreach (BoatPlacementPaquet paquet in _PaquetPlaced)
        {
            foreach (Coordinate coord in paquet.Coordinates)
            {
                if (coord == coordSelect)
                {
                    _DeletePaquet = false;
                    _PaquetPlaced.Remove(paquet);
                    ShowGrid();
                    enableButtonID(paquet.IdTemp);
                    _ChoseBoatScreen.UpdateNbBoatPlacedLabel(_PaquetPlaced.Count);
                    _ChoseBoatScreen.Clean();
                    return;
                }
            }
        }
    }

    private void UpdatePreviewBoatCoordinate()
    {
        List<Coordinate> CoordinatesCalculated = GetOtherCoordinate();
        _ChoseBoatScreen.UpdateGrid(CoordinatesCalculated);
    }

    private List<Coordinate> GetOtherCoordinate()
    {
        List<Coordinate> coordinates = new();
        int size = GetSize();
        if (!_ExtremityMode)
        {
            if (_IsVerticalPlacement)
            {
                GetVerticalMiddle(coordinates, size);
            }
            else
            {
                GetHorizontalMiddle(coordinates, size);
            }
        }
        else
        {
            switch (_NbRotate)
            {
                case 0:
                    DoRotate0(coordinates, size);
                    break;
                case 1:
                    DoRotate1(coordinates, size);
                    break;
                case 2:
                    DoRotate2(coordinates, size);
                    break;
                case 3:
                    DoRoate3(coordinates, size);
                    break;
            }
        }
        _CurrentPaquet.Coordinates = coordinates;
        return coordinates;
    }

    private void DoRoate3(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_CurrentPaquet.Head.X, _CurrentPaquet.Head.Y + Index));
        }
    }

    private void DoRotate2(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_CurrentPaquet.Head.X - Index, _CurrentPaquet.Head.Y));
        }
    }

    private void DoRotate1(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_CurrentPaquet.Head.X, _CurrentPaquet.Head.Y - Index));
        }
    }

    private void DoRotate0(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_CurrentPaquet.Head.X + Index, _CurrentPaquet.Head.Y));
        }
    }

    private void GetHorizontalMiddle(List<Coordinate> coordinates, int size)
    {
        for (int Index = -(size / 2); Index < Math.Ceiling((float)size / 2); Index++)
        {
            coordinates.Add(new Coordinate(_CurrentPaquet.Head.X + Index, _CurrentPaquet.Head.Y));
        }
    }

    private void GetVerticalMiddle(List<Coordinate> coordinates, int size)
    {
        for (int Index = -(size / 2); Index < Math.Ceiling((float)size / 2); Index++)
        {
            coordinates.Add(new Coordinate(_CurrentPaquet.Head.X, _CurrentPaquet.Head.Y + Index));
        }
    }

    private int GetSize()
    {
        switch (_CurrentPaquet.Size)
        {
            case SizeBoat.tiny:
                return 2;
            case SizeBoat.tinyMiddle:
                return 3;
            case SizeBoat.bigMiddle:
                return 4;
            case SizeBoat.big:
                return 5;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public bool GetIsPreviewPlaced()
    {
        return _CurrentPaquet.GetIsPlacementValid(_PaquetPlaced);
    }
    public bool GetCanPlaced()
    {
        return GetTypeChose() && GetSizeChose();
    }

    public bool GetSizeChose()
    {
        return _CurrentPaquet.GetIsSizeChose();
    }

    public bool GetTypeChose()
    {
        return _CurrentPaquet.GetIsTypeChose();
    }

    public void ValidateBoatPlacement(int id)
    {
        _CurrentPaquet.IdBoat = _PaquetPlaced.Count + 1;
        _CurrentPaquet.IdTemp = id;
        if (_CurrentPaquet.CanBeUsed())
        {
            if (_CurrentPaquet.GetIsPlacementValid(_PaquetPlaced))
            {
                _PaquetPlaced.Add(_CurrentPaquet);
                _CurrentPaquet = new();
            }
            else
            {
                MessageBox.Show("Placement impossible");
            }
        }
        else
        {
            MessageBox.Show("Veuillez choisir le type, la taille et l'extrémité du bateau avant de le placer.");
        }
        ShowGrid();
        _ChoseBoatScreen.Clean();
        _ChoseBoatScreen.DisableSizeButtonById(id);
        _ChoseBoatScreen.UpdateNbBoatPlacedLabel(_PaquetPlaced.Count);
        _IdDisable.Add(id);
    }

    public void ShowGrid()
    {
        _ChoseBoatScreen.ShowGrid(_PaquetPlaced);
    }

    public void SetDelete()
    {
        if (_PaquetPlaced.Count <= 0)
        {
            return;
        }
        _DeletePaquet = true;
        this._ChoseBoatScreen.SayDeleteUp();
    }

    private void enableButtonID(int id)
    {
        this._ChoseBoatScreen.EnableSizeButton(id);
    }

    public void SetValidate()
    {
        foreach (BoatPlacementPaquet paquet in _PaquetPlaced)
        {
            _Player.FillBoat(paquet);
        }
        this._ChoseBoatScreen.SayReady();
        this._ChoseBoatScreen.Hide();
        this._gameScreen = new(this);
        this._gameScreen.Show();
    }

    public async Task SetIp(byte[] ipAddressByte)
    {
        _IpAskScreen.Close();
        await _Client.Start(ipAddressByte);
        _IsConnected = true;
        _Player.IsTurn = _Client.GetWriteMode();
    }

    #endregion

    #region code laiton
    public async Task<bool> HandleAttack(Coordinate target)
    {
        string result = await _Client.sendAttack(target);
        return bool.Parse(result);
    }

    public bool IsBoatAt(Coordinate coord)
    {
        Board myBoard = _Player.PlayerBoard;
        CaseBoard targetedCase = myBoard.GetCase(coord.X, coord.Y);
        if (!targetedCase.IsEmpty)
        {
            return true;
        }
        return false;
    }

    public bool GetPlayerTurn()
    {
        return _Player.IsTurn;
    }

    public async Task EndTurn()
    {
        if (_gameScreen.CheckWin())
        {
            MessageBox.Show("Vous avez gagné !");
            await _Client.SendEnd();
            EndGame();
        }
        await _Client.EndTurn();
        _Player.SwapTurn();
        Task.Run(() => _Client.Listen());

    }

    public MaterialType GetBoatType(Coordinate coord)
    {
        Board myBoard = _Player.PlayerBoard;
        CaseBoard targetedCase = myBoard.GetCase(coord.X, coord.Y);
        if (!targetedCase.IsEmpty)
        {
            return targetedCase.GetBoatType();
        }
        throw new Exception("No boat in this case.");
    }

    public void SwapTurn()
    {
        _Player.SwapTurn();
    }

    public async Task Listen()
    {
        Task.Run(() => _Client.Listen());
    }

    public void SetPlayerTurnMessage()
    {
        if (_gameScreen != null)
        {
            _gameScreen.SetPlayerTurnMessage();
        }
    }

    public List<BoatPlacementPaquet> GetPaquetPlaced()
    {
        return _PaquetPlaced;
    }

    public void TakeDamage(Coordinate coor)
    {
        Board myBoard = _Player.PlayerBoard;
        CaseBoard targetedCase = myBoard.GetCase(coor.X, coor.Y);
        targetedCase.TakeDamage();
        _gameScreen.LoadBoatsOnGrid(_PaquetPlaced);
    }

    public Bateau GetBoatAt(Coordinate coord)
    {
        return _Player.PlayerBoard.GetCase(coord.X, coord.Y).GetBoat()!;
    }

    public bool IsHitAt(Coordinate coord)
    {
        Board myBoard = _Player.PlayerBoard;
        CaseBoard targetedCase = myBoard.GetCase(coord.X, coord.Y);
        if (targetedCase.IsHit)
        {
            return true;
        }
        return false;
    }

    public void EndGame()
    {
        _Client.Disconnect();
        _IpAskScreen.Close();
        _ChoseBoatScreen.Close();
        Application.Exit();
    }

    #endregion



}
