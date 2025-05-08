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
            oppenentArea = new Panel();
            SuspendLayout();
            // 
            // PersonalArea
            // 
            PersonalArea.Location = new Point(12, 36);
            PersonalArea.Name = "PersonalArea";
            PersonalArea.Size = new Size(600, 600);
            PersonalArea.TabIndex = 0;
            // 
            // oppenentArea
            // 
            oppenentArea.Location = new Point(660, 36);
            oppenentArea.Name = "oppenentArea";
            oppenentArea.Size = new Size(600, 600);
            oppenentArea.TabIndex = 1;
            // 
            // gameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1284, 669);
            Controls.Add(oppenentArea);
            Controls.Add(PersonalArea);
            Name = "gameScreen";
            Text = "gameScreen";
            ResumeLayout(false);
        }

        #endregion

        private Panel PersonalArea;
        private Panel oppenentArea;
    }
}