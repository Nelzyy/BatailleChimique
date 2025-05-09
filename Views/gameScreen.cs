using BatailleChimiqueWinform.Controller;
using BatailleChimiqueWinform.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatailleChimiqueWinform.Views
{
    public partial class gameScreen : Form
    {
        private const int GridSize = 8;
        private Button[,] _PersonnelMatrix;
        private Button[,] _OppennentMatrix;

        private MainController _Controller;
        private bool _IsTypeChose;
        private MaterialType? _type;
        public gameScreen(MainController controller)
        {
            InitializeComponent();
            _Controller = controller;
            _PersonnelMatrix = new Button[GridSize, GridSize];
            _OppennentMatrix = new Button[GridSize, GridSize];
            _IsTypeChose = false;
            _type = null;
            GenerateGrid(PersonalArea, _PersonnelMatrix);

            LoadBoatsOnGrid(_Controller.GetPaquetPlaced());

            GenerateGrid(OppenentArea, _OppennentMatrix);
            SetPlayerTurnMessage();
            UpdateLabel.Visible = true;

            if (!_Controller.GetPlayerTurn())
            {
                _Controller.Listen();
            }
        }

        public void SetPlayerTurnMessage()
        {
            UpdateLabel.Text = _Controller.GetPlayerTurn() ? "Ton tour" : "Tour de l'enemie";
        }

        private async void GridButton_Click(object sender, EventArgs e)
        {
            if (!_Controller.GetPlayerTurn())
            {
                return;
            }
            Button clickedButton = (Button)sender;
            int x, y;
            GetButtonCoordinate(clickedButton, out x, out y);
            Coordinate target = new Coordinate(x, y);
            if (clickedButton.Parent == PersonalArea)
            {
                ChoseAttackType(target);
            }
            if (clickedButton.Parent == OppenentArea)
            {
                if (_IsTypeChose)
                {
                    await ProcessAttack(clickedButton, target);
                }
            }
        }

        private void ChoseAttackType(Coordinate target)
        {
            if (_type == null)
            {
                if (_Controller.IsBoatAt(target))
                {
                    _type = _Controller.GetBoatType(target);
                    _IsTypeChose = true;

                    _PersonnelMatrix[target.X, target.Y].BackColor = Color.White;
                }
            }
            else
            {
                _type = null;
                _IsTypeChose = false;

                LoadBoatsOnGrid(_Controller.GetPaquetPlaced());
            }
        }

        private async Task ProcessAttack(Button clickedButton, Coordinate target)
        {
            bool hit = await _Controller.HandleAttack(target);

            if (hit)
            {
                clickedButton.BackColor = Color.Red;
            }
            else
            {
                clickedButton.BackColor = Color.FromArgb(200, 200, 200);
            }
            clickedButton.Enabled = false;
            await _Controller.EndTurn();
            SetPlayerTurnMessage();
        }

        public void GenerateGrid(Panel panel, Button[,] Matrix)
        {
            SuspendLayout();
            for (int Yindex = 0; Yindex < GridSize; Yindex++)
            {
                for (int Xindex = 0; Xindex < GridSize; Xindex++)
                {
                    Button button = new Button();
                    Matrix[Yindex, Xindex] = button;
                    button.BackColor = Color.FromArgb(30, 30, 30);

                    button.FlatStyle = FlatStyle.Flat;
                    button.Size = new Size(50, 50);
                    button.Location = new Point(100 + Xindex * 50, 100 + Yindex * 50);
                    button.Text = "";
                    panel.Controls.Add(button);
                    button.Click += GridButton_Click;
                }

            }
            ResumeLayout();
        }

        public void LoadBoatsOnGrid(List<BoatPlacementPaquet> boats)
        {
            for (int rowIndex = 0; rowIndex < GridSize; rowIndex++)
            {
                for (int collumIdex = 0; collumIdex < GridSize; collumIdex++)
                {
                    Coordinate coord = new(rowIndex, collumIdex);
                    Color color;
                    if (_Controller.IsBoatAt(coord))
                    {
                        Bateau boat = _Controller.GetBoatAt(coord);
                        switch (boat.Type)
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
                                color = Color.Gray;
                                break;
                        }
                    }
                    else if (_Controller.IsHitAt(coord))
                    {
                        color = Color.Red;
                    }
                    else
                    {
                        if (_PersonnelMatrix[rowIndex, collumIdex].BackColor == Color.White)
                        {
                            continue;
                        }
                        color = Color.FromArgb(30, 30, 30);
                    }
                    _PersonnelMatrix[rowIndex, collumIdex].BackColor = color;
                }
            }
        }
        private void GetButtonCoordinate(Button button, out int x, out int y)
        {
            x = (button.Location.Y / 50) - 2;
            y = (button.Location.X / 50) - 2;
        }

    }
}
