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
        private byte[] WinnerCellsIndexes = new byte[3];

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
            foreach (var item in gbGameBoard.Controls.OfType<PictureBox>())
            {
                item.Image = TicTacToe.Properties.Resources.question_mark_96;
                item.Enabled = true;
                item.BackColor = Color.Indigo;
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
            gbGameBoard.Enabled = true;
        }
        private byte GetWinnerCell(byte row,byte col)
        {
            return Convert.ToByte((row * 3) + col + 1);
        }
        private void SetWinLine()
        {
            foreach (var item in WinnerCellsIndexes)
            {
                var targetBox = gbGameBoard.Controls.OfType<PictureBox>().FirstOrDefault(pb => Convert.ToByte(pb.Tag) == item);

                if (targetBox != null)
                {
                    targetBox.BackColor = Color.Green;
                }
            }
        }
        private bool IsWin(char PlayerSign)
        {
            if (GameBoard[0, 0] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 2] == PlayerSign)
            {
                WinnerCellsIndexes[0] = GetWinnerCell(0, 0);
                WinnerCellsIndexes[1] = GetWinnerCell(1, 1);
                WinnerCellsIndexes[2] = GetWinnerCell(2, 2);
                SetWinLine();
                return true;
            }
            if (GameBoard[0, 2] == PlayerSign && GameBoard[1, 1] == PlayerSign && GameBoard[2, 0] == PlayerSign)
            {
                WinnerCellsIndexes[0] = GetWinnerCell(0, 2);
                WinnerCellsIndexes[1] = GetWinnerCell(1, 1);
                WinnerCellsIndexes[2] = GetWinnerCell(2, 0);
                SetWinLine();
                return true;
            }
            for (byte i = 0; i < 3; i++)
            {
                if (GameBoard[i, 0] == PlayerSign && GameBoard[i, 1] == PlayerSign && GameBoard[i, 2] == PlayerSign)
                {
                    WinnerCellsIndexes[0] = GetWinnerCell(i, 0);
                    WinnerCellsIndexes[1] = GetWinnerCell(i, 1);
                    WinnerCellsIndexes[2] = GetWinnerCell(i, 2);
                    SetWinLine();
                    return true;
                }
                if (GameBoard[0, i] == PlayerSign && GameBoard[1, i] == PlayerSign && GameBoard[2, i] == PlayerSign)
                {
                    WinnerCellsIndexes[0] = GetWinnerCell(0, i);
                    WinnerCellsIndexes[1] = GetWinnerCell(1, i);
                    WinnerCellsIndexes[2] = GetWinnerCell(2, i);
                    SetWinLine();
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
            box.Enabled = false;
        }
        private void UpdateRound(object sender, in string NewPlayerTag, in string NewPlayerName, in char PlayerSign,Image image)
        {
            RoundCounter++;
            UpdateGameBoard(((PictureBox)sender), PlayerSign, image);
            ContinuePlaying = !IsWin(PlayerSign);
            if (!ContinuePlaying)
            {
                lblGameWinner.Text = lblPlayer.Text;
                gbGameBoard.Enabled = false;
                return;
            }
            else
            {
                if (RoundCounter == 9)
                {
                    lblGameWinner.Text = "Draw";
                    ContinuePlaying = false;
                    gbGameBoard.Enabled = false;
                    return;
                }
            }
            lblPlayer.Text = NewPlayerName;
            lblPlayer.Tag = NewPlayerTag;
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
            if (ContinuePlaying)
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
