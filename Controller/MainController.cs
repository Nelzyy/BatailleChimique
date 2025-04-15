namespace BatailleChimiqueWinform.Controller;

using System.Windows.Forms;
using BatailleChimiqueWinform.Models;

public class MainController
{
    private ChoseBoatScreen _ChoseBoatScreen;
    private Game _Game;
    private BoatPlacementPaquet _Paquet;
    private bool _ExtremityMode;
    private bool _IsVerticalPlacement;
    private int _NbRotate;
    public MainController()
    {
        this._ChoseBoatScreen = new(this);
        this._Game = new();
        this._Paquet = new();
        this._ExtremityMode = true;
        this._IsVerticalPlacement = true;
        this._NbRotate = 0;
    }
    public void ShowChoseBoatScreen()
    {
        Application.EnableVisualStyles();
        Application.Run(this._ChoseBoatScreen);
    }

    public void ChoseBoatSize(int boatSizeChosen)
    {
        if (_Paquet.GetIsSizeChose())
        {
            _Paquet.ClearSize();
            return;
        }
        switch (boatSizeChosen)
        {
            case 2:
                _Paquet.Size = SizeBoat.tiny;
                break;
            case 3:
                _Paquet.Size = SizeBoat.tinyMiddle;
                break;
            case 4:
                _Paquet.Size = SizeBoat.bigMiddle;
                break;
            case 5:
                _Paquet.Size = SizeBoat.big;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
    public void ChoseBoatType(string boatTypeChosen)
    {
        if (_Paquet.GetIsTypeChose())
        {
            _Paquet.ClearMaterialType();
            return;
        }
        switch (boatTypeChosen)
        {
            case "Cuivrassé":
                _Paquet.MaterialType = MaterialType.Cuivre;
                break;
            case "Ferox":
                _Paquet.MaterialType = MaterialType.Fer;
                break;
            case "Zinctor":
                _Paquet.MaterialType = MaterialType.Zinc;
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
        if (_Paquet.GetHeadChose())
        {
            UpdatePreviewBoatCoordinate();
        }
    }


    public void ClearPaquet()
    {
        _Paquet.Clear();
    }


    public void ChoseCase(Coordinate coord)
    {
        if (!_Paquet.GetIsTypeChose() || !_Paquet.GetIsSizeChose())
        {
            MessageBox.Show("Veuillez choisir le type et la taille du bateau avant de le placer.");
            return;
        }
        _Paquet.Head = coord;
        UpdatePreviewBoatCoordinate();
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
        return coordinates;
    }

    private void DoRoate3(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_Paquet.Head.X, _Paquet.Head.Y + Index));
        }
    }

    private void DoRotate2(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_Paquet.Head.X - Index, _Paquet.Head.Y));
        }
    }

    private void DoRotate1(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_Paquet.Head.X, _Paquet.Head.Y - Index));
        }
    }

    private void DoRotate0(List<Coordinate> coordinates, int size)
    {
        for (int Index = 0; Index < size; Index++)
        {
            coordinates.Add(new Coordinate(_Paquet.Head.X + Index, _Paquet.Head.Y));
        }
    }

    private void GetHorizontalMiddle(List<Coordinate> coordinates, int size)
    {
        for (int Index = -(size / 2); Index < Math.Ceiling((float)size / 2); Index++)
        {
            coordinates.Add(new Coordinate(_Paquet.Head.X + Index, _Paquet.Head.Y));
        }
    }

    private void GetVerticalMiddle(List<Coordinate> coordinates, int size)
    {
        for (int Index = -(size / 2); Index < Math.Ceiling((float)size / 2); Index++)
        {
            coordinates.Add(new Coordinate(_Paquet.Head.X, _Paquet.Head.Y + Index));
        }
    }

    private int GetSize()
    {
        switch (_Paquet.Size)
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

    public bool GetCanChose()
    {
        return _Paquet.GetIsTypeChose() && _Paquet.GetIsSizeChose();
    }

    public bool GetSizeChose()
    {
        return _Paquet.GetIsSizeChose();
    }

    public bool GetTypeChose()
    {
        return _Paquet.GetIsTypeChose();
    }
}
