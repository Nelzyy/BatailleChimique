namespace BatailleChimiqueWinform
{
    partial class ChoseBoatScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>  
        private void InitializeComponent()
        {
            TitlePanel = new Panel();
            TitleLabel = new Label();
            TabPanel = new Panel();
            MainPanel = new Panel();
            FiveCaseButton = new Button();
            FourCaseButton = new Button();
            ThreeCaseButton2 = new Button();
            ThreeCaseButton1 = new Button();
            TwoCaseButton = new Button();
            CancelButton = new Button();
            RotateButton = new Button();
            PreviewModeButton = new Button();
            ValidateButton = new Button();
            DeleteButton = new Button();
            CuivrasséPanel = new Panel();
            CuivrasséLabel = new Label();
            FeroxPanel = new Panel();
            Ferox = new Label();
            ZinctorPanel = new Panel();
            ZinctorLabel = new Label();
            NbBoatPlacedLabel = new Label();
            LabelZinctor1 = new Label();
            zinctorlabel2 = new Label();
            feroxlabel1 = new Label();
            feroxlabel2 = new Label();
            cuivrassélabel1 = new Label();
            cuivrassélabel2 = new Label();
            TitlePanel.SuspendLayout();
            MainPanel.SuspendLayout();
            CuivrasséPanel.SuspendLayout();
            FeroxPanel.SuspendLayout();
            ZinctorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.BackColor = Color.Transparent;
            TitlePanel.BackgroundImageLayout = ImageLayout.None;
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Margin = new Padding(0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(500, 75);
            TitlePanel.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Snap ITC", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 12);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(449, 42);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Choisisser vos bateaux";
            // 
            // TabPanel
            // 
            TabPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TabPanel.Location = new Point(0, 139);
            TabPanel.Name = "TabPanel";
            TabPanel.Size = new Size(531, 536);
            TabPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            MainPanel.Controls.Add(FiveCaseButton);
            MainPanel.Controls.Add(FourCaseButton);
            MainPanel.Controls.Add(ThreeCaseButton2);
            MainPanel.Controls.Add(ThreeCaseButton1);
            MainPanel.Controls.Add(TwoCaseButton);
            MainPanel.Controls.Add(CancelButton);
            MainPanel.Controls.Add(RotateButton);
            MainPanel.Controls.Add(PreviewModeButton);
            MainPanel.Controls.Add(ValidateButton);
            MainPanel.Controls.Add(DeleteButton);
            MainPanel.Controls.Add(CuivrasséPanel);
            MainPanel.Controls.Add(FeroxPanel);
            MainPanel.Controls.Add(ZinctorPanel);
            MainPanel.Location = new Point(537, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(646, 760);
            MainPanel.TabIndex = 2;
            // 
            // FiveCaseButton
            // 
            FiveCaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FiveCaseButton.BackColor = Color.FromArgb(30, 30, 30);
            FiveCaseButton.FlatAppearance.BorderColor = Color.Black;
            FiveCaseButton.FlatStyle = FlatStyle.Flat;
            FiveCaseButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            FiveCaseButton.ForeColor = Color.White;
            FiveCaseButton.Location = new Point(347, 487);
            FiveCaseButton.Name = "FiveCaseButton";
            FiveCaseButton.Size = new Size(182, 36);
            FiveCaseButton.TabIndex = 9;
            FiveCaseButton.Text = "5 Cases";
            FiveCaseButton.UseVisualStyleBackColor = false;
            FiveCaseButton.Click += ChoseSizeBoat_Click;
            // 
            // FourCaseButton
            // 
            FourCaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FourCaseButton.BackColor = Color.FromArgb(30, 30, 30);
            FourCaseButton.FlatAppearance.BorderColor = Color.Black;
            FourCaseButton.FlatStyle = FlatStyle.Flat;
            FourCaseButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            FourCaseButton.ForeColor = Color.White;
            FourCaseButton.Location = new Point(112, 487);
            FourCaseButton.Name = "FourCaseButton";
            FourCaseButton.Size = new Size(182, 36);
            FourCaseButton.TabIndex = 8;
            FourCaseButton.Text = "4 Cases";
            FourCaseButton.UseVisualStyleBackColor = false;
            FourCaseButton.Click += ChoseSizeBoat_Click;
            // 
            // ThreeCaseButton2
            // 
            ThreeCaseButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ThreeCaseButton2.BackColor = Color.FromArgb(30, 30, 30);
            ThreeCaseButton2.FlatAppearance.BorderColor = Color.Black;
            ThreeCaseButton2.FlatStyle = FlatStyle.Flat;
            ThreeCaseButton2.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            ThreeCaseButton2.ForeColor = Color.White;
            ThreeCaseButton2.Location = new Point(439, 425);
            ThreeCaseButton2.Name = "ThreeCaseButton2";
            ThreeCaseButton2.Size = new Size(182, 36);
            ThreeCaseButton2.TabIndex = 7;
            ThreeCaseButton2.Text = "3 Cases";
            ThreeCaseButton2.UseVisualStyleBackColor = false;
            ThreeCaseButton2.Click += ChoseSizeBoat_Click;
            // 
            // ThreeCaseButton1
            // 
            ThreeCaseButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ThreeCaseButton1.BackColor = Color.FromArgb(30, 30, 30);
            ThreeCaseButton1.FlatAppearance.BorderColor = Color.Black;
            ThreeCaseButton1.FlatStyle = FlatStyle.Flat;
            ThreeCaseButton1.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            ThreeCaseButton1.ForeColor = Color.White;
            ThreeCaseButton1.Location = new Point(232, 425);
            ThreeCaseButton1.Name = "ThreeCaseButton1";
            ThreeCaseButton1.Size = new Size(182, 36);
            ThreeCaseButton1.TabIndex = 6;
            ThreeCaseButton1.Text = "3 Cases";
            ThreeCaseButton1.UseVisualStyleBackColor = false;
            ThreeCaseButton1.Click += ChoseSizeBoat_Click;
            // 
            // TwoCaseButton
            // 
            TwoCaseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TwoCaseButton.BackColor = Color.FromArgb(30, 30, 30);
            TwoCaseButton.FlatAppearance.BorderColor = Color.Black;
            TwoCaseButton.FlatStyle = FlatStyle.Flat;
            TwoCaseButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            TwoCaseButton.ForeColor = Color.White;
            TwoCaseButton.Location = new Point(25, 425);
            TwoCaseButton.Name = "TwoCaseButton";
            TwoCaseButton.Size = new Size(182, 36);
            TwoCaseButton.TabIndex = 5;
            TwoCaseButton.Text = "2 Cases";
            TwoCaseButton.UseVisualStyleBackColor = false;
            TwoCaseButton.Click += ChoseSizeBoat_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.BackColor = Color.FromArgb(30, 30, 30);
            CancelButton.FlatAppearance.BorderColor = Color.Black;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(439, 584);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(182, 36);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Annuler";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // RotateButton
            // 
            RotateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RotateButton.BackColor = Color.FromArgb(30, 30, 30);
            RotateButton.FlatAppearance.BorderColor = Color.Black;
            RotateButton.FlatStyle = FlatStyle.Flat;
            RotateButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            RotateButton.ForeColor = Color.White;
            RotateButton.Location = new Point(232, 584);
            RotateButton.Name = "RotateButton";
            RotateButton.Size = new Size(182, 36);
            RotateButton.TabIndex = 3;
            RotateButton.Text = "Rotation";
            RotateButton.UseVisualStyleBackColor = false;
            RotateButton.Click += RotateButton_Click;
            // 
            // PreviewModeButton
            // 
            PreviewModeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PreviewModeButton.BackColor = Color.FromArgb(30, 30, 30);
            PreviewModeButton.FlatAppearance.BorderColor = Color.Black;
            PreviewModeButton.FlatStyle = FlatStyle.Flat;
            PreviewModeButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold);
            PreviewModeButton.ForeColor = Color.White;
            PreviewModeButton.Location = new Point(25, 584);
            PreviewModeButton.Name = "PreviewModeButton";
            PreviewModeButton.Size = new Size(182, 36);
            PreviewModeButton.TabIndex = 2;
            PreviewModeButton.Text = "Extrémité";
            PreviewModeButton.UseVisualStyleBackColor = false;
            PreviewModeButton.Click += PreviewModeButton_Click;
            // 
            // ValidateButton
            // 
            ValidateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ValidateButton.BackColor = Color.FromArgb(30, 30, 30);
            ValidateButton.FlatAppearance.BorderColor = Color.Black;
            ValidateButton.FlatStyle = FlatStyle.Flat;
            ValidateButton.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValidateButton.ForeColor = Color.White;
            ValidateButton.Location = new Point(25, 639);
            ValidateButton.Name = "ValidateButton";
            ValidateButton.Size = new Size(182, 36);
            ValidateButton.TabIndex = 1;
            ValidateButton.Text = "Valider";
            ValidateButton.UseVisualStyleBackColor = false;
            ValidateButton.Click += ValidateButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.BackColor = Color.FromArgb(30, 30, 30);
            DeleteButton.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Popup;
            DeleteButton.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(439, 639);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(182, 36);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "Supprimer";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // CuivrasséPanel
            // 
            CuivrasséPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CuivrasséPanel.BackColor = Color.FromArgb(30, 30, 30);
            CuivrasséPanel.BorderStyle = BorderStyle.FixedSingle;
            CuivrasséPanel.Controls.Add(cuivrassélabel2);
            CuivrasséPanel.Controls.Add(cuivrassélabel1);
            CuivrasséPanel.Controls.Add(CuivrasséLabel);
            CuivrasséPanel.Location = new Point(439, 40);
            CuivrasséPanel.Name = "CuivrasséPanel";
            CuivrasséPanel.Size = new Size(182, 320);
            CuivrasséPanel.TabIndex = 12;
            CuivrasséPanel.Click += ChoseTypeBoat_Click;
            // 
            // CuivrasséLabel
            // 
            CuivrasséLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CuivrasséLabel.AutoSize = true;
            CuivrasséLabel.Font = new Font("Javanese Text", 14F, FontStyle.Underline);
            CuivrasséLabel.ForeColor = Color.White;
            CuivrasséLabel.Location = new Point(45, 15);
            CuivrasséLabel.Name = "CuivrasséLabel";
            CuivrasséLabel.Size = new Size(97, 43);
            CuivrasséLabel.TabIndex = 0;
            CuivrasséLabel.Text = "Cuivrassé";
            // 
            // FeroxPanel
            // 
            FeroxPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FeroxPanel.BackColor = Color.FromArgb(30, 30, 30);
            FeroxPanel.BorderStyle = BorderStyle.FixedSingle;
            FeroxPanel.Controls.Add(feroxlabel2);
            FeroxPanel.Controls.Add(feroxlabel1);
            FeroxPanel.Controls.Add(Ferox);
            FeroxPanel.Location = new Point(232, 40);
            FeroxPanel.Name = "FeroxPanel";
            FeroxPanel.Size = new Size(182, 320);
            FeroxPanel.TabIndex = 11;
            FeroxPanel.Click += ChoseTypeBoat_Click;
            // 
            // Ferox
            // 
            Ferox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ferox.AutoSize = true;
            Ferox.Font = new Font("Javanese Text", 14F, FontStyle.Underline);
            Ferox.ForeColor = Color.White;
            Ferox.Location = new Point(45, 15);
            Ferox.Name = "Ferox";
            Ferox.Size = new Size(65, 43);
            Ferox.TabIndex = 0;
            Ferox.Text = "Ferox";
            // 
            // ZinctorPanel
            // 
            ZinctorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ZinctorPanel.BackColor = Color.FromArgb(30, 30, 30);
            ZinctorPanel.BorderStyle = BorderStyle.FixedSingle;
            ZinctorPanel.Controls.Add(zinctorlabel2);
            ZinctorPanel.Controls.Add(LabelZinctor1);
            ZinctorPanel.Controls.Add(ZinctorLabel);
            ZinctorPanel.Location = new Point(25, 40);
            ZinctorPanel.Name = "ZinctorPanel";
            ZinctorPanel.Size = new Size(182, 320);
            ZinctorPanel.TabIndex = 10;
            ZinctorPanel.Click += ChoseTypeBoat_Click;
            // 
            // ZinctorLabel
            // 
            ZinctorLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ZinctorLabel.AutoSize = true;
            ZinctorLabel.Font = new Font("Javanese Text", 14F, FontStyle.Underline);
            ZinctorLabel.ForeColor = Color.White;
            ZinctorLabel.Location = new Point(45, 15);
            ZinctorLabel.Name = "ZinctorLabel";
            ZinctorLabel.Size = new Size(80, 43);
            ZinctorLabel.TabIndex = 0;
            ZinctorLabel.Text = "Zinctor";
            // 
            // NbBoatPlacedLabel
            // 
            NbBoatPlacedLabel.AutoSize = true;
            NbBoatPlacedLabel.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NbBoatPlacedLabel.ForeColor = Color.White;
            NbBoatPlacedLabel.Location = new Point(229, 91);
            NbBoatPlacedLabel.Name = "NbBoatPlacedLabel";
            NbBoatPlacedLabel.Size = new Size(232, 24);
            NbBoatPlacedLabel.TabIndex = 3;
            NbBoatPlacedLabel.Text = "Nombre de bateau placé : 0";
            // 
            // LabelZinctor1
            // 
            LabelZinctor1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LabelZinctor1.AutoSize = true;
            LabelZinctor1.ForeColor = Color.White;
            LabelZinctor1.Location = new Point(10, 200);
            LabelZinctor1.Name = "LabelZinctor1";
            LabelZinctor1.Size = new Size(150, 15);
            LabelZinctor1.TabIndex = 1;
            LabelZinctor1.Text = "Super efficace contre Ferox";
            // 
            // zinctorlabel2
            // 
            zinctorlabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            zinctorlabel2.AutoSize = true;
            zinctorlabel2.ForeColor = Color.White;
            zinctorlabel2.Location = new Point(10, 250);
            zinctorlabel2.Name = "zinctorlabel2";
            zinctorlabel2.Size = new Size(128, 15);
            zinctorlabel2.TabIndex = 2;
            zinctorlabel2.Text = "Faible contre Cuivrassé";
            // 
            // feroxlabel1
            // 
            feroxlabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            feroxlabel1.AutoSize = true;
            feroxlabel1.ForeColor = Color.White;
            feroxlabel1.Location = new Point(10, 200);
            feroxlabel1.Name = "feroxlabel1";
            feroxlabel1.Size = new Size(171, 15);
            feroxlabel1.TabIndex = 1;
            feroxlabel1.Text = "Super efficace contre Cuivrassé";
            // 
            // feroxlabel2
            // 
            feroxlabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            feroxlabel2.AutoSize = true;
            feroxlabel2.ForeColor = Color.White;
            feroxlabel2.Location = new Point(10, 250);
            feroxlabel2.Name = "feroxlabel2";
            feroxlabel2.Size = new Size(116, 15);
            feroxlabel2.TabIndex = 2;
            feroxlabel2.Text = "Faible contre Zinctor";
            // 
            // cuivrassélabel1
            // 
            cuivrassélabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cuivrassélabel1.AutoSize = true;
            cuivrassélabel1.ForeColor = Color.White;
            cuivrassélabel1.Location = new Point(10, 200);
            cuivrassélabel1.Name = "cuivrassélabel1";
            cuivrassélabel1.Size = new Size(159, 15);
            cuivrassélabel1.TabIndex = 1;
            cuivrassélabel1.Text = "Super efficace contre Zinctor";
            // 
            // cuivrassélabel2
            // 
            cuivrassélabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cuivrassélabel2.AutoSize = true;
            cuivrassélabel2.ForeColor = Color.White;
            cuivrassélabel2.Location = new Point(10, 250);
            cuivrassélabel2.Name = "cuivrassélabel2";
            cuivrassélabel2.Size = new Size(107, 15);
            cuivrassélabel2.TabIndex = 2;
            cuivrassélabel2.Text = "Faible contre Ferox";
            // 
            // ChoseBoatScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1184, 761);
            Controls.Add(NbBoatPlacedLabel);
            Controls.Add(MainPanel);
            Controls.Add(TabPanel);
            Controls.Add(TitlePanel);
            MinimumSize = new Size(1200, 800);
            Name = "ChoseBoatScreen";
            Text = "Bataille Chimique";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            CuivrasséPanel.ResumeLayout(false);
            CuivrasséPanel.PerformLayout();
            FeroxPanel.ResumeLayout(false);
            FeroxPanel.PerformLayout();
            ZinctorPanel.ResumeLayout(false);
            ZinctorPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TitlePanel;
        private Panel TabPanel;
        private Panel MainPanel;
        private Label TitleLabel;
        private Panel CuivrasséPanel;
        private Panel FeroxPanel;
        private Panel ZinctorPanel;
        private Button DeleteButton;
        private Label ZinctorLabel;
        private Label CuivrasséLabel;
        private Label Ferox;
        private Button ValidateButton;
        private Button CancelButton;
        private Button RotateButton;
        private Button PreviewModeButton;
        private Button FiveCaseButton;
        private Button FourCaseButton;
        private Button ThreeCaseButton2;
        private Button ThreeCaseButton1;
        private Button TwoCaseButton;
        private Label NbBoatPlacedLabel;
        private Label cuivrassélabel2;
        private Label cuivrassélabel1;
        private Label feroxlabel2;
        private Label feroxlabel1;
        private Label zinctorlabel2;
        private Label LabelZinctor1;
    }
}
