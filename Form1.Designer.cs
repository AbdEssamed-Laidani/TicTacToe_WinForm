namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMainBackground = new System.Windows.Forms.PictureBox();
            this.TicTacToeTitle = new System.Windows.Forms.Label();
            this.lblTurnTitle = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblWinnerTitle = new System.Windows.Forms.Label();
            this.lblGameWinner = new System.Windows.Forms.Label();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.gbGameBoard = new System.Windows.Forms.GroupBox();
            this.pbCell9 = new System.Windows.Forms.PictureBox();
            this.pbCell6 = new System.Windows.Forms.PictureBox();
            this.pbCell3 = new System.Windows.Forms.PictureBox();
            this.pbCell8 = new System.Windows.Forms.PictureBox();
            this.pbCell5 = new System.Windows.Forms.PictureBox();
            this.pbCell2 = new System.Windows.Forms.PictureBox();
            this.pbCell7 = new System.Windows.Forms.PictureBox();
            this.pbCell4 = new System.Windows.Forms.PictureBox();
            this.pbCell1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainBackground)).BeginInit();
            this.gbGameBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMainBackground
            // 
            this.pbMainBackground.Image = global::TicTacToe.Properties.Resources.Background;
            this.pbMainBackground.Location = new System.Drawing.Point(-101, -48);
            this.pbMainBackground.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMainBackground.Name = "pbMainBackground";
            this.pbMainBackground.Size = new System.Drawing.Size(1247, 676);
            this.pbMainBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMainBackground.TabIndex = 0;
            this.pbMainBackground.TabStop = false;
            // 
            // TicTacToeTitle
            // 
            this.TicTacToeTitle.AutoSize = true;
            this.TicTacToeTitle.BackColor = System.Drawing.Color.Fuchsia;
            this.TicTacToeTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TicTacToeTitle.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicTacToeTitle.Location = new System.Drawing.Point(476, 22);
            this.TicTacToeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TicTacToeTitle.Name = "TicTacToeTitle";
            this.TicTacToeTitle.Size = new System.Drawing.Size(389, 52);
            this.TicTacToeTitle.TabIndex = 1;
            this.TicTacToeTitle.Text = "Tic Tac Toe Game";
            // 
            // lblTurnTitle
            // 
            this.lblTurnTitle.AutoSize = true;
            this.lblTurnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(61)))));
            this.lblTurnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTurnTitle.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTurnTitle.Location = new System.Drawing.Point(23, 116);
            this.lblTurnTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnTitle.Name = "lblTurnTitle";
            this.lblTurnTitle.Size = new System.Drawing.Size(115, 52);
            this.lblTurnTitle.TabIndex = 16;
            this.lblTurnTitle.Text = "Turn";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(61)))));
            this.lblPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.Color.Linen;
            this.lblPlayer.Location = new System.Drawing.Point(48, 194);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(138, 38);
            this.lblPlayer.TabIndex = 17;
            this.lblPlayer.Tag = "X";
            this.lblPlayer.Text = "Player 1";
            // 
            // lblWinnerTitle
            // 
            this.lblWinnerTitle.AutoSize = true;
            this.lblWinnerTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(2)))), ((int)(((byte)(53)))));
            this.lblWinnerTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWinnerTitle.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerTitle.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblWinnerTitle.Location = new System.Drawing.Point(23, 289);
            this.lblWinnerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWinnerTitle.Name = "lblWinnerTitle";
            this.lblWinnerTitle.Size = new System.Drawing.Size(163, 52);
            this.lblWinnerTitle.TabIndex = 18;
            this.lblWinnerTitle.Text = "Winner";
            // 
            // lblGameWinner
            // 
            this.lblGameWinner.AutoSize = true;
            this.lblGameWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(2)))), ((int)(((byte)(53)))));
            this.lblGameWinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGameWinner.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameWinner.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGameWinner.Location = new System.Drawing.Point(48, 363);
            this.lblGameWinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameWinner.Name = "lblGameWinner";
            this.lblGameWinner.Size = new System.Drawing.Size(187, 38);
            this.lblGameWinner.TabIndex = 19;
            this.lblGameWinner.Tag = "X";
            this.lblGameWinner.Text = "In Progress";
            // 
            // btnResetGame
            // 
            this.btnResetGame.BackColor = System.Drawing.Color.SlateBlue;
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.ForeColor = System.Drawing.Color.Black;
            this.btnResetGame.Location = new System.Drawing.Point(69, 447);
            this.btnResetGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(241, 68);
            this.btnResetGame.TabIndex = 20;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = false;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // gbGameBoard
            // 
            this.gbGameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(2)))), ((int)(((byte)(53)))));
            this.gbGameBoard.Controls.Add(this.pbCell9);
            this.gbGameBoard.Controls.Add(this.pbCell6);
            this.gbGameBoard.Controls.Add(this.pbCell3);
            this.gbGameBoard.Controls.Add(this.pbCell8);
            this.gbGameBoard.Controls.Add(this.pbCell5);
            this.gbGameBoard.Controls.Add(this.pbCell2);
            this.gbGameBoard.Controls.Add(this.pbCell7);
            this.gbGameBoard.Controls.Add(this.pbCell4);
            this.gbGameBoard.Controls.Add(this.pbCell1);
            this.gbGameBoard.Location = new System.Drawing.Point(491, 98);
            this.gbGameBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGameBoard.Name = "gbGameBoard";
            this.gbGameBoard.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbGameBoard.Size = new System.Drawing.Size(536, 428);
            this.gbGameBoard.TabIndex = 21;
            this.gbGameBoard.TabStop = false;
            // 
            // pbCell9
            // 
            this.pbCell9.BackColor = System.Drawing.Color.Indigo;
            this.pbCell9.Image = ((System.Drawing.Image)(resources.GetObject("pbCell9.Image")));
            this.pbCell9.Location = new System.Drawing.Point(376, 298);
            this.pbCell9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell9.Name = "pbCell9";
            this.pbCell9.Size = new System.Drawing.Size(121, 87);
            this.pbCell9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell9.TabIndex = 15;
            this.pbCell9.TabStop = false;
            this.pbCell9.Tag = "9";
            this.pbCell9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell6
            // 
            this.pbCell6.BackColor = System.Drawing.Color.Indigo;
            this.pbCell6.Image = ((System.Drawing.Image)(resources.GetObject("pbCell6.Image")));
            this.pbCell6.Location = new System.Drawing.Point(376, 172);
            this.pbCell6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell6.Name = "pbCell6";
            this.pbCell6.Size = new System.Drawing.Size(121, 87);
            this.pbCell6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell6.TabIndex = 14;
            this.pbCell6.TabStop = false;
            this.pbCell6.Tag = "6";
            this.pbCell6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell3
            // 
            this.pbCell3.BackColor = System.Drawing.Color.Indigo;
            this.pbCell3.Image = ((System.Drawing.Image)(resources.GetObject("pbCell3.Image")));
            this.pbCell3.Location = new System.Drawing.Point(376, 42);
            this.pbCell3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell3.Name = "pbCell3";
            this.pbCell3.Size = new System.Drawing.Size(121, 87);
            this.pbCell3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell3.TabIndex = 13;
            this.pbCell3.TabStop = false;
            this.pbCell3.Tag = "3";
            this.pbCell3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell8
            // 
            this.pbCell8.BackColor = System.Drawing.Color.Indigo;
            this.pbCell8.Image = ((System.Drawing.Image)(resources.GetObject("pbCell8.Image")));
            this.pbCell8.Location = new System.Drawing.Point(216, 298);
            this.pbCell8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell8.Name = "pbCell8";
            this.pbCell8.Size = new System.Drawing.Size(121, 87);
            this.pbCell8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell8.TabIndex = 12;
            this.pbCell8.TabStop = false;
            this.pbCell8.Tag = "8";
            this.pbCell8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell5
            // 
            this.pbCell5.BackColor = System.Drawing.Color.Indigo;
            this.pbCell5.Image = ((System.Drawing.Image)(resources.GetObject("pbCell5.Image")));
            this.pbCell5.Location = new System.Drawing.Point(216, 172);
            this.pbCell5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell5.Name = "pbCell5";
            this.pbCell5.Size = new System.Drawing.Size(121, 87);
            this.pbCell5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell5.TabIndex = 11;
            this.pbCell5.TabStop = false;
            this.pbCell5.Tag = "5";
            this.pbCell5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell2
            // 
            this.pbCell2.BackColor = System.Drawing.Color.Indigo;
            this.pbCell2.Image = ((System.Drawing.Image)(resources.GetObject("pbCell2.Image")));
            this.pbCell2.Location = new System.Drawing.Point(216, 42);
            this.pbCell2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell2.Name = "pbCell2";
            this.pbCell2.Size = new System.Drawing.Size(121, 87);
            this.pbCell2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell2.TabIndex = 10;
            this.pbCell2.TabStop = false;
            this.pbCell2.Tag = "2";
            this.pbCell2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell7
            // 
            this.pbCell7.BackColor = System.Drawing.Color.Indigo;
            this.pbCell7.Image = ((System.Drawing.Image)(resources.GetObject("pbCell7.Image")));
            this.pbCell7.Location = new System.Drawing.Point(55, 298);
            this.pbCell7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell7.Name = "pbCell7";
            this.pbCell7.Size = new System.Drawing.Size(121, 87);
            this.pbCell7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell7.TabIndex = 9;
            this.pbCell7.TabStop = false;
            this.pbCell7.Tag = "7";
            this.pbCell7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell4
            // 
            this.pbCell4.BackColor = System.Drawing.Color.Indigo;
            this.pbCell4.Image = ((System.Drawing.Image)(resources.GetObject("pbCell4.Image")));
            this.pbCell4.Location = new System.Drawing.Point(55, 172);
            this.pbCell4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell4.Name = "pbCell4";
            this.pbCell4.Size = new System.Drawing.Size(121, 87);
            this.pbCell4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell4.TabIndex = 8;
            this.pbCell4.TabStop = false;
            this.pbCell4.Tag = "4";
            this.pbCell4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // pbCell1
            // 
            this.pbCell1.BackColor = System.Drawing.Color.Indigo;
            this.pbCell1.Image = ((System.Drawing.Image)(resources.GetObject("pbCell1.Image")));
            this.pbCell1.Location = new System.Drawing.Point(55, 42);
            this.pbCell1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCell1.Name = "pbCell1";
            this.pbCell1.Size = new System.Drawing.Size(121, 87);
            this.pbCell1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCell1.TabIndex = 7;
            this.pbCell1.TabStop = false;
            this.pbCell1.Tag = "1";
            this.pbCell1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_Changed);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.gbGameBoard);
            this.materialCard1.Controls.Add(this.btnResetGame);
            this.materialCard1.Controls.Add(this.lblGameWinner);
            this.materialCard1.Controls.Add(this.lblWinnerTitle);
            this.materialCard1.Controls.Add(this.lblPlayer);
            this.materialCard1.Controls.Add(this.lblTurnTitle);
            this.materialCard1.Controls.Add(this.TicTacToeTitle);
            this.materialCard1.Controls.Add(this.pbMainBackground);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.materialCard1.Size = new System.Drawing.Size(1067, 554);
            this.materialCard1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.materialCard1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pbMainBackground)).EndInit();
            this.gbGameBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCell9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCell1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMainBackground;
        private System.Windows.Forms.Label TicTacToeTitle;
        private System.Windows.Forms.Label lblTurnTitle;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblWinnerTitle;
        private System.Windows.Forms.Label lblGameWinner;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.GroupBox gbGameBoard;
        private System.Windows.Forms.PictureBox pbCell9;
        private System.Windows.Forms.PictureBox pbCell6;
        private System.Windows.Forms.PictureBox pbCell3;
        private System.Windows.Forms.PictureBox pbCell8;
        private System.Windows.Forms.PictureBox pbCell5;
        private System.Windows.Forms.PictureBox pbCell2;
        private System.Windows.Forms.PictureBox pbCell7;
        private System.Windows.Forms.PictureBox pbCell4;
        private System.Windows.Forms.PictureBox pbCell1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}

