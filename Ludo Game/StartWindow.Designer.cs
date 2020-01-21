namespace Ludo_Game
{
    partial class StartWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.redPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.greenPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.bluePlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.yellowPlayerNameTextBox = new System.Windows.Forms.TextBox();
            this.redPlayerNameLabel = new System.Windows.Forms.Label();
            this.greenPlayerNameLabel = new System.Windows.Forms.Label();
            this.bluePlayerNameLabel = new System.Windows.Forms.Label();
            this.yellowPlayerNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(143, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome in Ludo Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "by Patryk Jelonek";
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(225, 398);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(347, 92);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start New Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // redPlayerNameTextBox
            // 
            this.redPlayerNameTextBox.Location = new System.Drawing.Point(373, 151);
            this.redPlayerNameTextBox.Name = "redPlayerNameTextBox";
            this.redPlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.redPlayerNameTextBox.TabIndex = 3;
            // 
            // greenPlayerNameTextBox
            // 
            this.greenPlayerNameTextBox.Location = new System.Drawing.Point(373, 188);
            this.greenPlayerNameTextBox.Name = "greenPlayerNameTextBox";
            this.greenPlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.greenPlayerNameTextBox.TabIndex = 4;
            // 
            // bluePlayerNameTextBox
            // 
            this.bluePlayerNameTextBox.Location = new System.Drawing.Point(373, 225);
            this.bluePlayerNameTextBox.Name = "bluePlayerNameTextBox";
            this.bluePlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.bluePlayerNameTextBox.TabIndex = 5;
            // 
            // yellowPlayerNameTextBox
            // 
            this.yellowPlayerNameTextBox.Location = new System.Drawing.Point(373, 262);
            this.yellowPlayerNameTextBox.Name = "yellowPlayerNameTextBox";
            this.yellowPlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.yellowPlayerNameTextBox.TabIndex = 6;
            // 
            // redPlayerNameLabel
            // 
            this.redPlayerNameLabel.AutoSize = true;
            this.redPlayerNameLabel.Location = new System.Drawing.Point(181, 154);
            this.redPlayerNameLabel.Name = "redPlayerNameLabel";
            this.redPlayerNameLabel.Size = new System.Drawing.Size(186, 25);
            this.redPlayerNameLabel.TabIndex = 7;
            this.redPlayerNameLabel.Text = "Red Player Name:";
            // 
            // greenPlayerNameLabel
            // 
            this.greenPlayerNameLabel.AutoSize = true;
            this.greenPlayerNameLabel.Location = new System.Drawing.Point(161, 191);
            this.greenPlayerNameLabel.Name = "greenPlayerNameLabel";
            this.greenPlayerNameLabel.Size = new System.Drawing.Size(206, 25);
            this.greenPlayerNameLabel.TabIndex = 8;
            this.greenPlayerNameLabel.Text = "Green Player Name:";
            // 
            // bluePlayerNameLabel
            // 
            this.bluePlayerNameLabel.AutoSize = true;
            this.bluePlayerNameLabel.Location = new System.Drawing.Point(177, 228);
            this.bluePlayerNameLabel.Name = "bluePlayerNameLabel";
            this.bluePlayerNameLabel.Size = new System.Drawing.Size(190, 25);
            this.bluePlayerNameLabel.TabIndex = 9;
            this.bluePlayerNameLabel.Text = "Blue Player Name:";
            // 
            // yellowPlayerNameLabel
            // 
            this.yellowPlayerNameLabel.AutoSize = true;
            this.yellowPlayerNameLabel.Location = new System.Drawing.Point(156, 265);
            this.yellowPlayerNameLabel.Name = "yellowPlayerNameLabel";
            this.yellowPlayerNameLabel.Size = new System.Drawing.Size(211, 25);
            this.yellowPlayerNameLabel.TabIndex = 10;
            this.yellowPlayerNameLabel.Text = "Yellow Player Name:";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 565);
            this.Controls.Add(this.yellowPlayerNameLabel);
            this.Controls.Add(this.bluePlayerNameLabel);
            this.Controls.Add(this.greenPlayerNameLabel);
            this.Controls.Add(this.redPlayerNameLabel);
            this.Controls.Add(this.yellowPlayerNameTextBox);
            this.Controls.Add(this.bluePlayerNameTextBox);
            this.Controls.Add(this.greenPlayerNameTextBox);
            this.Controls.Add(this.redPlayerNameTextBox);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartWindow";
            this.Text = "Ludo Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.TextBox redPlayerNameTextBox;
        private System.Windows.Forms.TextBox greenPlayerNameTextBox;
        private System.Windows.Forms.TextBox bluePlayerNameTextBox;
        private System.Windows.Forms.TextBox yellowPlayerNameTextBox;
        private System.Windows.Forms.Label redPlayerNameLabel;
        private System.Windows.Forms.Label greenPlayerNameLabel;
        private System.Windows.Forms.Label bluePlayerNameLabel;
        private System.Windows.Forms.Label yellowPlayerNameLabel;
    }
}