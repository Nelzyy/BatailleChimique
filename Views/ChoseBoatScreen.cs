namespace BatailleChimiqueWinform
{
    public partial class ChoseBoatScreen : Form
    {
        public ChoseBoatScreen()
        {
            InitializeComponent();
            Button[,] ChosenMatrix = new Button[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Button button = new Button();
                    ChosenMatrix[i, j] = button;
                    button.BackColor = Color.FromArgb(30, 30, 30);
                    button.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
                    button.FlatAppearance.BorderSize = 1;
                    button.FlatStyle = FlatStyle.Popup;
                    button.ForeColor = Color.White;
                    button.Location = new Point(, );
                    button.Size = new Size(50, 50);
                    button.Text = "";
                    button.UseVisualStyleBackColor = false;
                    Controls.Add(ChosenMatrix[i, j]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }

}
