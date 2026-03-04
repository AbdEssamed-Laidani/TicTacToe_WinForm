using MaterialSkin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private char[,] GameBoard = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        private bool ContinuePlaying = true;
        private byte RoundCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }
       
        private bool IsWin(char PlayerSign)
        {

            if (GameBoard[0, 0] == PlayerSign && GameBoard[0, 1] == PlayerSign && GameBoard[0, 2] == PlayerSign)
                return true;
            else if (GameBoard[1, 0] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[1, 2] == PlayerSign)
                return true;
            else if (GameBoard[2, 0] == PlayerSign && GameBoard[2, 1] == PlayerSign && GameBoard[2, 2] == PlayerSign)
                return true;
            else if (GameBoard[0, 0] == PlayerSign && GameBoard[1, 0] == PlayerSign && GameBoard[2, 0] == PlayerSign)
                return true;
            else if (GameBoard[0, 1] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 1] == PlayerSign)
                return true;
            else if (GameBoard[0, 2] == PlayerSign && GameBoard[1, 2] == PlayerSign && GameBoard[2, 2] == PlayerSign)
                return true;
            else if (GameBoard[0, 0] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 2] == PlayerSign)
                return true;
            else if (GameBoard[0, 2] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 0] == PlayerSign)
                return true;
            else
                return false;
        }
        private void UpdateGameBoard(PictureBox box, in char PlayerSign, Image image)
        {

            int row = (byte.Parse(box.Tag.ToString()) - 1) / 3;
            int col = (byte.Parse(box.Tag.ToString()) - 1) % 3;

            box.Image = image;
            GameBoard[row, col] = Convert.ToChar(PlayerSign);
        }
        private void UpdateRound(object sender, in string NewTag, in string NewPlayerName, in char PlayerSign,Image image)
        {
            UpdateGameBoard(((PictureBox)sender), PlayerSign, image);
            ((PictureBox)sender).Tag = "Exist";
            ContinuePlaying = !IsWin(PlayerSign);
            if (!ContinuePlaying)
            {
                lblGameWinner.Text = lblPlayer.Text;
                return;
            }
            lblPlayer.Text = NewPlayerName;
            lblPlayer.Tag = NewTag;
        }
        private void UpdateGame(object sender)
        {
            if (lblPlayer.Tag.ToString() == "X")
                UpdateRound(sender, "O", "Player 2", 'X', TicTacToe.Properties.Resources.X);
            else
                UpdateRound(sender, "X", "Player 1", 'O', TicTacToe.Properties.Resources.O);
        }
        private void Click_Changed(object sender, MouseEventArgs e)
        {

            if (((PictureBox)sender).Tag.ToString() != "Exist" && ContinuePlaying)
            {
                RoundCounter++;
                UpdateGame(sender);

                if (RoundCounter == 9)
                {
                    lblGameWinner.Text = "Draw";
                    ContinuePlaying = false;
                    return;
                }
                
            }
        }
        
    }
}
