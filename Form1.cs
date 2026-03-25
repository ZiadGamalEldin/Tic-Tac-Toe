using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;
using TicTacToe.Properties;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        private byte _NumberOfRows; //=> Is also the number of columns
        private byte _SpaceBetweenTwoCells;
        private byte _CellHeight;
        private byte _CellWidth;
        private Point _LocationOfTheFirstCell;


        public Form1(string Player1Name , char Player1Symbol , string Player2Name , char Player2Symbol , byte NumberOfRows , byte SpaceBetweenTwoCells , byte CellHeight , byte CellWidth , Point LocationOfTheFirstCell ,byte Rounds , bool VsPC , Form2.enDifficulty Difficulty)
        {
         
            InitializeComponent();

            _NumberOfRows= NumberOfRows;
            _SpaceBetweenTwoCells = SpaceBetweenTwoCells;
            _CellHeight= CellHeight;
            _CellWidth= CellWidth;
            _LocationOfTheFirstCell = LocationOfTheFirstCell;


            _Cells = new PictureBox[ NumberOfRows , NumberOfRows];
            
           
            Game = new clsTicTacToe(NumberOfRows , Player1Name,     Player1Symbol, Player2Name, Player2Symbol , Rounds , VsPC , (clsTicTacToe.enDifficulty)Difficulty);

        }

        

        PictureBox[,] _Cells ;
        TicTacToe.clsTicTacToe Game;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Purple, _SpaceBetweenTwoCells / 4f))
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                Graphics g = e.Graphics;


                int Vy1 = (int)(_LocationOfTheFirstCell.Y - (0.5f * _SpaceBetweenTwoCells));
                int Vy2 = (int)(_LocationOfTheFirstCell.Y + _NumberOfRows * _CellHeight + 0.5f * _SpaceBetweenTwoCells + (_NumberOfRows - 1) * _SpaceBetweenTwoCells);

                int Hx1 = (int)(_LocationOfTheFirstCell.X - (0.5f * _SpaceBetweenTwoCells));
                int Hx2 = (int)(_LocationOfTheFirstCell.X + _NumberOfRows * _CellWidth + 0.5f * _SpaceBetweenTwoCells + (_NumberOfRows - 1) * _SpaceBetweenTwoCells);


                for (byte j = 0; j < _NumberOfRows - 1; j++)
                {
                    int Vx = (int)(_LocationOfTheFirstCell.X + ((_CellWidth + 0.5f * _SpaceBetweenTwoCells) * (j + 1)) + j * (0.5f * _SpaceBetweenTwoCells));
                    int Hy = (int)(_LocationOfTheFirstCell.Y + ((_CellHeight + 0.5f * _SpaceBetweenTwoCells) * (j + 1)) + j * (0.5f * _SpaceBetweenTwoCells));

                    g.DrawLine(pen, Vx, Vy1, Vx, Vy2);
                    g.DrawLine(pen, Hx1, Hy, Hx2, Hy);
                }
            }
        }

        private Point CalculateCellLocation(Point LocationUsedForFirstCell , byte i , byte j , byte Width , byte Height , byte SpaceBetweenTwoCells)
        {
            int x = 0;
            int y = 0;

            x = (LocationUsedForFirstCell.X + (Width + SpaceBetweenTwoCells) * j);
            y = (LocationUsedForFirstCell.Y + (Height+ SpaceBetweenTwoCells) * i);

            return new Point(x, y);
        }

        private void PrepareCells(Point LocationOfTheFirstCell , byte CellWidth , byte CellHeight , byte SpaceBetweenTwoCells)
        {
            PictureBox pictureBox = new PictureBox();
            int pictureBoxNum = 1;
            for(byte i = 0; i < _Cells.GetLength(0); i++)
            {
                for (byte j = 0; j < _Cells.GetLength(0); j++)
                {
                    pictureBox = CreatePictureBox(i , j ,pictureBoxNum, LocationOfTheFirstCell, CellWidth, CellHeight , $"{i},{j}" , SpaceBetweenTwoCells);
                    _Cells[i, j] = pictureBox;
                    this.Controls.Add(pictureBox);

                    pictureBoxNum++;
                }
            }
        }

        private PictureBox CreatePictureBox(byte i , byte j , int num,Point LocationOfTheFirstCell, byte Width , byte Height , string Tag , byte SpaceBetweenTwoCells)
        {
            PictureBox pictureBox = new PictureBox();
          
            pictureBox.BackColor = System.Drawing.Color.Transparent;
          //pictureBox.Image =Resources.question_mark_96;
            pictureBox.Location = CalculateCellLocation(LocationOfTheFirstCell , i , j , Width , Height , SpaceBetweenTwoCells );
            pictureBox.Size = new System.Drawing.Size(Width , Height);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = num-1;
            pictureBox.Tag = new Point(i,j);
          //pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Click += new System.EventHandler(this.Cell_Clicked);

            return pictureBox;
        }

        private void ColorizeLeftDiagonal(char PlayerSymbol)
        {
            for (int i = 0; i < _NumberOfRows; i++)
            {
                _Cells[i , i] .Image = (PlayerSymbol == 'X') ? Resources.Xwin : Resources.Owin;
                _Cells[i , i] .BackColor = Color.FromArgb(180,255,215,0);
            }
        }

        private void ColorizeRightDiagonal(char PlayerSymbol)
        {
            for (byte i = 0, j = (byte)(_NumberOfRows -1); i < _NumberOfRows && j >= 0; i++, j--)
            {
                _Cells[i,j].Image = (PlayerSymbol == 'X') ? Resources.Xwin : Resources.Owin;
                _Cells[i,j].BackColor = Color.FromArgb(180, 255, 215, 0);
            }
        }

        private void ColorizeHorizontalDimention(byte H_DimintionNumber , char PlayerSymbol)
        {
            for(byte j = 0; j < _NumberOfRows; j++)
            {
                _Cells[H_DimintionNumber, j].Image = (PlayerSymbol == 'X') ? Resources.Xwin : Resources.Owin;
                _Cells[H_DimintionNumber, j].BackColor = Color.FromArgb(180, 255, 215, 0);
            }
        }

        private void ColorizeVerticalDimention(byte V_DimintionNumber , char PlayerSymbol)
        {
            for (byte i = 0; i < _NumberOfRows; i++)
            {
                _Cells[i, V_DimintionNumber].Image = (PlayerSymbol == 'X') ? Resources.Xwin : Resources.Owin;
                _Cells[i, V_DimintionNumber].BackColor = Color.FromArgb(180, 255, 215, 0);
            }
        }

        private void ColorizeMatchedSympols(byte x, byte y, char PlayerSymbol ,clsTicTacToe.enWinningLine MatchType)
        {
            switch (MatchType)
            {
                case clsTicTacToe.enWinningLine.LeftDiagonal:
                    ColorizeLeftDiagonal(PlayerSymbol);
                    break;
                case clsTicTacToe.enWinningLine.RightDiagonal:
                    ColorizeRightDiagonal(PlayerSymbol);
                    break;
                case clsTicTacToe.enWinningLine.Horizontal:
                    ColorizeHorizontalDimention(x , PlayerSymbol);
                    break;
                case clsTicTacToe.enWinningLine.Vertical:
                    ColorizeVerticalDimention(y , PlayerSymbol);
                    break;
            }
        }

        private void DisableAllCells()
        {
            for (byte i = 0; i < _Cells.GetLength(0); i++)
            {
                for(byte j = 0 ; j < _Cells.GetLength(0); j++)
                {
                    _Cells[i , j].Enabled = false;
                }
            }
        }

        private void ResetAllCells()
        {
            for (byte i = 0; i < _Cells.GetLength(0); i++)
            {
                for(byte j = 0 ; j < _Cells.GetLength(0); j++)
                {
                    _Cells[i , j].Enabled = true;
                    _Cells[i,j].BackColor = Color.Transparent;
                    _Cells[i,j].Image = null;
                }
            }
        }


        private void UpdatePlayersWinCount()
        {
            lblPlayer1WinCount.Text = Game.Player1WinCount.ToString();
            lblPlayer2WinCount.Text = Game.Player2WinCount.ToString();

        }

       
        private clsTicTacToe.enMoveResult PlayPCMoveAndShowResults()
        {
            clsTicTacToe.stIndex IndexChoosenByPC =  Game.GetChoosenIndexByPC();

            return PlayMoveAndShowResults(IndexChoosenByPC.i, IndexChoosenByPC.j);

        }


       private clsTicTacToe.enMoveResult PlayMoveAndShowResults(byte i , byte j)
       {
            char PlayerSymbol = Game.CurrentPlayerSymbol;

            switch (Game.PlayMove(i, j))
            {
                case clsTicTacToe.enMoveResult.Failed:
                    MessageBox.Show("Something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return clsTicTacToe.enMoveResult.Failed;
                case clsTicTacToe.enMoveResult.InProgress:
                    _Cells[i,j].Image = PlayerSymbol == 'X' ? Resources.X : Resources.O;
                    _Cells[i, j].Enabled = false;
                    lblPlayerName.Text = Game.CurrentPlayerName;
                    return clsTicTacToe.enMoveResult.InProgress;
                case clsTicTacToe.enMoveResult.WinRound:
                    btnNextRound.Enabled = true;
                    _Cells[i,j].Image = PlayerSymbol == 'X' ? Resources.X : Resources.O;
                    DisableAllCells();
                    ColorizeMatchedSympols(i ,j ,PlayerSymbol ,Game.WinningLine);
                    lblPlayerName.Text = "Round is over";
                    lblWinnerName.Text = Game.RoundWinnerName;
                    UpdatePlayersWinCount();
                    return clsTicTacToe.enMoveResult.WinRound;
                case clsTicTacToe.enMoveResult.DrawRound:
                    btnNextRound.Enabled = true;
                    _Cells[i,j].Image = PlayerSymbol == 'X' ? Resources.X : Resources.O;
                    DisableAllCells();
                    lblPlayerName.Text = "Round is over";
                    lblWinnerName.Text = "Draw";
                    return clsTicTacToe.enMoveResult.DrawRound;
            }


            return clsTicTacToe.enMoveResult.Failed;

       }

        private void Cell_Clicked(object sender, EventArgs e)
        {
            Point p = (Point)((PictureBox)sender).Tag;

            clsTicTacToe.enMoveResult Result = PlayMoveAndShowResults((byte)p.X, (byte)p.Y);

            if( Result == clsTicTacToe.enMoveResult.Failed)
            {
                return;
            }

            
            if(Game.VsPc  && Result == clsTicTacToe.enMoveResult.InProgress && !Game.GameOver)      
            {
                Result = PlayPCMoveAndShowResults();
            }






            if (Game.GameOver)
            {
                string MessageBody = Game.FinalWinnerName == "Draw" ? "Final Result is Draw" : "Congratulations " + Game.FinalWinnerName + " you are the winner";
                if (MessageBox.Show(MessageBody, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();

                }
            }



        }  
 
        private void BeginNextRound()
        {
            btnNextRound.Enabled = false;
            Game.BeginNextRound();

            ResetAllCells();

            lblPlayerName.Text = Game.CurrentPlayerName;
            lblWinnerName.Text = "In Progress";
            lblRoundNumber.Text = Game.CurrentRoundNumber.ToString();
        }

        private void btnNextRound_Clicked(object sender, EventArgs e)
        {
            BeginNextRound();
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            PrepareCells(_LocationOfTheFirstCell,_CellWidth,_CellHeight,_SpaceBetweenTwoCells);

            lblRoundNumber.Text = Game.CurrentRoundNumber.ToString();
            lblPlayer1Name.Text = Game.Player1Name;
            lblPlayer2Name.Text = Game.Player2Name;
            lblPlayer1WinCount.Text = Game.Player1WinCount.ToString();
            lblPlayer2WinCount.Text = Game.Player2WinCount.ToString();
            lblPlayerName.Text = Game.CurrentPlayerName;
            lblWinnerName.Text = "In Progress";
            btnNextRound.Enabled = false;
        }
    }
}