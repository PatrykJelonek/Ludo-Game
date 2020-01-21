using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo_Game
{
    class Player
    {
        private const int NUMBER_OF_FIGURES = 4;

        //Player Information
        private readonly String name;
        private readonly Color playerColor;
        private readonly int startPosition;

        //Player Statistic
        private int numberOfFiguresAtStart;
        private int numberOfFiguresAtFinish;
        private int numberOfHits;
        private int numberOfDeaths;
        private int winningRound;

        public String Name
        {
            get { return this.name; }
        }

        public Color PlayerColor
        {
            get { return this.playerColor; }
        }

        public int StartPosition
        {
            get { return this.startPosition; }
        }

        public int WinningRound
        {
            get { return this.winningRound; }
        }

        public Player(String name, Color color, int startPosition)
        {
            this.name = name;
            this.playerColor = color;
            this.startPosition = startPosition;

            this.numberOfFiguresAtStart = NUMBER_OF_FIGURES;
            this.numberOfFiguresAtFinish = 0;

            this.numberOfHits = 0;
            this.numberOfDeaths = 0;
            this.winningRound = -1;
        }

        public void Start()
        {
            if(numberOfFiguresAtStart > 0)
            {
                numberOfFiguresAtStart--;
            }
        }

        public bool HasFigureAtStart()
        {
            return this.numberOfFiguresAtStart > 0;
        }

        public void Finish()
        {
            if (this.numberOfFiguresAtFinish < NUMBER_OF_FIGURES)
            {
                this.numberOfFiguresAtFinish++;
            }
        }

        public void Hit()
        {
            this.numberOfHits++;
        }

        public void Death()
        {
            if (this.numberOfFiguresAtStart < NUMBER_OF_FIGURES)
            {
                this.numberOfFiguresAtStart++;
                this.numberOfDeaths++;
            }
        }

        public bool IsFinish()
        {
            return this.numberOfFiguresAtFinish == NUMBER_OF_FIGURES;
        }

        public void End(int round)
        {
            this.winningRound = round;
        }
    }
}