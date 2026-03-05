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
        private void SetGameBorad()
        {
            byte counter = Convert.ToByte('1');
            for (byte i = 0; i < 3; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    GameBoard[i, j] = Convert.ToChar(counter);
                    counter++;
                }
            }
        }
        private void SetBoardPicture()
        {
            byte counter = 9;
            foreach (var item in gbGameBoard.Controls.OfType<PictureBox>())
            {
                item.Image = TicTacToe.Properties.Resources.question_mark_96;
                item.Tag = Convert.ChangeType(counter, item.Tag.GetType());
                item.BackColor = Color.Indigo;
                counter--;
            }

        }
        private void ResetGame()
        {
            SetGameBorad();
            SetBoardPicture();
            ContinuePlaying = true;
            RoundCounter = 0;
            lblGameWinner.Text = "In Progress";
            lblPlayer.Text = "Player 1";
            lblPlayer.Tag = "X";
        }
        private void SetWinLine(byte rowFirstCell,byte colFirstCell, byte rowSecondCell, byte colSecondCell, byte rowThirdCell, byte colThirdCell)
        {
            byte FirstCellIndex = Convert.ToByte((rowFirstCell * 3) + colFirstCell + 1);
            byte SecondCellIndex = Convert.ToByte((rowSecondCell * 3) + colSecondCell + 1);
            byte ThirdCellIndex = Convert.ToByte((rowThirdCell * 3) + colThirdCell + 1);
            byte ItemTag = 0;
            foreach (var item in gbGameBoard.Controls.OfType<PictureBox>())
            {
                ItemTag = Convert.ToByte(item.Tag);
                if (ItemTag == FirstCellIndex)
                    item.BackColor = Color.Green;
                else if (ItemTag == SecondCellIndex)
                    item.BackColor = Color.Green;
                else if (ItemTag == ThirdCellIndex)
                    item.BackColor = Color.Green;
            }
        }
        private bool IsWin(char PlayerSign)
        {
            if (GameBoard[0, 0] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 2] == PlayerSign)
            {
                SetWinLine(0, 0, 1, 1, 2, 2);
                return true;
            }
            if (GameBoard[0, 2] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 0] == PlayerSign)
            {
                SetWinLine(0, 2, 1, 1, 2, 0);
                return true;
            }
            for (byte i = 0; i < 3; i++)
            {
                if (GameBoard[i, 0] == PlayerSign && GameBoard[i, 1] == PlayerSign && GameBoard[i, 2] == PlayerSign)
                {
                    SetWinLine(i, 0, i, 1, i, 2);
                    return true;
                }
                if (GameBoard[0, i] == PlayerSign && GameBoard[1, i] == PlayerSign && GameBoard[2, i] == PlayerSign)
                {
                    SetWinLine(0, i, 1, i, 2, i);
                    return true;
                }
            }
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
            RoundCounter++;
            UpdateGameBoard(((PictureBox)sender), PlayerSign, image);
            ContinuePlaying = !IsWin(PlayerSign);
            if (!ContinuePlaying)
            {
                lblGameWinner.Text = lblPlayer.Text;
                return;
            }
            else
            {
                if (RoundCounter == 9)
                {
                    lblGameWinner.Text = "Draw";
                    ContinuePlaying = false;
                    return;
                }
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
            char SenderTag = Convert.ToChar(((PictureBox)sender).Tag);
            if (Char.IsDigit(SenderTag) && ContinuePlaying)
            {
                UpdateGame(sender);
            }
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
