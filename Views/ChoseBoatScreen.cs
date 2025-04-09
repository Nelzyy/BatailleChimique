namespace BatailleChimiqueWinform
{
    public partial class ChoseBoatScreen : Form
    {
        public ChoseBoatScreen()
        {
            InitializeComponent();
            Button[,] ChosenMatrix = new Button[8, 8];
            InitializeBoard(ChosenMatrix);
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

}
