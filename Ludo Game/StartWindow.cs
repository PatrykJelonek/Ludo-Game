using System;
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
            if(redPlayerNameTextBox.Text != "" && greenPlayerNameTextBox.Text != "" && bluePlayerNameTextBox.Text != "" && yellowPlayerNameTextBox.Text != "")
            {
                Board board = new Board(new string[] { this.redPlayerNameTextBox.Text, this.greenPlayerNameTextBox.Text, this.bluePlayerNameTextBox.Text, this.yellowPlayerNameTextBox.Text }, Convert.ToInt32(this.numberOfRoundsNumbericBox.Value));

                board.Show();
            }
        }
    }
}
