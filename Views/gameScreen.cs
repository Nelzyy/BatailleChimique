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
        public gameScreen(MainController controller)
        {
            InitializeComponent();
            _Controller = controller;
            _PersonnelMatrix = new Button[GridSize, GridSize];
            _OppennentMatrix = new Button[GridSize, GridSize];
            GenerateGrid(PersonalArea, _PersonnelMatrix);
            GenerateGrid(OppenentArea, _OppennentMatrix);
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x, y;
            GetButtonCoordinate(clickedButton, out x, out y);
            Coordinate target = new Coordinate(x, y);
            bool hit = _Controller.HandleAttack(target);

            if (hit)
            {
                clickedButton.BackColor = Color.Red;
            }
            else
            {
                clickedButton.BackColor = Color.FromArgb(200, 200, 200);
            }
            clickedButton.Enabled = false;
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
                    button.Location = new Point(100+Xindex * 50, 100+Yindex * 50);
                    button.Text = "";
                    panel.Controls.Add(button);
                    button.Click += GridButton_Click;

                }

            }
            ResumeLayout();
        }

        public void LoadBoatsOnGrid(List<BoatPlacementPaquet> boats)
        {
            foreach (var boat in boats)
            {
                Color color;
                switch (boat.MaterialType)
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

                foreach (var coord in boat.Coordinates)
                {
                    int x = coord.X;
                    int y = coord.Y;

                    if (x >= 0 && x < GridSize && y >= 0 && y < GridSize)
                    {
                        _PersonnelMatrix[x, y].BackColor = color;
                    }
                }
            }
        }
        private void GetButtonCoordinate(Button button, out int x, out int y)
        {
            x = button.Location.Y / 50;
            y = button.Location.X / 50;
        }

    }
}
