using BatailleChimiqueWinform.Controller;
using BatailleChimiqueWinform.Models;
namespace BatailleChimiqueWinform;

public partial class ChoseBoatScreen : Form
{
    private MainController _Controller;
    public ChoseBoatScreen(MainController controller)
    {
        _Controller = controller;
        InitializeComponent();
        Button[,] ChosenMatrix = new Button[8, 8];
        InitializeBoard(ChosenMatrix);
    }

    private void ChoseTypeBoat_Click(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        SizeBoat typeChose;
        string text = button.Text;
        int TypeChoseInt = int.Parse(text[0].ToString());
        switch (TypeChoseInt)
        {
            case 2:
                typeChose = SizeBoat.tiny;
                break;
            case 3:
                typeChose = SizeBoat.tinyMiddle;
                break;
            case 4:
                typeChose = SizeBoat.bigMiddle;
                break;
            case 5:
                typeChose = SizeBoat.big;
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }

    }

    private void InitializeBoard(Button[,] ChosenMatrix)
    {
        SuspendLayout();
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Color color = (i + j) % 2 == 0 ? Color.FromArgb(50, 50, 50) : Color.FromArgb(70, 70, 70);
                Button button = new Button();
                ChosenMatrix[i, j] = button;
                button.BackColor = color;
                button.FlatAppearance.BorderColor = Color.Black;
                button.FlatAppearance.BorderSize = 2;
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.White;
                button.Location = new Point(50 + (50 * j), 50 + (50 * i));
                button.Size = new Size(50, 50);
                button.Text = "";
                button.UseVisualStyleBackColor = false;
                TabPanel.Controls.Add(button);
            }
        }
        ResumeLayout();
    }

}
