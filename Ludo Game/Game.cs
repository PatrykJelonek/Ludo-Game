using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game
{
    class Game
    {
        //Game Constants
        public Color[] PLAYERS_COLORS = new Color[] { Color.Red, Color.Green, Color.RoyalBlue, Color.Yellow };
        public int[] PLAYERS_START_INDEXES = new int[] { 22, 32, 2, 12 };
        public const int NUMBER_OF_PLAYERS = 4;
        private const int START_DICE_VALUE = 6;

        //Game Information
        private readonly Dice dice;
        private readonly Player[] players;
        private int playerIndex;
        private int currentPlayerIndex;
        private int round;
        private int numberOfRounds;

        private Player CurrentPlayer
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
    }
}