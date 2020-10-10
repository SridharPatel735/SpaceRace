namespace SpaceRace
{
    partial class MainScreen
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.play2PlayerButton = new System.Windows.Forms.Button();
            this.play1PlayerButton = new System.Windows.Forms.Button();
            this.highScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Digital-7 Mono", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(176, 61);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(494, 107);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Space Race";
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Black;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(175, 334);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(179, 75);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.Enter += new System.EventHandler(this.quitButton_Enter);
            // 
            // play2PlayerButton
            // 
            this.play2PlayerButton.BackColor = System.Drawing.Color.Black;
            this.play2PlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.play2PlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.play2PlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play2PlayerButton.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play2PlayerButton.ForeColor = System.Drawing.Color.White;
            this.play2PlayerButton.Location = new System.Drawing.Point(175, 234);
            this.play2PlayerButton.Name = "play2PlayerButton";
            this.play2PlayerButton.Size = new System.Drawing.Size(179, 75);
            this.play2PlayerButton.TabIndex = 3;
            this.play2PlayerButton.Text = "Play 2 Player";
            this.play2PlayerButton.UseVisualStyleBackColor = false;
            this.play2PlayerButton.Click += new System.EventHandler(this.play2PlayerButton_Click);
            this.play2PlayerButton.Enter += new System.EventHandler(this.play2PlayerButton_Enter);
            // 
            // play1PlayerButton
            // 
            this.play1PlayerButton.BackColor = System.Drawing.Color.Black;
            this.play1PlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.play1PlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.play1PlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play1PlayerButton.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play1PlayerButton.ForeColor = System.Drawing.Color.White;
            this.play1PlayerButton.Location = new System.Drawing.Point(491, 234);
            this.play1PlayerButton.Name = "play1PlayerButton";
            this.play1PlayerButton.Size = new System.Drawing.Size(179, 75);
            this.play1PlayerButton.TabIndex = 4;
            this.play1PlayerButton.Text = "Play 1 Player";
            this.play1PlayerButton.UseVisualStyleBackColor = false;
            this.play1PlayerButton.Click += new System.EventHandler(this.play1PlayerButton_Click);
            this.play1PlayerButton.Enter += new System.EventHandler(this.play1PlayerButton_Enter);
            // 
            // highScoreButton
            // 
            this.highScoreButton.BackColor = System.Drawing.Color.Black;
            this.highScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.highScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.highScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoreButton.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreButton.ForeColor = System.Drawing.Color.White;
            this.highScoreButton.Location = new System.Drawing.Point(491, 334);
            this.highScoreButton.Name = "highScoreButton";
            this.highScoreButton.Size = new System.Drawing.Size(179, 75);
            this.highScoreButton.TabIndex = 5;
            this.highScoreButton.Text = "HighScore      1 player";
            this.highScoreButton.UseVisualStyleBackColor = false;
            this.highScoreButton.Enter += new System.EventHandler(this.highScoreButton_Enter);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.highScoreButton);
            this.Controls.Add(this.play1PlayerButton);
            this.Controls.Add(this.play2PlayerButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainScreen";
            this.Size = new System.Drawing.Size(800, 862);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button play2PlayerButton;
        private System.Windows.Forms.Button play1PlayerButton;
        private System.Windows.Forms.Button highScoreButton;
    }
}
