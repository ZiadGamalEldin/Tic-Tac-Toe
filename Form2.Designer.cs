using System.Windows.Forms.PropertyGridInternal;
using TicTacToeUI.Properties;

namespace TicTacToe
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbPlayersInfo = new System.Windows.Forms.GroupBox();
            this.lblVS = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbOpponent = new System.Windows.Forms.GroupBox();
            this.rbPlayerVsPC = new System.Windows.Forms.RadioButton();
            this.rbMultiplayer = new System.Windows.Forms.RadioButton();
            this.gbDifficulty = new System.Windows.Forms.GroupBox();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.gbBoardSize = new System.Windows.Forms.GroupBox();
            this.rb5x5 = new System.Windows.Forms.RadioButton();
            this.rb4x4 = new System.Windows.Forms.RadioButton();
            this.rb3X3 = new System.Windows.Forms.RadioButton();
            this.gbRounds = new System.Windows.Forms.GroupBox();
            this.nudRounds = new System.Windows.Forms.NumericUpDown();
            this.btnPlay = new System.Windows.Forms.Button();
            this.gbPlayersInfo.SuspendLayout();
            this.gbOpponent.SuspendLayout();
            this.gbDifficulty.SuspendLayout();
            this.gbBoardSize.SuspendLayout();
            this.gbRounds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayersInfo
            // 
            this.gbPlayersInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbPlayersInfo.Controls.Add(this.lblVS);
            this.gbPlayersInfo.Controls.Add(this.lblPlayer2Name);
            this.gbPlayersInfo.Controls.Add(this.lblPlayer1Name);
            this.gbPlayersInfo.Controls.Add(this.txtPlayer2Name);
            this.gbPlayersInfo.Controls.Add(this.txtPlayer1Name);
            this.gbPlayersInfo.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayersInfo.ForeColor = System.Drawing.Color.Orange;
            this.gbPlayersInfo.Location = new System.Drawing.Point(56, 80);
            this.gbPlayersInfo.Name = "gbPlayersInfo";
            this.gbPlayersInfo.Size = new System.Drawing.Size(501, 111);
            this.gbPlayersInfo.TabIndex = 0;
            this.gbPlayersInfo.TabStop = false;
            this.gbPlayersInfo.Text = "Players Info";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.BackColor = System.Drawing.Color.Transparent;
            this.lblVS.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVS.ForeColor = System.Drawing.Color.Orange;
            this.lblVS.Location = new System.Drawing.Point(224, 62);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(54, 48);
            this.lblVS.TabIndex = 2;
            this.lblVS.Text = "VS";
            this.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer2Name.Location = new System.Drawing.Point(328, 42);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(125, 20);
            this.lblPlayer2Name.TabIndex = 3;
            this.lblPlayer2Name.Text = "2nd Player Name";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer1Name.Location = new System.Drawing.Point(51, 43);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(120, 20);
            this.lblPlayer1Name.TabIndex = 1;
            this.lblPlayer1Name.Text = "1st Player Name";
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.Location = new System.Drawing.Point(289, 69);
            this.txtPlayer2Name.MaxLength = 13;
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(202, 31);
            this.txtPlayer2Name.TabIndex = 2;
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(10, 69);
            this.txtPlayer1Name.MaxLength = 13;
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(202, 31);
            this.txtPlayer1Name.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Uighur", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Orange;
            this.lblTitle.Location = new System.Drawing.Point(203, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Game Setup";
            // 
            // gbOpponent
            // 
            this.gbOpponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbOpponent.Controls.Add(this.rbPlayerVsPC);
            this.gbOpponent.Controls.Add(this.rbMultiplayer);
            this.gbOpponent.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpponent.ForeColor = System.Drawing.Color.Orange;
            this.gbOpponent.Location = new System.Drawing.Point(56, 227);
            this.gbOpponent.Name = "gbOpponent";
            this.gbOpponent.Size = new System.Drawing.Size(501, 100);
            this.gbOpponent.TabIndex = 1;
            this.gbOpponent.TabStop = false;
            this.gbOpponent.Text = "Opponent";
            // 
            // rbPlayerVsPC
            // 
            this.rbPlayerVsPC.AutoSize = true;
            this.rbPlayerVsPC.BackColor = System.Drawing.Color.Transparent;
            this.rbPlayerVsPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rbPlayerVsPC.ForeColor = System.Drawing.Color.Orange;
            this.rbPlayerVsPC.Location = new System.Drawing.Point(307, 45);
            this.rbPlayerVsPC.Name = "rbPlayerVsPC";
            this.rbPlayerVsPC.Size = new System.Drawing.Size(154, 38);
            this.rbPlayerVsPC.TabIndex = 1;
            this.rbPlayerVsPC.Tag = "PlayerVsPC";
            this.rbPlayerVsPC.Text = "Player  Vs  PC";
            this.rbPlayerVsPC.UseVisualStyleBackColor = false;
            this.rbPlayerVsPC.CheckedChanged += new System.EventHandler(this.Opponent_CheckedChanged);
            // 
            // rbMultiplayer
            // 
            this.rbMultiplayer.AutoSize = true;
            this.rbMultiplayer.BackColor = System.Drawing.Color.Transparent;
            this.rbMultiplayer.ForeColor = System.Drawing.Color.Orange;
            this.rbMultiplayer.Location = new System.Drawing.Point(36, 45);
            this.rbMultiplayer.Name = "rbMultiplayer";
            this.rbMultiplayer.Size = new System.Drawing.Size(139, 38);
            this.rbMultiplayer.TabIndex = 0;
            this.rbMultiplayer.Tag = "Multiplayer";
            this.rbMultiplayer.Text = "Multiplayer";
            this.rbMultiplayer.UseVisualStyleBackColor = false;
            this.rbMultiplayer.CheckedChanged += new System.EventHandler(this.Opponent_CheckedChanged);
            // 
            // gbDifficulty
            // 
            this.gbDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbDifficulty.Controls.Add(this.btnHard);
            this.gbDifficulty.Controls.Add(this.btnMedium);
            this.gbDifficulty.Controls.Add(this.btnEasy);
            this.gbDifficulty.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDifficulty.ForeColor = System.Drawing.Color.Orange;
            this.gbDifficulty.Location = new System.Drawing.Point(56, 362);
            this.gbDifficulty.Name = "gbDifficulty";
            this.gbDifficulty.Size = new System.Drawing.Size(501, 111);
            this.gbDifficulty.TabIndex = 2;
            this.gbDifficulty.TabStop = false;
            this.gbDifficulty.Text = "Difficulty";
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(71)))));
            this.btnHard.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnHard.FlatAppearance.BorderSize = 2;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.ForeColor = System.Drawing.Color.Black;
            this.btnHard.Location = new System.Drawing.Point(369, 48);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(112, 46);
            this.btnHard.TabIndex = 2;
            this.btnHard.Tag = "Hard";
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.Difficulty_Clicked);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(77)))));
            this.btnMedium.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnMedium.FlatAppearance.BorderSize = 2;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.ForeColor = System.Drawing.Color.Black;
            this.btnMedium.Location = new System.Drawing.Point(194, 48);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(112, 46);
            this.btnMedium.TabIndex = 1;
            this.btnMedium.Tag = "Medium";
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.Difficulty_Clicked);
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(255)))), ((int)(((byte)(137)))));
            this.btnEasy.FlatAppearance.BorderColor = System.Drawing.Color.Indigo;
            this.btnEasy.FlatAppearance.BorderSize = 2;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.ForeColor = System.Drawing.Color.Black;
            this.btnEasy.Location = new System.Drawing.Point(19, 48);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(112, 46);
            this.btnEasy.TabIndex = 0;
            this.btnEasy.Tag = "Easy";
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.Difficulty_Clicked);
            // 
            // gbBoardSize
            // 
            this.gbBoardSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbBoardSize.Controls.Add(this.rb5x5);
            this.gbBoardSize.Controls.Add(this.rb4x4);
            this.gbBoardSize.Controls.Add(this.rb3X3);
            this.gbBoardSize.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBoardSize.ForeColor = System.Drawing.Color.Orange;
            this.gbBoardSize.Location = new System.Drawing.Point(56, 509);
            this.gbBoardSize.Name = "gbBoardSize";
            this.gbBoardSize.Size = new System.Drawing.Size(354, 106);
            this.gbBoardSize.TabIndex = 3;
            this.gbBoardSize.TabStop = false;
            this.gbBoardSize.Text = "Board Size";
            // 
            // rb5x5
            // 
            this.rb5x5.AutoSize = true;
            this.rb5x5.BackColor = System.Drawing.Color.Transparent;
            this.rb5x5.ForeColor = System.Drawing.Color.Orange;
            this.rb5x5.Location = new System.Drawing.Point(270, 47);
            this.rb5x5.Name = "rb5x5";
            this.rb5x5.Size = new System.Drawing.Size(76, 38);
            this.rb5x5.TabIndex = 2;
            this.rb5x5.Tag = "5";
            this.rb5x5.Text = "5 x 5";
            this.rb5x5.UseVisualStyleBackColor = false;
            this.rb5x5.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // rb4x4
            // 
            this.rb4x4.AutoSize = true;
            this.rb4x4.BackColor = System.Drawing.Color.Transparent;
            this.rb4x4.ForeColor = System.Drawing.Color.Orange;
            this.rb4x4.Location = new System.Drawing.Point(139, 47);
            this.rb4x4.Name = "rb4x4";
            this.rb4x4.Size = new System.Drawing.Size(76, 38);
            this.rb4x4.TabIndex = 1;
            this.rb4x4.Tag = "4";
            this.rb4x4.Text = "4 x 4";
            this.rb4x4.UseVisualStyleBackColor = false;
            this.rb4x4.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // rb3X3
            // 
            this.rb3X3.AutoSize = true;
            this.rb3X3.BackColor = System.Drawing.Color.Transparent;
            this.rb3X3.ForeColor = System.Drawing.Color.Orange;
            this.rb3X3.Location = new System.Drawing.Point(8, 47);
            this.rb3X3.Name = "rb3X3";
            this.rb3X3.Size = new System.Drawing.Size(76, 38);
            this.rb3X3.TabIndex = 0;
            this.rb3X3.Tag = "3";
            this.rb3X3.Text = "3 x 3";
            this.rb3X3.UseVisualStyleBackColor = false;
            this.rb3X3.CheckedChanged += new System.EventHandler(this.Size_CheckedChanged);
            // 
            // gbRounds
            // 
            this.gbRounds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gbRounds.Controls.Add(this.nudRounds);
            this.gbRounds.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRounds.ForeColor = System.Drawing.Color.Orange;
            this.gbRounds.Location = new System.Drawing.Point(443, 509);
            this.gbRounds.Name = "gbRounds";
            this.gbRounds.Size = new System.Drawing.Size(114, 106);
            this.gbRounds.TabIndex = 4;
            this.gbRounds.TabStop = false;
            this.gbRounds.Text = "Rounds";
            // 
            // nudRounds
            // 
            this.nudRounds.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRounds.Location = new System.Drawing.Point(24, 48);
            this.nudRounds.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRounds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRounds.Name = "nudRounds";
            this.nudRounds.Size = new System.Drawing.Size(66, 38);
            this.nudRounds.TabIndex = 0;
            this.nudRounds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRounds.ValueChanged += new System.EventHandler(this.Rounds_ValueChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Orange;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Purple;
            this.btnPlay.Location = new System.Drawing.Point(217, 663);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(179, 66);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.ChatGPT_Image_Mar_17__2026__04_21_54_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(613, 762);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gbRounds);
            this.Controls.Add(this.gbBoardSize);
            this.Controls.Add(this.gbDifficulty);
            this.Controls.Add(this.gbOpponent);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbPlayersInfo);
            this.ForeColor = System.Drawing.Color.Orange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Game Setup";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbPlayersInfo.ResumeLayout(false);
            this.gbPlayersInfo.PerformLayout();
            this.gbOpponent.ResumeLayout(false);
            this.gbOpponent.PerformLayout();
            this.gbDifficulty.ResumeLayout(false);
            this.gbBoardSize.ResumeLayout(false);
            this.gbBoardSize.PerformLayout();
            this.gbRounds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRounds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayersInfo;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.GroupBox gbOpponent;
        private System.Windows.Forms.RadioButton rbPlayerVsPC;
        private System.Windows.Forms.RadioButton rbMultiplayer;
        private System.Windows.Forms.GroupBox gbDifficulty;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.GroupBox gbBoardSize;
        private System.Windows.Forms.GroupBox gbRounds;
        private System.Windows.Forms.RadioButton rb3X3;
        private System.Windows.Forms.RadioButton rb5x5;
        private System.Windows.Forms.RadioButton rb4x4;
        private System.Windows.Forms.NumericUpDown nudRounds;
        private System.Windows.Forms.Button btnPlay;
    }
}