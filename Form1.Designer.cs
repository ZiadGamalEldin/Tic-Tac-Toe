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
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblWinnerName = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnNextRound = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblRoundNumber = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer2WinCount = new System.Windows.Forms.Label();
            this.lblPlayer1WinCount = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Transparent;
            this.lblTurn.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.Orange;
            this.lblTurn.Location = new System.Drawing.Point(90, 29);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(79, 39);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Text = "Turn";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Violet;
            this.lblPlayerName.Location = new System.Drawing.Point(31, 60);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPlayerName.Size = new System.Drawing.Size(196, 72);
            this.lblPlayerName.TabIndex = 11;
            this.lblPlayerName.Text = "Player Name";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinnerName
            // 
            this.lblWinnerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWinnerName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinnerName.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblWinnerName.Location = new System.Drawing.Point(28, 222);
            this.lblWinnerName.Name = "lblWinnerName";
            this.lblWinnerName.Size = new System.Drawing.Size(202, 72);
            this.lblWinnerName.TabIndex = 13;
            this.lblWinnerName.Text = "Winner Name";
            this.lblWinnerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblWinner.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Orange;
            this.lblWinner.Location = new System.Drawing.Point(73, 183);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(113, 39);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Text = "Winner";
            // 
            // btnNextRound
            // 
            this.btnNextRound.BackColor = System.Drawing.Color.Orange;
            this.btnNextRound.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRound.ForeColor = System.Drawing.Color.Purple;
            this.btnNextRound.Location = new System.Drawing.Point(31, 342);
            this.btnNextRound.Name = "btnNextRound";
            this.btnNextRound.Size = new System.Drawing.Size(197, 59);
            this.btnNextRound.TabIndex = 14;
            this.btnNextRound.Text = "Next Round";
            this.btnNextRound.UseVisualStyleBackColor = false;
            this.btnNextRound.Click += new System.EventHandler(this.btnNextRound_Clicked);
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.BackColor = System.Drawing.Color.Transparent;
            this.lblRound.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.Orange;
            this.lblRound.Location = new System.Drawing.Point(3, 7);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(67, 25);
            this.lblRound.TabIndex = 15;
            this.lblRound.Text = "Round:";
            // 
            // lblRoundNumber
            // 
            this.lblRoundNumber.AutoSize = true;
            this.lblRoundNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundNumber.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoundNumber.ForeColor = System.Drawing.Color.Orange;
            this.lblRoundNumber.Location = new System.Drawing.Point(67, 7);
            this.lblRoundNumber.Name = "lblRoundNumber";
            this.lblRoundNumber.Size = new System.Drawing.Size(20, 24);
            this.lblRoundNumber.TabIndex = 16;
            this.lblRoundNumber.Text = "0";
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.AutoSize = true;
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer1Name.Location = new System.Drawing.Point(3, 50);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(125, 25);
            this.lblPlayer1Name.TabIndex = 17;
            this.lblPlayer1Name.Text = "Player1Name:";
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.AutoSize = true;
            this.lblPlayer2Name.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer2Name.Location = new System.Drawing.Point(3, 93);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(125, 25);
            this.lblPlayer2Name.TabIndex = 18;
            this.lblPlayer2Name.Text = "Player2Name:";
            // 
            // lblPlayer2WinCount
            // 
            this.lblPlayer2WinCount.AutoSize = true;
            this.lblPlayer2WinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2WinCount.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2WinCount.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer2WinCount.Location = new System.Drawing.Point(128, 93);
            this.lblPlayer2WinCount.Name = "lblPlayer2WinCount";
            this.lblPlayer2WinCount.Size = new System.Drawing.Size(20, 24);
            this.lblPlayer2WinCount.TabIndex = 19;
            this.lblPlayer2WinCount.Text = "0";
            // 
            // lblPlayer1WinCount
            // 
            this.lblPlayer1WinCount.AutoSize = true;
            this.lblPlayer1WinCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1WinCount.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1WinCount.ForeColor = System.Drawing.Color.Orange;
            this.lblPlayer1WinCount.Location = new System.Drawing.Point(128, 50);
            this.lblPlayer1WinCount.Name = "lblPlayer1WinCount";
            this.lblPlayer1WinCount.Size = new System.Drawing.Size(20, 24);
            this.lblPlayer1WinCount.TabIndex = 20;
            this.lblPlayer1WinCount.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPlayer1WinCount);
            this.splitContainer1.Panel1.Controls.Add(this.lblRound);
            this.splitContainer1.Panel1.Controls.Add(this.lblPlayer2WinCount);
            this.splitContainer1.Panel1.Controls.Add(this.lblRoundNumber);
            this.splitContainer1.Panel1.Controls.Add(this.lblPlayer2Name);
            this.splitContainer1.Panel1.Controls.Add(this.lblPlayer1Name);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnNextRound);
            this.splitContainer1.Panel2.Controls.Add(this.lblTurn);
            this.splitContainer1.Panel2.Controls.Add(this.lblWinner);
            this.splitContainer1.Panel2.Controls.Add(this.lblPlayerName);
            this.splitContainer1.Panel2.Controls.Add(this.lblWinnerName);
            this.splitContainer1.Size = new System.Drawing.Size(258, 596);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Purple;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.ChatGPT_Image_Mar_17__2026__05_49_22_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 591);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblWinnerName;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnNextRound;
        private System.Windows.Forms.Label lblRoundNumber;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblPlayer1WinCount;
        private System.Windows.Forms.Label lblPlayer2WinCount;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

