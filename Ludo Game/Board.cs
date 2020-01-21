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

        public Board(String redPlayerName, String greenPlayerName, String bluePlayerName, String yellowPlayerName)
        {
            InitializeComponent();

            Game game = new Game(r);
            game.AddPlayers(redPlayerName, greenPlayerName, bluePlayerName, yellowPlayerName);

            this.redPlayerNameLabel.Text = redPlayerName;
            this.greenPlayerNameLabel.Text = greenPlayerName;
            this.bluePlayerNameLabel.Text = bluePlayerName;
            this.yellowPlayerNameLabel.Text = yellowPlayerName;
        }
    }
}
