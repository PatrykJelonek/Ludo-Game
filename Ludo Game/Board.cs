﻿using System;
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
        private Button[] route;
        private Button[] startPositionsButtons;
        private Game game;

        private int currentDiceValue;
        private int currentNumberOfAttemptsToExit;

        public Board(int numberOfRounds)
        {
            InitializeComponent();

            Game game = new Game(new Random(), numberOfRounds);
        }

        public Board(String[] playersNames, int numberOfRounds)
        {
            InitializeComponent();

            //Creating new game
            this.game = new Game(new Random(), numberOfRounds);
            game.AddPlayers(playersNames);

            //Inizialize game
            this.inizializeGame();

            //Set labels at board
            this.SetLabelsWithNames(playersNames);
            this.numberOfRoundsLabel.Text = numberOfRounds.ToString();
        }

        private void SetLabelsWithNames(String[] playersNames)
        {
            this.redPlayerNameLabel.Text = playersNames[0];
            this.greenPlayerNameLabel.Text = playersNames[1];
            this.bluePlayerNameLabel.Text = playersNames[2];
            this.yellowPlayerNameLabel.Text = playersNames[3];
        }

        private Button[] GameRoute
        {
            get
            {
                return new Button[] 
                {
                this.button1,  this.button2,  this.button3,  this.button4,  this.button5,  this.button6,  this.button7,  this.button8,  this.button9,  this.button10,
                this.button11, this.button12, this.button13, this.button14, this.button15, this.button16, this.button17, this.button18, this.button19, this.button20,
                this.button21, this.button22, this.button23, this.button24, this.button25, this.button26, this.button27, this.button28, this.button29, this.button30,
                this.button31, this.button32, this.button33, this.button34, this.button35, this.button36, this.button37, this.button38, this.button39, this.button40
                };
            }
        }

        private Button[] StartPositionsButtons
        {
            get
            {
                return new Button[]
                {
                    //Red Player Start Positions Buttons
                    this.button65, this.button66, this.button67, this.button68,
                    //Green Player Start Positions Buttons
                    this.button61, this.button62, this.button63, this.button64,
                    //Blue Player Start Positions Buttons
                    this.button57, this.button58, this.button59, this.button60,
                    //Yellow Player Start Positions Buttons
                    this.button69, this.button70, this.button71, this.button72
                };
            }
        }
        
        private void inizializeGame()
        {
            //Route
            this.route = GameRoute;
            this.initializeRoute(this.route);

            //Start Positions
            this.startPositionsButtons = StartPositionsButtons;
            this.initializeStartPositionsButtons(this.startPositionsButtons);

            //Current Player
            this.SetCurrentPlayerLabel();

            //Set Dice
            this.currentDiceValue = RollDiceAndChangeLabel();

            //Set currentNumberOfAttemptsToExit
            this.currentNumberOfAttemptsToExit = 0;
        }

        private void initializeRoute(Button[] buttons)
        {
            foreach(Button button in buttons)
            {
                button.Click += MyButtonClick;
            }
        }

        private void initializeStartPositionsButtons(Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Click += StartPositionButton_Click;
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            this.currentDiceValue = this.RollDiceAndChangeLabel();
            
            this.NextAttemptToExit();    
        }

        private void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Player currentPlayer = this.game.CurrentPlayer;

            if(currentPlayer.PlayerColor == button.BackColor)
            {
                int buttonIndex = this.GetButtonIndex(button);

                if(buttonIndex + currentDiceValue >= this.route.Length)
                route[currentPlayer.StartPosition].BackColor = currentPlayer.PlayerColor;
                button.BackColor = Color.White;
            }
        }

        private void StartPositionButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Player currentPlayer = this.game.CurrentPlayer;

            if(currentPlayer.PlayerColor == button.BackColor && this.CurrentPlayerCanStart)
            {
                if (currentPlayer.NumberOfFiguresAtStart < Player.NUMBER_OF_FIGURES)
                {
                    if(this.currentDiceValue == 6)
                    {
                        currentPlayer.Start();
                        this.MoveToStart(button);
                    }
                } else
                {
                    if (this.currentDiceValue == 6)
                    {
                        currentPlayer.Start();
                        this.MoveToStart(button);
                        goto Exit;
                    }
                    //else
                        //this.NextAttemptToExit();
                }

                Exit:;
            } 
        }

        private void SetCurrentPlayerLabel()
        {
            this.currentPlayerLabel.Text = this.game.CurrentPlayer.Name;
            this.currentPlayerLabel.ForeColor = this.game.CurrentPlayer.PlayerColor;
        }

        private int RollDiceAndChangeLabel()
        {
            int diceValue = this.game.rollDice();
            this.diceValueLabel.Text = diceValue.ToString();

            return diceValue;
        }

        private bool CurrentPlayerCanStart
        {
            get
            {
                Player currentPlayer = this.game.CurrentPlayer;

                if (currentPlayer.PlayerColor == route[currentPlayer.StartPosition].BackColor)
                    return false;
                else
                    return true;
            }
        }

        private void MoveToStart(Button button)
        {
            Player currentPlayer = this.game.CurrentPlayer;

            route[currentPlayer.StartPosition].BackColor = currentPlayer.PlayerColor;
            button.BackColor = Color.White;

            this.NextPlayer();
        }

        private void ResetNumberOfAttemptsToExit()
        {
            this.currentNumberOfAttemptsToExit = 0;
        }

        private void NextPlayer()
        {
            this.game.NextPlayer();
            this.SetCurrentPlayerLabel();
            this.currentDiceValue = this.RollDiceAndChangeLabel();
            this.ResetNumberOfAttemptsToExit(); 
        }

        private void NextAttemptToExit()
        {
            if (this.currentNumberOfAttemptsToExit == Game.NUMBER_OF_POSIBILITY_TO_EXIT_START_POSITION - 1)
                this.NextPlayer();
            else
                this.currentNumberOfAttemptsToExit++;    
        }

        private int GetButtonIndex(Button button)
        {
            int routeLenght = this.route.Length;
            int index = 0;

            foreach(Button buttonFromRoute in this.route)
            {
                if (button == buttonFromRoute)
                    break;
                else
                    index++;
            }

            return index;
        }
    }
}