using BatailleChimiqueWinform.Controller;
using BatailleChimiqueWinform.Models;
namespace BatailleChimiqueWinform;

public partial class ChoseBoatScreen : Form
{
    private const int GridSize = 8;
    private MainController _Controller;
    private Button[,] _ChosenMatrix;

    public ChoseBoatScreen(MainController controller)
    {
        _Controller = controller;
        InitializeComponent();
        _ChosenMatrix = new Button[GridSize, GridSize];
        InitializeBoard();
    }

    private void ChoseSizeBoat_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string text = button.Text;
        int TypeChoseInt = int.Parse(text[0].ToString());

        if (this._Controller.GetSizeChose())
        {
            CleanEditPreviewButton();
            this._Controller.ShowGrid();
        }
        else
        {
            button.BackColor = Color.FromArgb(70, 70, 70);
        }
        this._Controller.ChoseBoatSize(TypeChoseInt);

    }
    private void ChoseTypeBoat_Click(object sender, EventArgs e)
    {
        Panel panel = (Panel)sender;
        string text = "";
        if (_Controller.GetTypeChose())
        {
            CleanChoseTypePanel();
            this._Controller.ShowGrid();
        }
        else
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label label)
                {
                    if (label.Font.Size == 14)
                    {
                        panel.BackColor = Color.FromArgb(70, 70, 70);
                        text = control.Text;
                    }
                }
            }
        }
        this._Controller.ChoseBoatType(text);

    }

    private void CleanEditPreviewButton()
    {
        foreach (Control control in MainPanel.Controls)
        {
            if (control.TabIndex >= 5 && control.TabIndex <= 9)
            {
                control.BackColor = Color.FromArgb(30, 30, 30);
            }
        }
    }

    private void PreviewModeButton_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (button.Text == "Extrémité")
        {
            button.Text = "Milieu";
        }
        else
        {
            button.Text = "Extrémité";
        }

        this._Controller.ChoseBoatOrientation(button.Text);
    }

    private void RotateButton_Click(object sender, EventArgs e)
    {
        this._Controller.RotateBoatPreview();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        this._Controller.ClearPaquet();
        Clean();
        this._Controller.ShowGrid();
    }


    private void CleanChoseTypePanel()
    {
        foreach (Control control in MainPanel.Controls)
        {
            if (control is Panel panelSelect)
            {
                if (panelSelect.TabIndex <= 12 || panelSelect.TabIndex >= 10)
                {
                    panelSelect.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }
    }

    private static void PutColorInCase(int YIndex, int XIndex, Button button)
    {
        Color color = (YIndex + XIndex) % 2 == 0 ? Color.FromArgb(50, 50, 50) : Color.FromArgb(70, 70, 70);
        button.BackColor = color;
    }

    private void ChoseCase_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        int x, y;
        GetButtonCoordinate(button, out x, out y);
        Coordinate coordinate = new Coordinate(x, y);
        _Controller.ChoseCase(coordinate);
    }

    private static void GetButtonCoordinate(Button button, out int x, out int y)
    {
        x = (button.Location.Y - 50) / 50;
        y = (button.Location.X - 50) / 50;
    }

    public void UpdateGrid(List<Coordinate> coordinatesCalculated)
    {
        this._Controller.ShowGrid();
        bool valid = this._Controller.GetIsPreviewPlaced();

        Color color = Color.FromArgb(120, 120, 120);

        if (!valid)
        {
            color = Color.FromArgb(247, 73, 73);
        }

        foreach (Coordinate coordinate in coordinatesCalculated)
        {
            int x = coordinate.X;
            int y = coordinate.Y;
            if (x < 0 || x >= GridSize || y < 0 || y >= GridSize ||
                (_ChosenMatrix[x, y].BackColor != Color.FromArgb(50, 50, 50) &&
                _ChosenMatrix[x, y].BackColor != Color.FromArgb(70, 70, 70)))
            {
                continue;
            }
            Button button = _ChosenMatrix[x, y];
            button.BackColor = color;
        }
    }

    private void CleanGrid()
    {
        for (int YCoordinate = 0; YCoordinate < GridSize; YCoordinate++)
        {
            for (int XCoordinate = 0; XCoordinate < GridSize; XCoordinate++)
            {
                Button button = _ChosenMatrix[YCoordinate, XCoordinate];
                PutColorInCase(YCoordinate, XCoordinate, button);
            }
        }
    }

    private void ValidateButton_Click(object sender, EventArgs e)
    {
        if (!this._Controller.GetIsPreviewPlaced())
        {
            return;
        }
        if (NbBoatPlacedLabel.Text == "Nombre de bateau placé : 5")
        {
            this._Controller.SetValidate();
            return;
        }
        int id = 0;
        foreach (Control control in MainPanel.Controls)
        {
            if (control.BackColor == Color.FromArgb(70, 70, 70))
            {
                id = control.TabIndex;
                this._Controller.ValidateBoatPlacement(id);
                break;
            }
        }
    }

    public void UpdateNbBoatPlacedLabel(int nbBoatPlaced)
    {
        NbBoatPlacedLabel.Text = "Nombre de bateau placé : " + nbBoatPlaced;
        if (nbBoatPlaced == 5)
        {
            ValidateButton.Text = "Valider la selection";
        }
        else
        {
            ValidateButton.Text = "Valider";
        }
    }

    private void InitializeBoard()
    {
        SuspendLayout();
        for (int YIndex = 0; YIndex < GridSize; YIndex++)
        {
            for (int XIndex = 0; XIndex < GridSize; XIndex++)
            {
                Button button = new Button();
                _ChosenMatrix[YIndex, XIndex] = button;
                PutColorInCase(YIndex, XIndex, button);
                button.FlatAppearance.BorderColor = Color.Black;
                button.FlatAppearance.BorderSize = 2;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White;
                button.Location = new Point(50 + (50 * XIndex), 50 + (50 * YIndex));
                button.Size = new Size(50, 50);
                button.Text = "";
                button.UseVisualStyleBackColor = false;
                button.Click += ChoseCase_Click;
                TabPanel.Controls.Add(button);
            }
        }
        ResumeLayout();
    }

    public void ShowGrid(List<BoatPlacementPaquet> paquetPlaced)
    {
        CleanGrid();
        foreach (BoatPlacementPaquet paquet in paquetPlaced)
        {
            Color color;
            switch (paquet.MaterialType)
            {
                case MaterialType.Zinc:
                    color = Color.FromArgb(73, 226, 247);
                    break;
                case MaterialType.Cuivre:
                    color = Color.FromArgb(247, 237, 73);
                    break;
                case MaterialType.Fer:
                    color = Color.FromArgb(73, 247, 97);
                    break;
                default:
                    color = Color.FromArgb(120, 120, 120);
                    break;
            }
            foreach (Coordinate coordinate in paquet.Coordinates)
            {
                Button button = _ChosenMatrix[coordinate.X, coordinate.Y];
                button.BackColor = color;
            }
        }
    }

    public void Clean()
    {
        CleanChoseTypePanel();
        CleanEditPreviewButton();
    }

    public void DisableSizeButtonById(int id)
    {
        Button button = GetButtonSizeById(id);
        button.Enabled = false;
    }

    public void DeleteButton_Click(object sender, EventArgs e)
    {
        this._Controller.SetDelete();
    }

    public void SayDeleteUp()
    {
        MessageBox.Show("Veuillez choisir un bateau à supprimer.");
    }

    public void EnableSizeButton(int id)
    {
        Button button = GetButtonSizeById(id);
        button.Enabled = true;
    }

    private Button GetButtonSizeById(int id)
    {
        foreach (Control control in MainPanel.Controls)
        {
            if (control is Button button && button.TabIndex == id)
            {
                return button;
            }
        }
        throw new InvalidOperationException("Cant get a button with this id");
    }

    public void SayReady()
    {
        ReadyLabel.Visible = true;
        foreach (Control control in MainPanel.Controls)
        {
            control.Enabled = false;
        }
    }

    private void ConnectClientButton_Click(object sender, EventArgs e)
    {
        this._Controller.LaunchCLientAsync();
    }
}
