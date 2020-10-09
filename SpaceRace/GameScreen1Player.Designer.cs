namespace SpaceRace
{
    partial class GameScreen1Player
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
            this.playerScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.winnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playerScore
            // 
            this.playerScore.BackColor = System.Drawing.Color.Transparent;
            this.playerScore.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.White;
            this.playerScore.Location = new System.Drawing.Point(3, 766);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(196, 96);
            this.playerScore.TabIndex = 2;
            this.playerScore.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.Font = new System.Drawing.Font("Digital-7 Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.ForeColor = System.Drawing.Color.White;
            this.winnerLabel.Location = new System.Drawing.Point(162, 149);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(460, 119);
            this.winnerLabel.TabIndex = 3;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen1Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.playerScore);
            this.DoubleBuffered = true;
            this.Name = "GameScreen1Player";
            this.Size = new System.Drawing.Size(800, 862);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen1Player_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameScreen1Player_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen1Player_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label winnerLabel;
    }
}
