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

        public Board(int numberOfRounds)
        {
            InitializeComponent();

            Game game = new Game(r, numberOfRounds);
        }

        public Board(String[] playersNames, int numberOfRounds)
        {
            InitializeComponent();

            //Creating new game
            Game game = new Game(r, numberOfRounds);
            game.AddPlayers(playersNames);

            //Set labels at board
            this.setLabelsWithNames(playersNames);
            this.numberOfRoundsLabel.Text = numberOfRounds.ToString();
        }

        private void setLabelsWithNames(String[] playersNames)
        {
            this.redPlayerNameLabel.Text = playersNames[0];
            this.greenPlayerNameLabel.Text = playersNames[1];
            this.bluePlayerNameLabel.Text = playersNames[2];
            this.yellowPlayerNameLabel.Text = playersNames[3];
        }
    }
}