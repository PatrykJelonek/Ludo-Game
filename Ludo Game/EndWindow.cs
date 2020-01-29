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
    public partial class EndWindow : Form
    {
        public EndWindow()
        {
            InitializeComponent();
        }

        public EndWindow(String playerName)
        {
            InitializeComponent();
            this.playerLabel.Text = playerName;
        }
    }
}
