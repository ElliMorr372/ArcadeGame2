namespace ArcadeGame2
{
    partial class background1
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
            this.playGameButton = new System.Windows.Forms.Button();
            this.gameStartLabel = new System.Windows.Forms.Label();
            this.countdownLabel3 = new System.Windows.Forms.Label();
            this.countdownLabel2 = new System.Windows.Forms.Label();
            this.countdownLabel1 = new System.Windows.Forms.Label();
            this.countdownLabel0 = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGameButton
            // 
            this.playGameButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playGameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.playGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGameButton.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playGameButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playGameButton.Location = new System.Drawing.Point(256, 175);
            this.playGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.playGameButton.Name = "playGameButton";
            this.playGameButton.Size = new System.Drawing.Size(182, 49);
            this.playGameButton.TabIndex = 0;
            this.playGameButton.Text = "Play Game";
            this.playGameButton.UseVisualStyleBackColor = false;
            this.playGameButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameStartLabel
            // 
            this.gameStartLabel.AutoSize = true;
            this.gameStartLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStartLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameStartLabel.Location = new System.Drawing.Point(203, 270);
            this.gameStartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameStartLabel.Name = "gameStartLabel";
            this.gameStartLabel.Size = new System.Drawing.Size(269, 32);
            this.gameStartLabel.TabIndex = 1;
            this.gameStartLabel.Text = "Game Will Start In:";
            // 
            // countdownLabel3
            // 
            this.countdownLabel3.AutoSize = true;
            this.countdownLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countdownLabel3.Location = new System.Drawing.Point(406, 270);
            this.countdownLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdownLabel3.Name = "countdownLabel3";
            this.countdownLabel3.Size = new System.Drawing.Size(31, 32);
            this.countdownLabel3.TabIndex = 2;
            this.countdownLabel3.Text = "3";
            // 
            // countdownLabel2
            // 
            this.countdownLabel2.AutoSize = true;
            this.countdownLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countdownLabel2.Location = new System.Drawing.Point(406, 270);
            this.countdownLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdownLabel2.Name = "countdownLabel2";
            this.countdownLabel2.Size = new System.Drawing.Size(31, 32);
            this.countdownLabel2.TabIndex = 3;
            this.countdownLabel2.Text = "2";
            // 
            // countdownLabel1
            // 
            this.countdownLabel1.AutoSize = true;
            this.countdownLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countdownLabel1.Location = new System.Drawing.Point(406, 270);
            this.countdownLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdownLabel1.Name = "countdownLabel1";
            this.countdownLabel1.Size = new System.Drawing.Size(31, 32);
            this.countdownLabel1.TabIndex = 4;
            this.countdownLabel1.Text = "1";
            // 
            // countdownLabel0
            // 
            this.countdownLabel0.AutoSize = true;
            this.countdownLabel0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countdownLabel0.Location = new System.Drawing.Point(406, 270);
            this.countdownLabel0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdownLabel0.Name = "countdownLabel0";
            this.countdownLabel0.Size = new System.Drawing.Size(31, 32);
            this.countdownLabel0.TabIndex = 5;
            this.countdownLabel0.Text = "0";
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.BackColor = System.Drawing.Color.Green;
            this.goLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goLabel.Location = new System.Drawing.Point(307, 183);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(70, 33);
            this.goLabel.TabIndex = 6;
            this.goLabel.Text = "Go!!";
            // 
            // background1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(712, 401);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdownLabel0);
            this.Controls.Add(this.countdownLabel1);
            this.Controls.Add(this.countdownLabel2);
            this.Controls.Add(this.countdownLabel3);
            this.Controls.Add(this.gameStartLabel);
            this.Controls.Add(this.playGameButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "background1";
            this.Text = "Arcade Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playGameButton;
        private System.Windows.Forms.Label gameStartLabel;
        private System.Windows.Forms.Label countdownLabel3;
        private System.Windows.Forms.Label countdownLabel2;
        private System.Windows.Forms.Label countdownLabel1;
        private System.Windows.Forms.Label countdownLabel0;
        private System.Windows.Forms.Label goLabel;
    }
}

