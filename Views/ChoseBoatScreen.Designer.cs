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
            mainPanel = new Panel();
            button = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            TitlePanel.SuspendLayout();
            mainPanel.SuspendLayout();
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
            TabPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TabPanel.Location = new Point(0, 139);
            TabPanel.Name = "TabPanel";
            TabPanel.Size = new Size(531, 536);
            TabPanel.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mainPanel.Controls.Add(button);
            mainPanel.Controls.Add(panel5);
            mainPanel.Controls.Add(panel4);
            mainPanel.Controls.Add(panel3);
            mainPanel.Location = new Point(537, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(646, 760);
            mainPanel.TabIndex = 2;
            // 
            // button
            // 
            button.BackColor = Color.FromArgb(30, 30, 30);
            button.FlatAppearance.BorderColor = Color.FromArgb(30, 30, 30);
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Popup;
            button.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = Color.White;
            button.Location = new Point(439, 639);
            button.Name = "button";
            button.Size = new Size(182, 36);
            button.TabIndex = 0;
            button.Text = "Supprimer";
            button.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 30, 30);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(439, 40);
            panel5.Name = "panel5";
            panel5.Size = new Size(182, 320);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(232, 40);
            panel4.Name = "panel4";
            panel4.Size = new Size(182, 320);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 30, 30);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(25, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(182, 320);
            panel3.TabIndex = 0;
            // 
            // ChoseBoatScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1184, 761);
            Controls.Add(mainPanel);
            Controls.Add(TabPanel);
            Controls.Add(TitlePanel);
            MinimumSize = new Size(1200, 800);
            Name = "ChoseBoatScreen";
            Text = "Bataille Chimique";
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TitlePanel;
        private Panel TabPanel;
        private Panel mainPanel;
        private Label TitleLabel;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Button button;
    }
}
