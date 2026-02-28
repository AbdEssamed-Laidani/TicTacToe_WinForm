using MaterialSkin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Click_Changed(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Tag == null)
            {
                if (lblPlayer.Tag.ToString() == "X")
                {
                    ((PictureBox)sender).Image = TicTacToe.Properties.Resources.X;
                    ((PictureBox)sender).Tag = "true";
                    lblPlayer.Text = "Player 2";
                    lblPlayer.Tag = "O";
                }
                else
                {
                    ((PictureBox)sender).Image = TicTacToe.Properties.Resources.O;
                    ((PictureBox)sender).Tag = "true";
                    lblPlayer.Text = "Player 1";
                    lblPlayer.Tag = "X";
                }
            }
        }
        
    }
}
