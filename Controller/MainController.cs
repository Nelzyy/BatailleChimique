namespace BatailleChimiqueWinform.Controller;

using System.Windows.Forms;
using BatailleChimiqueWinform.Models;

public class MainController
{
    private ChoseBoatScreen _ChoseBoatScreen;
    private Game _Game;
    private BoatPlacementPaquet _CurrentPaquet;
    private bool _ExtremityMode;
    private bool _IsVerticalPlacement;
    private int _NbRotate;
    private List<BoatPlacementPaquet> _PaquetPlaced;
    public MainController()
    {
        this._ChoseBoatScreen = new(this);
        this._Game = new();
        this._CurrentPaquet = new();
        this._ExtremityMode = true;
        this._IsVerticalPlacement = true;
        this._NbRotate = 0;
        this._PaquetPlaced = new();
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
        if (!_CurrentPaquet.GetIsTypeChose() || !_CurrentPaquet.GetIsSizeChose())
        {
            MessageBox.Show("Veuillez choisir le type et la taille du bateau avant de le placer.");
            return;
        }
        _CurrentPaquet.Head = coord;
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
    }

    public void ShowGrid()
    {
        _ChoseBoatScreen.ShowGrid(_PaquetPlaced);
    }
}
