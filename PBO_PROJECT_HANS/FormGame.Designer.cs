namespace PBO_PROJECT_HANS
{
    partial class FormGame
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
            this.components = new System.ComponentModel.Container();
            this.panelGame = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelHPEnemy = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelEnemy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHPCharacter = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStage = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerShoot = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.tit = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.label5);
            this.panelGame.Location = new System.Drawing.Point(16, 324);
            this.panelGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1116, 622);
            this.panelGame.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(37, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.tit);
            this.panelInfo.Controls.Add(this.labelHPEnemy);
            this.panelInfo.Controls.Add(this.labelScore);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.labelEnemy);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.labelHPCharacter);
            this.panelInfo.Controls.Add(this.labelName);
            this.panelInfo.Controls.Add(this.labelStage);
            this.panelInfo.Location = new System.Drawing.Point(16, 144);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(1116, 172);
            this.panelInfo.TabIndex = 0;
            // 
            // labelHPEnemy
            // 
            this.labelHPEnemy.AutoSize = true;
            this.labelHPEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelHPEnemy.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPEnemy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelHPEnemy.Location = new System.Drawing.Point(912, 79);
            this.labelHPEnemy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHPEnemy.Name = "labelHPEnemy";
            this.labelHPEnemy.Size = new System.Drawing.Size(173, 35);
            this.labelHPEnemy.TabIndex = 14;
            this.labelHPEnemy.Text = "labelHPEnemy";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelScore.Location = new System.Drawing.Point(115, 108);
            this.labelScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(136, 35);
            this.labelScore.TabIndex = 18;
            this.labelScore.Text = "labelScore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Score :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(852, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 35);
            this.label3.TabIndex = 16;
            this.label3.Text = "HP :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEnemy
            // 
            this.labelEnemy.BackColor = System.Drawing.Color.Transparent;
            this.labelEnemy.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelEnemy.Location = new System.Drawing.Point(775, 42);
            this.labelEnemy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnemy.Name = "labelEnemy";
            this.labelEnemy.Size = new System.Drawing.Size(320, 33);
            this.labelEnemy.TabIndex = 13;
            this.labelEnemy.Text = "labelEnemy";
            this.labelEnemy.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(47, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "HP :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHPCharacter
            // 
            this.labelHPCharacter.AutoSize = true;
            this.labelHPCharacter.BackColor = System.Drawing.Color.Transparent;
            this.labelHPCharacter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPCharacter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelHPCharacter.Location = new System.Drawing.Point(115, 79);
            this.labelHPCharacter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHPCharacter.Name = "labelHPCharacter";
            this.labelHPCharacter.Size = new System.Drawing.Size(215, 35);
            this.labelHPCharacter.TabIndex = 11;
            this.labelHPCharacter.Text = "labelHPCharacter";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelName.Location = new System.Drawing.Point(11, 42);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(134, 35);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "labelName";
            // 
            // labelStage
            // 
            this.labelStage.BackColor = System.Drawing.Color.Transparent;
            this.labelStage.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelStage.Location = new System.Drawing.Point(428, 43);
            this.labelStage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStage.Name = "labelStage";
            this.labelStage.Size = new System.Drawing.Size(299, 75);
            this.labelStage.TabIndex = 9;
            this.labelStage.Text = "STAGE";
            this.labelStage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.Transparent;
            this.panelButton.Controls.Add(this.buttonPlay);
            this.panelButton.Controls.Add(this.buttonQuit);
            this.panelButton.Controls.Add(this.buttonNewGame);
            this.panelButton.Location = new System.Drawing.Point(16, 15);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1116, 122);
            this.panelButton.TabIndex = 0;
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlay.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPlay.Image = global::PBO_PROJECT_HANS.Properties.Resources.PLAYY;
            this.buttonPlay.Location = new System.Drawing.Point(401, 10);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(339, 98);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackColor = System.Drawing.Color.Transparent;
            this.buttonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuit.Image = global::PBO_PROJECT_HANS.Properties.Resources.Quit;
            this.buttonQuit.Location = new System.Drawing.Point(792, 32);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(305, 55);
            this.buttonQuit.TabIndex = 0;
            this.buttonQuit.UseVisualStyleBackColor = false;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Image = global::PBO_PROJECT_HANS.Properties.Resources.Play;
            this.buttonNewGame.Location = new System.Drawing.Point(41, 32);
            this.buttonNewGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(304, 55);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerShoot
            // 
            this.timerShoot.Tick += new System.EventHandler(this.timerShoot_Tick);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // tit
            // 
            this.tit.AutoSize = true;
            this.tit.Location = new System.Drawing.Point(567, 127);
            this.tit.Name = "tit";
            this.tit.Size = new System.Drawing.Size(46, 17);
            this.tit.TabIndex = 19;
            this.tit.Text = "label1";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PBO_PROJECT_HANS.Properties.Resources.BackgrounGame;
            this.ClientSize = new System.Drawing.Size(1159, 923);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelGame);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGame_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelButton;
        public System.Windows.Forms.Label labelHPEnemy;
        public System.Windows.Forms.Label labelScore;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelEnemy;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelHPCharacter;
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStage;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonPlay;
        public System.Windows.Forms.Panel panelGame;
        public System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Timer timerShoot;
        private System.Windows.Forms.Timer timerEnemy;
        private System.Windows.Forms.Label tit;
    }
}