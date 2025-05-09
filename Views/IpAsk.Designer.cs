namespace BatailleChimiqueWinform.Views
{
    partial class IpAsk
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox1.BackColor = Color.FromArgb(70, 70, 70);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(55, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox2.BackColor = Color.FromArgb(70, 70, 70);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(193, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox3.BackColor = Color.FromArgb(70, 70, 70);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(330, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 16);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBox4.BackColor = Color.FromArgb(70, 70, 70);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(485, 80);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 16);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(30, 30, 30);
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(253, 159);
            button1.Name = "button1";
            button1.Size = new Size(103, 29);
            button1.TabIndex = 4;
            button1.Text = "Valider";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 21);
            label1.Name = "label1";
            label1.Size = new Size(250, 23);
            label1.TabIndex = 5;
            label1.Text = "Entrer l'addresse IP du serveur";
            // 
            // IpAsk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(634, 241);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            ForeColor = Color.White;
            MaximumSize = new Size(650, 280);
            MinimumSize = new Size(650, 280);
            Name = "IpAsk";
            Text = "IpAsk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
    }
}