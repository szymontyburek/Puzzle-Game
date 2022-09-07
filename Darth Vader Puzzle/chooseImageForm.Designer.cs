﻿namespace Darth_Vader_Puzzle
{
    partial class chooseImageForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.choosePuzzleImageLabel = new System.Windows.Forms.Label();
            this.darthVaderPB = new System.Windows.Forms.PictureBox();
            this.spidermanPB = new System.Windows.Forms.PictureBox();
            this.batmanPB = new System.Windows.Forms.PictureBox();
            this.flashPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.darthVaderPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spidermanPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmanPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashPB)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // choosePuzzleImageLabel
            // 
            this.choosePuzzleImageLabel.AutoSize = true;
            this.choosePuzzleImageLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choosePuzzleImageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choosePuzzleImageLabel.Location = new System.Drawing.Point(336, 21);
            this.choosePuzzleImageLabel.Name = "choosePuzzleImageLabel";
            this.choosePuzzleImageLabel.Size = new System.Drawing.Size(508, 60);
            this.choosePuzzleImageLabel.TabIndex = 4;
            this.choosePuzzleImageLabel.Text = "Choose a puzzle image:";
            // 
            // darthVaderPB
            // 
            this.darthVaderPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.darthVader;
            this.darthVaderPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.darthVaderPB.Location = new System.Drawing.Point(63, 115);
            this.darthVaderPB.Name = "darthVaderPB";
            this.darthVaderPB.Size = new System.Drawing.Size(440, 382);
            this.darthVaderPB.TabIndex = 13;
            this.darthVaderPB.TabStop = false;
            this.darthVaderPB.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // spidermanPB
            // 
            this.spidermanPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.spiderman4;
            this.spidermanPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spidermanPB.Location = new System.Drawing.Point(632, 115);
            this.spidermanPB.Name = "spidermanPB";
            this.spidermanPB.Size = new System.Drawing.Size(440, 382);
            this.spidermanPB.TabIndex = 14;
            this.spidermanPB.TabStop = false;
            this.spidermanPB.Click += new System.EventHandler(this.spidermanPB_Click);
            // 
            // batmanPB
            // 
            this.batmanPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.batman;
            this.batmanPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batmanPB.Location = new System.Drawing.Point(63, 597);
            this.batmanPB.Name = "batmanPB";
            this.batmanPB.Size = new System.Drawing.Size(440, 382);
            this.batmanPB.TabIndex = 15;
            this.batmanPB.TabStop = false;
            this.batmanPB.Click += new System.EventHandler(this.batmanPB_Click);
            // 
            // flashPB
            // 
            this.flashPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.flash;
            this.flashPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashPB.Location = new System.Drawing.Point(632, 597);
            this.flashPB.Name = "flashPB";
            this.flashPB.Size = new System.Drawing.Size(440, 382);
            this.flashPB.TabIndex = 16;
            this.flashPB.TabStop = false;
            this.flashPB.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // chooseImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1130, 1032);
            this.Controls.Add(this.flashPB);
            this.Controls.Add(this.batmanPB);
            this.Controls.Add(this.spidermanPB);
            this.Controls.Add(this.darthVaderPB);
            this.Controls.Add(this.choosePuzzleImageLabel);
            this.Name = "chooseImageForm";
            this.Text = "chooseImageForm";
            this.Load += new System.EventHandler(this.chooseImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darthVaderPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spidermanPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batmanPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flashPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label choosePuzzleImageLabel;
        private PictureBox darthVaderPB;
        private PictureBox spidermanPB;
        private PictureBox batmanPB;
        private PictureBox flashPB;
    }
}