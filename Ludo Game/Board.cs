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
        private Button[] route;
        private Button[] startPositionsButtons;
        private Button[] finishPositionsButtons;
        private Game game;

        private int currentDiceValue;
        private int currentNumberOfAttemptsToExit;
        private int currentNumberOfAvailableRollsADice = 0;

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
            int i = 0;

            foreach(string playerName in playersNames)
            {
                if (i == 0)
                    this.redPlayerNameLabel.Text = playerName;
                if (i == 1)
                    this.greenPlayerNameLabel.Text = playerName;
                if (i == 2)
                    this.bluePlayerNameLabel.Text = playerName;
                if (i == 3)
                    this.yellowPlayerNameLabel.Text = playerName;

                i++;
            }
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

        private Button[] FinishPositionsButtons
        {
            get
            {
                return new Button[]
                {
                    //Red Player End Positions Buttons
                    this.button41, this.button42, this.button43, this.button44,
                    //Green Player End Positions Buttons
                    this.button53, this.button54, this.button55, this.button56,
                    //Blue Player End Positions Buttons
                    this.button45, this.button46, this.button47, this.button48,
                    //Yellow Player End Positions Buttons
                    this.button49, this.button50, this.button51, this.button52
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

            //Finish Positions
            this.finishPositionsButtons = FinishPositionsButtons;
            this.initializeFinishPositionsButtons(this.finishPositionsButtons);

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
                button.Click += BoardField_Click;
            }
        }

        private void initializeStartPositionsButtons(Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Click += StartPositionButton_Click;
            }
        }

        private void initializeFinishPositionsButtons(Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.Click += FinishPositionButton_Click;
            }
        }

        private void rollDiceButton_Click(object sender, EventArgs e)
        {
            this.currentDiceValue = this.RollDiceAndChangeLabel();

            this.NextAttemptToExit();    
        }

        private void BoardField_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Player currentPlayer = this.game.CurrentPlayer;

            if(currentPlayer.PlayerColor == button.BackColor)
            {
                int currentPosition = this.GetButtonIndex(button);
                int buttonIndex = currentPosition + this.currentDiceValue;
                int numberOfTransitions = Convert.ToInt32(button.Text.Trim());

                if (numberOfTransitions + currentDiceValue > 40)
                {
                    int finishButtonNumber = numberOfTransitions + currentDiceValue - 40;

                    if (finishButtonNumber < 5 && finishButtonNumber > 0)
                    {
                        if(this.FinishPositionsButtons[this.GetFinishButtonIndex(finishButtonNumber - 1)].BackColor != Color.Pink)
                        {
                            this.FinishPositionsButtons[this.GetFinishButtonIndex(finishButtonNumber - 1)].BackColor = Color.Pink;

                            button.BackColor = Color.White;
                            button.Text = null;

                            currentPlayer.Finish();

                            if (currentPlayer.IsFinish())
                            {
                                if (game.IsFinish())
                                {
                                    EndWindow endWindow = new EndWindow(currentPlayer.Name);
                                    endWindow.Show();
                                } else
                                {
                                    ResetBoard();
                                    game.NextRound();
                                    game.ResetPlayers();
                                }
                            }
                        }

                        NextPlayer();
                    }
                    else
                        this.NextPlayer();
                   
                } else
                {
                    if (buttonIndex > this.route.Length - 1)
                        buttonIndex = buttonIndex - this.route.Length;

                    if(route[buttonIndex].BackColor != this.game.CurrentPlayer.PlayerColor)
                    {
                        this.MoveTo(button, buttonIndex, numberOfTransitions);
                        this.NextPlayer();
                    }     
                } 
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
                }

                Exit:;
            } 
        }

        private void FinishPositionButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int numberOfFiledAtFinish = 0;
            int indexOfButtonInArray = 0;

            if(button.BackColor == Color.Pink && button.ForeColor == this.game.CurrentPlayer.PlayerColor)
            {
                foreach (Button a in finishPositionsButtons)
                {
                    if (a.ForeColor == this.game.CurrentPlayer.PlayerColor)
                    {
                        if (a == button)
                            break;
                        else
                            numberOfFiledAtFinish++;
                    }

                    indexOfButtonInArray++;
                }

                if ((numberOfFiledAtFinish + currentDiceValue) < 4)
                {
                    if(finishPositionsButtons[indexOfButtonInArray + currentDiceValue].BackColor != Color.Pink)
                    {
                        button.BackColor = this.game.CurrentPlayer.PlayerColor;
                        finishPositionsButtons[indexOfButtonInArray + currentDiceValue].BackColor = Color.Pink;

                        NextPlayer();
                    }    
                }
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

            if (this.game.CurrentPlayer.HaveMoreThanOneThrow)
            {
                if (diceValue == 6 && CurrentPlayerCanStart)
                    this.rollDiceButton.Enabled = false;
                else
                    this.rollDiceButton.Enabled = true;
            }
            else
                rollDiceButton.Enabled = true;


            if (diceValue == 6)
                currentNumberOfAvailableRollsADice++;
            
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

            this.MoveTo(button, currentPlayer.StartPosition, 0);

            this.NextPlayer();
        }

        private void ResetNumberOfAttemptsToExit()
        {
            this.currentNumberOfAttemptsToExit = 0;
        }

        private void NextPlayer()
        {
            if (!(currentNumberOfAvailableRollsADice > 0))
            {
                this.game.NextPlayer();
                this.SetCurrentPlayerLabel();
                this.ResetNumberOfAttemptsToExit();
            } else
                currentNumberOfAvailableRollsADice--;

            this.currentDiceValue = this.RollDiceAndChangeLabel();
        }

        private void NextAttemptToExit()
        {
            if (this.currentNumberOfAttemptsToExit == Game.NUMBER_OF_POSIBILITY_TO_EXIT_START_POSITION - 1 || !this.game.CurrentPlayer.HaveMoreThanOneThrow)
                this.NextPlayer();
            else if(this.currentNumberOfAttemptsToExit == Game.NUMBER_OF_POSIBILITY_TO_EXIT_START_POSITION - 2)
            {
                if (currentDiceValue < 6)
                    NextPlayer();
                else
                    this.currentNumberOfAttemptsToExit++;
            } else
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

        private int GetFinishButtonIndex(int numberOfPosition)
        {
            int index = 0;

            foreach (Button buttonFromArray in this.finishPositionsButtons)
            {
                Color kolorek = buttonFromArray.BackColor;
                Color kolorekGracza = this.game.CurrentPlayer.PlayerColor;

                if (buttonFromArray.ForeColor == this.game.CurrentPlayer.PlayerColor)
                    if(numberOfPosition == 0)
                        break;
                    else
                    {
                        numberOfPosition--;
                        index++;
                    }       
                else
                    index++;  
            }

            return index;
        }

        private int GetFreeStartButtonIndex(Color color)
        {
            int index = 0;

            foreach(Button button in this.startPositionsButtons)
            {
                if (button.ForeColor == color && button.BackColor == Color.White)
                    break;
                else
                    index++;
            }
            return index;
        }

        private void MoveTo(Button button, int index, int numberOfTransitions)
        {
            if(route[index].BackColor != Color.White)
            {
                    startPositionsButtons[GetFreeStartButtonIndex(route[index].BackColor)].BackColor = route[index].BackColor;

                    this.game.CurrentPlayer.Hit();
                    this.game.GetPlayerByColor(route[index].BackColor).Death();
            }             

            if(numberOfTransitions > 0)
                route[index].Text = Convert.ToString(numberOfTransitions + currentDiceValue);
            else
                route[index].Text = Convert.ToString(numberOfTransitions+1);

            route[index].BackColor = this.game.CurrentPlayer.PlayerColor;

            button.BackColor = Color.White;
            button.Text = null;
        }

        private bool CurrentPlayerCanMove
        {
            get
            {
                bool valueToReturn = false;

                foreach (Button button in route)
                {
                    if (button.BackColor == this.game.CurrentPlayer.PlayerColor)
                    {
                        int index = GetButtonIndex(button) + currentDiceValue;

                        if (index > this.route.Length - 1)
                            index = index - this.route.Length;

                        if (route[index].BackColor != this.game.CurrentPlayer.PlayerColor)
                        {
                            valueToReturn = true;
                            break;
                        }
                    }
                }

                return valueToReturn;
            }
        }

        private bool CurrentPlayerCanMoveAtFinish
        {
            get
            {
                bool valueToReturn = false;

                int numberOfFiledAtFinish = 0;
 
                foreach (Button button in finishPositionsButtons)
                {
                    if (button.ForeColor == this.game.CurrentPlayer.PlayerColor)
                    {
                        int index = GetFinishButtonIndex(numberOfFiledAtFinish);

                        if ((numberOfFiledAtFinish + currentDiceValue) < 4)
                        {
                            if (finishPositionsButtons[index + currentDiceValue].BackColor != Color.Pink)
                            {
                                valueToReturn = true;
                                break;
                            }
                        }

                        numberOfFiledAtFinish++;
                    }
                }

                return valueToReturn;
            }
        }

        private void Board_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                NextPlayer();
        }

        private void ResetBoard()
        {
            foreach (Button button in StartPositionsButtons)
            {
                button.BackColor = button.ForeColor;
                button.Text = Convert.ToString(0);
            }

            foreach (Button button in FinishPositionsButtons)
            {
                button.BackColor = button.ForeColor;
                button.Text = Convert.ToString(0);
            }

            foreach (Button button in GameRoute)
            {
                button.BackColor = Color.White;
                button.Text = "";
            }
        }
    }
}