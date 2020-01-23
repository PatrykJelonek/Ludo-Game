using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_Game
{
    class Game
    {
        //Game Constants
        public Color[] PLAYERS_COLORS = new Color[] { Color.Red, Color.Green, Color.RoyalBlue, Color.Yellow };
        private int[] PLAYERS_START_INDEXES = new int[] { 22, 32, 2, 12 };
        public const int NUMBER_OF_POSIBILITY_TO_EXIT_START_POSITION = 4;
        public const int NUMBER_OF_PLAYERS = 4;
        private const int START_DICE_VALUE = 6;

        //Game Information
        private readonly Dice dice;
        private readonly Player[] players;
        private int playerIndex;
        private int currentPlayerIndex;
        private int round;
        private int numberOfRounds;

        public Player CurrentPlayer
        {
            get { return this.players[this.currentPlayerIndex]; }
        }

        public Game(Random random, int numberOfRounds)
        {
            this.dice = new Dice(random);
            this.players = new Player[NUMBER_OF_PLAYERS];
            this.playerIndex = 0;
            this.currentPlayerIndex = 0;
            this.round = 1;
            this.numberOfRounds = numberOfRounds;
        }

        public void AddPlayers(string[] playersNames)
        {
            foreach(string playerName in playersNames)
                this.AddPlayer(playerName);
        }

        private void AddPlayer(String name)
        {
            if(this.playerIndex < this.players.Length)
            {
                this.players[this.playerIndex] = new Player(name, PLAYERS_COLORS[this.playerIndex], PLAYERS_START_INDEXES[this.playerIndex]);
                this.playerIndex++;
            }
        }

        //TODO: Change function below
        public bool IsFinish()
        {
            return round == numberOfRounds;
        }

        public int rollDice()
        {
           return this.dice.Roll();
        }

        private bool IsStartFigurePossible(Player player, int diceValue)
        {
            return diceValue == START_DICE_VALUE && player.HasFigureAtStart();
        }

        public void NextPlayer()
        {
            if (this.currentPlayerIndex < this.players.Length - 1)
            {
                this.currentPlayerIndex++;
            }
            else
            {
                this.currentPlayerIndex = 0;
                this.round++;
            }
        }

        public Player GetPlayerByColor(Color color)
        {
            Player playerToReturn = players[0];

            foreach (Player player in this.players)
            {
                if (player.PlayerColor == color)
                    playerToReturn = player;
            }

            return playerToReturn;
        }
    }
}