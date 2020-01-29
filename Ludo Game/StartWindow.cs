using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_Game
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            List<string> namesList = new List<string>();

            if (redPlayerNameTextBox.Text != "")
                namesList.Add(redPlayerNameTextBox.Text);

            if (greenPlayerNameTextBox.Text != "")
                namesList.Add(greenPlayerNameTextBox.Text);

            if (bluePlayerNameTextBox.Text != "")
                namesList.Add(bluePlayerNameTextBox.Text);

            if (yellowPlayerNameTextBox.Text != "")
                namesList.Add(yellowPlayerNameTextBox.Text);

            string[] names = namesList.ToArray();

            if (redPlayerNameTextBox.Text != "" && greenPlayerNameTextBox.Text != "")
            {
                Board board = new Board(names, Convert.ToInt32(this.numberOfRoundsNumbericBox.Value));

                board.Show();
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (bluePlayerNameTextBox.Enabled)
            {
                bluePlayerNameTextBox.Enabled = false;
                pictureBox3.BackColor = Color.DarkGray;
            } else
            {
                bluePlayerNameTextBox.Enabled = true;
                pictureBox3.BackColor = Color.RoyalBlue;
            }  
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if(yellowPlayerNameTextBox.Enabled)
            {
                yellowPlayerNameTextBox.Enabled = false;
                pictureBox4.BackColor = Color.DarkGray;
            } else
            {
                yellowPlayerNameTextBox.Enabled = true;
                pictureBox4.BackColor = Color.Yellow;
            } 
        }
    }
}
