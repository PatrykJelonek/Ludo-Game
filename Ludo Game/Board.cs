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
    public partial class Board : Form
    {
        private Random r;

        public Board()
        {
            InitializeComponent();

            Game game = new Game(r);
        }

        public Board(String playerOneName, String playerTwoName, String playerThreeName, String playerFourName)
        {
            InitializeComponent();

            Game game = new Game(r);
            game.AddPlayers(playerOneName, playerTwoName, playerThreeName, playerFourName);

            this.redPlayerNameLabel.Text = playerOneName;
            this.greenPlayerNameLabel.Text = playerTwoName;
            this.bluePlayerNameLabel.Text = playerThreeName;
            this.yellowPlayerNameLabel.Text = playerFourName;
        }
    }
}
