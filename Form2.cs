using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private enum enOpponent : byte {enEmpty , enMultiplayer , enPlayerVsPC}
        private enOpponent _Opponent;


        public enum enDifficulty : byte {enNone , enEasy , enMedium , enHard}
        private enDifficulty _Difficulty;

        private byte _Size;
        private byte _Rounds;
        private void Form2_Load(object sender, EventArgs e)
        {
            rbMultiplayer.Checked = true;
            txtPlayer1Name.Text = "Player 1";
            txtPlayer2Name.Text = "Player 2";

            _Difficulty = enDifficulty.enEasy;
            btnEasy.Enabled = false;

            gbDifficulty.Enabled = false;

            rb3X3.Checked = true;

            nudRounds.Value = new decimal(new int[] {1,0,0,0});
            _Rounds = (byte)nudRounds.Value;
        }

        private void Opponent_CheckedChanged(object sender , EventArgs e)
        {
            RadioButton b = sender as RadioButton;

            if (!b.Checked)
                return;

            if(b == rbMultiplayer)
            {
                txtPlayer2Name.Text = "";
                txtPlayer2Name.Enabled = true;
                _Opponent = enOpponent.enMultiplayer;
                gbDifficulty.Enabled = false;
            }
            else
            {
                txtPlayer2Name.Text = "PC";
                txtPlayer2Name.Enabled = false;
                _Opponent = enOpponent.enPlayerVsPC;
                gbDifficulty.Enabled = true;
            }
        }


        private void Difficulty_Clicked(object sender , EventArgs e)
        {
            Button button = sender as Button;

            if (button == btnEasy)
            {
                _Difficulty = enDifficulty.enEasy;
                btnMedium.Enabled = true;
                btnHard.Enabled = true;
            }
            else if (button == btnMedium)
            {
                _Difficulty = enDifficulty.enMedium;
                btnEasy.Enabled = true;
                btnHard.Enabled = true;
            }
            else
            {
                _Difficulty = enDifficulty.enHard;
                btnEasy.Enabled = true;
                btnMedium.Enabled = true;
            }
                button.Enabled = false;
        }


        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
                return;

            _Size = Convert.ToByte(((RadioButton)sender).Tag);
        }

        private void Rounds_ValueChanged(object sender, EventArgs e)
        {
            _Rounds = (byte)((NumericUpDown)sender).Value;

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(txtPlayer1Name.Text.Trim() == "" || txtPlayer2Name.Text.Trim() == "")
            {
                MessageBox.Show("Both player names must be entered." , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Opponent == enOpponent.enEmpty)
            {
                MessageBox.Show("You must Choose your Opponent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_Opponent == enOpponent.enPlayerVsPC && _Difficulty == enDifficulty.enNone )
            {
                MessageBox.Show("You must Choose Difficulty Level", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(_Size<=0)
            {
                MessageBox.Show("You must Set the board Size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if(_Rounds<=0)
            {
                MessageBox.Show("You must Choose Rounds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            bool VsPC = (_Opponent == enOpponent.enPlayerVsPC)? true : false;
            
            Form1 f = new Form1(txtPlayer1Name.Text , 'X' , txtPlayer2Name.Text , 'O' , _Size , 30 , 60 , 60 , new Point (525 - ((_Size - 3) * 40), 200 - ((_Size - 3) * 55)) , (byte)nudRounds.Value , VsPC , _Difficulty);
            f.ShowDialog();
        }

       
    }
}
