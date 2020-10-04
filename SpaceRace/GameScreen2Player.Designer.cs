namespace SpaceRace
{
    partial class GameScreen2Player
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player2Score = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player2Score
            // 
            this.player2Score.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.ForeColor = System.Drawing.Color.White;
            this.player2Score.Location = new System.Drawing.Point(717, 766);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(83, 96);
            this.player2Score.TabIndex = 0;
            this.player2Score.Text = "0";
            // 
            // player1Score
            // 
            this.player1Score.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.ForeColor = System.Drawing.Color.White;
            this.player1Score.Location = new System.Drawing.Point(3, 766);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(83, 96);
            this.player1Score.TabIndex = 1;
            this.player1Score.Text = "0";
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Digital-7 Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(165, 127);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(460, 76);
            this.winnerLabel.TabIndex = 2;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen2Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.player2Score);
            this.DoubleBuffered = true;
            this.Name = "GameScreen2Player";
            this.Size = new System.Drawing.Size(800, 862);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2PictureBox;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label winnerLabel;
    }
}
