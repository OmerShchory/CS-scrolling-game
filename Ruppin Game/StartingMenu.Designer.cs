namespace Ruppin_Game
{
    partial class StartingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingMenu));
            this.lblinstructions = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl10points = new System.Windows.Forms.Label();
            this.lbl100Points = new System.Windows.Forms.Label();
            this.picExam = new System.Windows.Forms.PictureBox();
            this.picGold = new System.Windows.Forms.PictureBox();
            this.lblScoring = new System.Windows.Forms.Label();
            this.lblNames = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGold)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinstructions
            // 
            this.lblinstructions.AutoSize = true;
            this.lblinstructions.Font = new System.Drawing.Font("Narkisim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblinstructions.ForeColor = System.Drawing.Color.DarkRed;
            this.lblinstructions.Location = new System.Drawing.Point(7, 69);
            this.lblinstructions.Name = "lblinstructions";
            this.lblinstructions.Size = new System.Drawing.Size(887, 120);
            this.lblinstructions.TabIndex = 0;
            this.lblinstructions.Text = resources.GetString("lblinstructions.Text");
            this.lblinstructions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnstart.Font = new System.Drawing.Font("Narkisim", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnstart.Location = new System.Drawing.Point(221, 514);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(160, 62);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            this.btnstart.MouseHover += new System.EventHandler(this.btnstart_MouseHover);
            // 
            // picArrow
            // 
            this.picArrow.Image = global::Ruppin_Game.Properties.Resources.arrow_keys;
            this.picArrow.Location = new System.Drawing.Point(375, 187);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(140, 112);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrow.TabIndex = 6;
            this.picArrow.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.Image = global::Ruppin_Game.Properties.Resources.sutdent;
            this.picPlayer1.Location = new System.Drawing.Point(96, 401);
            this.picPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(85, 88);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 4;
            this.picPlayer1.TabStop = false;
            this.picPlayer1.Click += new System.EventHandler(this.picPlayer1_Click);
            this.picPlayer1.MouseHover += new System.EventHandler(this.picPlayer1_MouseHover);
            // 
            // picPlayer3
            // 
            this.picPlayer3.Image = global::Ruppin_Game.Properties.Resources.spiderMan;
            this.picPlayer3.Location = new System.Drawing.Point(464, 401);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(85, 88);
            this.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer3.TabIndex = 3;
            this.picPlayer3.TabStop = false;
            this.picPlayer3.Click += new System.EventHandler(this.picPlayer3_Click);
            this.picPlayer3.MouseHover += new System.EventHandler(this.picPlayer3_MouseHover);
            // 
            // picPlayer2
            // 
            this.picPlayer2.Image = global::Ruppin_Game.Properties.Resources.hulk;
            this.picPlayer2.Location = new System.Drawing.Point(279, 401);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(85, 88);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer2.TabIndex = 2;
            this.picPlayer2.TabStop = false;
            this.picPlayer2.Click += new System.EventHandler(this.picPlayer2_Click);
            this.picPlayer2.MouseHover += new System.EventHandler(this.picPlayer2_MouseHover);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Narkisim", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblChoose.Location = new System.Drawing.Point(216, 362);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(264, 26);
            this.lblChoose.TabIndex = 7;
            this.lblChoose.Text = "Please choose a player:";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Narkisim", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWelcome.Location = new System.Drawing.Point(155, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(408, 35);
            this.lblWelcome.TabIndex = 8;
            this.lblWelcome.Text = "Welcome to Ruppin Game! ";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Narkisim", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 60);
            this.label1.TabIndex = 9;
            this.label1.Text = "To win the game, you need to collect 500 scores and reach the Finish line. \r\nGood" +
    " Luck!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl10points
            // 
            this.lbl10points.AutoSize = true;
            this.lbl10points.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl10points.Location = new System.Drawing.Point(150, 203);
            this.lbl10points.Name = "lbl10points";
            this.lbl10points.Size = new System.Drawing.Size(93, 24);
            this.lbl10points.TabIndex = 10;
            this.lbl10points.Text = "10 points";
            // 
            // lbl100Points
            // 
            this.lbl100Points.AutoSize = true;
            this.lbl100Points.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl100Points.Location = new System.Drawing.Point(48, 203);
            this.lbl100Points.Name = "lbl100Points";
            this.lbl100Points.Size = new System.Drawing.Size(103, 24);
            this.lbl100Points.TabIndex = 11;
            this.lbl100Points.Text = "100 points";
            // 
            // picExam
            // 
            this.picExam.Image = global::Ruppin_Game.Properties.Resources.exam;
            this.picExam.Location = new System.Drawing.Point(131, 230);
            this.picExam.Name = "picExam";
            this.picExam.Size = new System.Drawing.Size(100, 50);
            this.picExam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExam.TabIndex = 12;
            this.picExam.TabStop = false;
            // 
            // picGold
            // 
            this.picGold.Image = global::Ruppin_Game.Properties.Resources.Gold_test;
            this.picGold.Location = new System.Drawing.Point(37, 230);
            this.picGold.Name = "picGold";
            this.picGold.Size = new System.Drawing.Size(100, 50);
            this.picGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGold.TabIndex = 13;
            this.picGold.TabStop = false;
            // 
            // lblScoring
            // 
            this.lblScoring.AutoSize = true;
            this.lblScoring.Font = new System.Drawing.Font("Narkisim", 13F);
            this.lblScoring.ForeColor = System.Drawing.Color.DarkRed;
            this.lblScoring.Location = new System.Drawing.Point(106, 177);
            this.lblScoring.Name = "lblScoring";
            this.lblScoring.Size = new System.Drawing.Size(75, 26);
            this.lblScoring.TabIndex = 10;
            this.lblScoring.Text = "Score:";
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(9, 579);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(279, 16);
            this.lblNames.TabIndex = 14;
            this.lblNames.Text = "copyright ©2021 David Pesso & Omer Shchory";
            // 
            // StartingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(628, 603);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.picGold);
            this.Controls.Add(this.picExam);
            this.Controls.Add(this.lbl100Points);
            this.Controls.Add(this.lblScoring);
            this.Controls.Add(this.lbl10points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.picPlayer3);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.lblinstructions);
            this.Font = new System.Drawing.Font("Narkisim", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartingMenu";
            this.Text = "Starting Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinstructions;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.PictureBox picPlayer3;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl10points;
        private System.Windows.Forms.Label lbl100Points;
        private System.Windows.Forms.PictureBox picExam;
        private System.Windows.Forms.PictureBox picGold;
        private System.Windows.Forms.Label lblScoring;
        private System.Windows.Forms.Label lblNames;
    }
}