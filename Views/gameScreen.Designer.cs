namespace BatailleChimiqueWinform.Views
{
    partial class gameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PersonalArea = new Panel();
            OppenentArea = new Panel();
            UpdateLabel = new Label();
            SuspendLayout();
            // 
            // PersonalArea
            // 
            PersonalArea.Location = new Point(12, 136);
            PersonalArea.Name = "PersonalArea";
            PersonalArea.Size = new Size(600, 500);
            PersonalArea.TabIndex = 0;
            // 
            // OppenentArea
            // 
            OppenentArea.Location = new Point(660, 136);
            OppenentArea.Name = "OppenentArea";
            OppenentArea.Size = new Size(600, 500);
            OppenentArea.TabIndex = 1;
            // 
            // UpdateLabel
            // 
            UpdateLabel.AutoSize = true;
            UpdateLabel.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateLabel.ForeColor = Color.White;
            UpdateLabel.Location = new Point(469, 67);
            UpdateLabel.Name = "UpdateLabel";
            UpdateLabel.Size = new Size(0, 31);
            UpdateLabel.TabIndex = 2;
            UpdateLabel.Visible = false;
            // 
            // gameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1284, 669);
            Controls.Add(UpdateLabel);
            Controls.Add(OppenentArea);
            Controls.Add(PersonalArea);
            Name = "gameScreen";
            Text = "gameScreen";
            FormClosed += gameScreen_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PersonalArea;
        private Panel OppenentArea;
        private Label UpdateLabel;
    }
}