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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.numberOfRoundsNumbericBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRoundsNumbericBox)).BeginInit();
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
            this.startGameButton.Location = new System.Drawing.Point(236, 571);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(347, 92);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start New Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // redPlayerNameTextBox
            // 
            this.redPlayerNameTextBox.Location = new System.Drawing.Point(412, 139);
            this.redPlayerNameTextBox.Name = "redPlayerNameTextBox";
            this.redPlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.redPlayerNameTextBox.TabIndex = 3;
            // 
            // greenPlayerNameTextBox
            // 
            this.greenPlayerNameTextBox.Location = new System.Drawing.Point(412, 228);
            this.greenPlayerNameTextBox.Name = "greenPlayerNameTextBox";
            this.greenPlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.greenPlayerNameTextBox.TabIndex = 4;
            // 
            // bluePlayerNameTextBox
            // 
            this.bluePlayerNameTextBox.Location = new System.Drawing.Point(412, 314);
            this.bluePlayerNameTextBox.Name = "bluePlayerNameTextBox";
            this.bluePlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.bluePlayerNameTextBox.TabIndex = 5;
            // 
            // yellowPlayerNameTextBox
            // 
            this.yellowPlayerNameTextBox.Location = new System.Drawing.Point(412, 404);
            this.yellowPlayerNameTextBox.Name = "yellowPlayerNameTextBox";
            this.yellowPlayerNameTextBox.Size = new System.Drawing.Size(218, 31);
            this.yellowPlayerNameTextBox.TabIndex = 6;
            // 
            // redPlayerNameLabel
            // 
            this.redPlayerNameLabel.AutoSize = true;
            this.redPlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.redPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.redPlayerNameLabel.Location = new System.Drawing.Point(192, 142);
            this.redPlayerNameLabel.Name = "redPlayerNameLabel";
            this.redPlayerNameLabel.Size = new System.Drawing.Size(202, 25);
            this.redPlayerNameLabel.TabIndex = 7;
            this.redPlayerNameLabel.Text = "Red Player Name:";
            // 
            // greenPlayerNameLabel
            // 
            this.greenPlayerNameLabel.AutoSize = true;
            this.greenPlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.greenPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greenPlayerNameLabel.Location = new System.Drawing.Point(170, 231);
            this.greenPlayerNameLabel.Name = "greenPlayerNameLabel";
            this.greenPlayerNameLabel.Size = new System.Drawing.Size(224, 25);
            this.greenPlayerNameLabel.TabIndex = 8;
            this.greenPlayerNameLabel.Text = "Green Player Name:";
            // 
            // bluePlayerNameLabel
            // 
            this.bluePlayerNameLabel.AutoSize = true;
            this.bluePlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.bluePlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bluePlayerNameLabel.Location = new System.Drawing.Point(187, 317);
            this.bluePlayerNameLabel.Name = "bluePlayerNameLabel";
            this.bluePlayerNameLabel.Size = new System.Drawing.Size(207, 25);
            this.bluePlayerNameLabel.TabIndex = 9;
            this.bluePlayerNameLabel.Text = "Blue Player Name:";
            // 
            // yellowPlayerNameLabel
            // 
            this.yellowPlayerNameLabel.AutoSize = true;
            this.yellowPlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.yellowPlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.yellowPlayerNameLabel.Location = new System.Drawing.Point(170, 407);
            this.yellowPlayerNameLabel.Name = "yellowPlayerNameLabel";
            this.yellowPlayerNameLabel.Size = new System.Drawing.Size(230, 25);
            this.yellowPlayerNameLabel.TabIndex = 10;
            this.yellowPlayerNameLabel.Text = "Yellow Player Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(1, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(814, 84);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(1, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(814, 84);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox3.Location = new System.Drawing.Point(1, 288);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(814, 83);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Location = new System.Drawing.Point(1, 377);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(814, 83);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // numberOfRoundsNumbericBox
            // 
            this.numberOfRoundsNumbericBox.Location = new System.Drawing.Point(412, 498);
            this.numberOfRoundsNumbericBox.Name = "numberOfRoundsNumbericBox";
            this.numberOfRoundsNumbericBox.Size = new System.Drawing.Size(218, 31);
            this.numberOfRoundsNumbericBox.TabIndex = 15;
            this.numberOfRoundsNumbericBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(186, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number of Rounds:";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 688);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberOfRoundsNumbericBox);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "StartWindow";
            this.Text = "Ludo Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRoundsNumbericBox)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown numberOfRoundsNumbericBox;
        private System.Windows.Forms.Label label3;
    }
}