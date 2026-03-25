using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class clsTicTacToe
    {
        private class clsPlayer
        {
            private string _Name;
            private char _Symbol;
            public byte WinCount;

            public string Name { get { return _Name; } }
            public char Symbol { get { return _Symbol; } }

            public clsPlayer(string Name, char Symbol)
            {
                _Name = Name;
                _Symbol = Symbol;
                WinCount = 0;
            }
        }

        private enum enCellState { Empty, X, O }

        public enum enDifficulty { None, Easy, Medium, Hard }
        public enum enMoveResult : byte { Failed, InProgress, WinRound, DrawRound }
        public enum enWinningLine : byte { None, LeftDiagonal, RightDiagonal, Vertical, Horizontal }

        private clsPlayer _Player1;
        private clsPlayer _Player2;
        private clsPlayer _CurrentPlayer;
        private clsPlayer _RoundWinner;
        private byte _Rounds;
        private byte _CurrentRoundNumber;
        private enWinningLine _WinningLine;
        private bool _GameOver;
        private bool _VsPC;
        private Random _Rand;
        private enDifficulty _Difficulty;
        private List<stIndex> _EmptyCellsIndexs;
        public bool VsPc { get { return _VsPC; } }
        public string Player1Name { get { return _Player1.Name; } }
        public string Player2Name { get { return _Player2.Name; } }
        public byte CurrentRoundNumber { get { return _CurrentRoundNumber; } }

        public string CurrentPlayerName
        {
            get { return _CurrentPlayer == null ? default : _CurrentPlayer.Name; }
        }

        public char CurrentPlayerSymbol
        {
            get { return _CurrentPlayer == null ? default : _CurrentPlayer.Symbol; }
        }

        public string RoundWinnerName
        {
            get { return _RoundWinner == null ? default : _RoundWinner.Name; }
        }

        public enWinningLine WinningLine { get { return _WinningLine; } }
        public byte Player1WinCount { get { return _Player1.WinCount; } }
        public byte Player2WinCount { get { return _Player2.WinCount; } }

        public string FinalWinnerName
        {
            get
            {
                if (_Player1.WinCount > _Player2.WinCount) return _Player1.Name;
                else if (_Player2.WinCount > _Player1.WinCount) return _Player2.Name;
                else return "Draw";
            }
        }

        public bool GameOver { get { return _GameOver; } }

        private enCellState[,] _Cells;

        public struct stIndex
        {
            private byte _i;
            private byte _j;

            public byte i { get { return _i; } }
            public byte j { get { return _j; } }

            public stIndex(byte i, byte j)
            {
                _i = i;
                _j = j;
            }
        }

        private List<stIndex> GetEmptyCellsIndexs()
        {
            List<stIndex> list = new List<stIndex>();
            byte n = (byte)_Cells.GetLength(0);

            for (byte i = 0; i < n; i++)
                for (byte j = 0; j < n; j++)
                    if (_Cells[i, j] == enCellState.Empty)
                        list.Add(new stIndex(i, j));

            return list;
        }


        public stIndex GetChoosenIndexByPC()
        {
            switch (_Difficulty)
            {
                case enDifficulty.Easy:
                    return GetEasyLevelIndex();

                case enDifficulty.Medium:
                    return GetMediumLevelIndex();

                default:
                    return GetHardLevelIndex();
            }
        }

        private stIndex GetEasyLevelIndex()
        {
            List <stIndex> empty = GetEmptyCellsIndexs();
            return empty[_Rand.Next(empty.Count)];
        }

        private enCellState CurrentPlayerCellState()
        {
            return _CurrentPlayer.Symbol == 'X' ? enCellState.X : enCellState.O;
        }

        private void ResetCells()
        {
            byte n = (byte)_Cells.GetLength(0);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    _Cells[i, j] = enCellState.Empty;
        }

        private void ChangeTurn()
        {
            if (_RoundWinner == null)
                _CurrentPlayer = _CurrentPlayer == _Player1 ? _Player2 : _Player1;
        }

        private bool IsCellOnLeftDiagonal(byte x, byte y) { return x == y; }

        private bool IsCellOnRightDiagonal(byte x, byte y)
        {
            byte n = (byte)_Cells.GetLength(0);
            return (x + y) == n - 1;
        }

        private bool LeftDiagonalMatch()
        {
            for (byte i = 0; i < _Cells.GetLength(0); i++)
                if (_Cells[i, i] != CurrentPlayerCellState())
                    return false;
            return true;
        }

        private bool RightDiagonalMatch()
        {
            byte n = (byte)_Cells.GetLength(0);
            for (byte i = 0; i < n; i++)
                if (_Cells[i, n - 1 - i] != CurrentPlayerCellState())
                    return false;
            return true;
        }

        private bool HorizontalMatch(byte x)
        {
            for (byte y = 0; y < _Cells.GetLength(0); y++)
                if (_Cells[x, y] != CurrentPlayerCellState())
                    return false;
            return true;
        }

        private bool VerticalMatch(byte y)
        {
            for (byte x = 0; x < _Cells.GetLength(0); x++)
                if (_Cells[x, y] != CurrentPlayerCellState())
                    return false;
            return true;
        }

        private bool CheckWinning(byte x, byte y ,out enWinningLine WinningLine)
        {
            if (IsCellOnLeftDiagonal(x, y) && LeftDiagonalMatch())
            {
                WinningLine = enWinningLine.LeftDiagonal;
                return true;
            }
            else if (IsCellOnRightDiagonal(x, y) && RightDiagonalMatch())
            {
                WinningLine = enWinningLine.RightDiagonal;
                return true;
            }
            else if (VerticalMatch(y))
            {
                WinningLine = enWinningLine.Vertical;
                return true;
            }
            else if (HorizontalMatch(x))
            {
                WinningLine = enWinningLine.Horizontal;
                return true;
            }

            WinningLine = enWinningLine.None;
            return false;
        }

        private bool DoesCurrentPlayerWin(byte x, byte y)
        {
            return CheckWinning(x, y ,out _WinningLine);
        }

        private bool AssignCell(byte x, byte y)
        {
            if (_CurrentPlayer == null) return false;

            if (_Cells[x, y] == enCellState.Empty)
            {
                _Cells[x, y] = CurrentPlayerCellState();
                return true;
            }
            return false;
        }

        public enMoveResult PlayMove(byte x, byte y)
        {
            if (_GameOver || !AssignCell(x, y))
                return enMoveResult.Failed;

            _EmptyCellsIndexs.RemoveAll(Cell=> Cell.i== x && Cell.j == y);

            if (DoesCurrentPlayerWin(x, y))
            {
                _CurrentPlayer.WinCount++;
                _RoundWinner = _CurrentPlayer;
                _CurrentPlayer = null;
                _GameOver = (_CurrentRoundNumber == _Rounds);
                return enMoveResult.WinRound;
            }

            if (CheckDraw())
            {
                _GameOver = (_CurrentRoundNumber == _Rounds);
                _CurrentPlayer = null;
                return enMoveResult.DrawRound;
            }

            ChangeTurn();
            return enMoveResult.InProgress;
        }

        public void BeginNextRound()
        {
            if (_GameOver) return;

            ResetCells();
            _EmptyCellsIndexs = GetEmptyCellsIndexs(); 
            _CurrentPlayer = _Player1;
            _RoundWinner = null;
            _WinningLine = enWinningLine.None;
            _CurrentRoundNumber++;
        }

        public bool CheckDraw()
        {
            if (_RoundWinner != null) return false;

            foreach (var cell in _Cells)
                if (cell == enCellState.Empty)
                    return false;

            return true;
        }

        public clsTicTacToe(byte GameSize, string Player1Name, char Player1Symbol,
                            string Player2Name, char Player2Symbol,
                            byte Rounds, bool VsPC, enDifficulty Difficulty)
        {
            _Player1 = new clsPlayer(Player1Name, Player1Symbol);
            _Player2 = new clsPlayer(Player2Name, Player2Symbol);
            _CurrentPlayer = _Player1;
            _Cells = new enCellState[GameSize, GameSize];
            _CurrentRoundNumber = 1;
            _Rounds = Rounds;
            _GameOver = false;
            _VsPC = VsPC;
            _Rand = new Random();
            _Difficulty = Difficulty;
            _EmptyCellsIndexs = GetEmptyCellsIndexs();
        }


        private List<(stIndex CellIndex, int CellScore)> GetEmptyCellsSortedDescendingByScore()
        {
            List<(stIndex CellIndex, int CellScore)> Scores = new List<(stIndex CellIndex, int Score)>();


            foreach (var CellIndex in _EmptyCellsIndexs)
            {
                Scores.Add((CellIndex, EvaluateCell(CellIndex.i, CellIndex.j)));
            }

            Scores.Sort((a, b) => b.CellScore.CompareTo(a.CellScore));

            return Scores;
        }


        private stIndex GetMediumLevelIndex()
        {
            if (_Rand.Next(100) < 10)
            {
                return _EmptyCellsIndexs[_Rand.Next(_EmptyCellsIndexs.Count)];
            }


            var Scores = GetEmptyCellsSortedDescendingByScore();

            byte Take = (byte)Math.Min(2, Scores.Count);

           return (_Rand.Next(100) < 40) ? Scores[0].CellIndex : Scores[_Rand.Next(Take)].CellIndex;

        }

        private stIndex GetHardLevelIndex()
        {
            var Scores = GetEmptyCellsSortedDescendingByScore();

            byte Take = (byte)Math.Min(2, Scores.Count);

            return (_Rand.Next(100) < 90) ? Scores[0].CellIndex: Scores[_Rand.Next(Take)].CellIndex;
        }


        private byte EvaluateCell(byte x, byte y)
        {
            byte score = 0;

            score += EvaluateRow(x);
            score += EvaluateColumn(y);

            if (IsCellOnLeftDiagonal(x, y))
                score += EvaluateLeftDiagonal();

            if (IsCellOnRightDiagonal(x, y))
                score += EvaluateRightDiagonal();



            return score;
        }

        private byte EvaluateRow(byte row)
        {
            byte pc = 0, human = 0;

            for (byte j = 0; j < _Cells.GetLength(0); j++)
            {
                if (_Cells[row, j] == CurrentPlayerCellState()) pc++;
                else if (_Cells[row, j] != enCellState.Empty) human++;
            }

            if (pc > 0 && human > 0) return 0;
            if (pc > 0) return (byte)(pc);
            if (human > 0) return (byte)(human * human * 2);
            return 1;
        }

        private byte EvaluateColumn(byte col)
        {
            byte pc = 0, human = 0;

            for (byte i = 0; i < _Cells.GetLength(0); i++)
            {
                if (_Cells[i, col] == CurrentPlayerCellState()) pc++;
                else if (_Cells[i, col] != enCellState.Empty) human++;
            }

            if (pc > 0 && human > 0) return 0;
            if (pc > 0) return (byte)(pc);
            if (human > 0) return (byte)(human * human * 2);
            return 1;
        }

        private byte EvaluateLeftDiagonal()
        {
            byte pc = 0, human = 0;

            for (byte i = 0; i < _Cells.GetLength(0); i++)
            {
                if (_Cells[i, i] == CurrentPlayerCellState()) pc++;
                else if (_Cells[i, i] != enCellState.Empty) human++;
            }

            if (pc > 0 && human > 0) return 0;
            if (pc > 0) return (byte)(pc);
            if (human > 0) return(byte)(human * human * 2);
            return 1;
        }

        private byte EvaluateRightDiagonal()
        {
            byte pc = 0, human = 0;
            byte n = (byte)_Cells.GetLength(0);

            for (byte i = 0; i < n; i++)
            {
                int j = n - 1 - i;

                if (_Cells[i, j] == CurrentPlayerCellState()) pc++;
                else if (_Cells[i, j] != enCellState.Empty) human++;
            }

            if (pc > 0 && human > 0) return 0;
            if (pc > 0) return (byte)(pc);
            if (human > 0) return(byte)(human*human * 2);
            return 1;
        }
    }
}