namespace Darth_Vader_Puzzle
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
            this.confirmButton = new System.Windows.Forms.Button();
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
            this.choosePuzzleImageLabel.Location = new System.Drawing.Point(277, 19);
            this.choosePuzzleImageLabel.Name = "choosePuzzleImageLabel";
            this.choosePuzzleImageLabel.Size = new System.Drawing.Size(508, 60);
            this.choosePuzzleImageLabel.TabIndex = 4;
            this.choosePuzzleImageLabel.Text = "Choose a puzzle image:";
            // 
            // darthVaderPB
            // 
            this.darthVaderPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.darthVader;
            this.darthVaderPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.darthVaderPB.Location = new System.Drawing.Point(48, 104);
            this.darthVaderPB.Name = "darthVaderPB";
            this.darthVaderPB.Size = new System.Drawing.Size(440, 382);
            this.darthVaderPB.TabIndex = 13;
            this.darthVaderPB.TabStop = false;
            this.darthVaderPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.darthVaderPB_MouseClick);
            // 
            // spidermanPB
            // 
            this.spidermanPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.spiderman5;
            this.spidermanPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spidermanPB.Location = new System.Drawing.Point(556, 104);
            this.spidermanPB.Name = "spidermanPB";
            this.spidermanPB.Size = new System.Drawing.Size(440, 382);
            this.spidermanPB.TabIndex = 14;
            this.spidermanPB.TabStop = false;
            this.spidermanPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spidermanPB_MouseClick);
            // 
            // batmanPB
            // 
            this.batmanPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.batman;
            this.batmanPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batmanPB.Location = new System.Drawing.Point(48, 556);
            this.batmanPB.Name = "batmanPB";
            this.batmanPB.Size = new System.Drawing.Size(440, 382);
            this.batmanPB.TabIndex = 15;
            this.batmanPB.TabStop = false;
            this.batmanPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.batmanPB_MouseClick);
            // 
            // flashPB
            // 
            this.flashPB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.flash1;
            this.flashPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashPB.Location = new System.Drawing.Point(556, 556);
            this.flashPB.Name = "flashPB";
            this.flashPB.Size = new System.Drawing.Size(440, 382);
            this.flashPB.TabIndex = 16;
            this.flashPB.TabStop = false;
            this.flashPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flashPB_MouseClick);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmButton.Location = new System.Drawing.Point(48, 972);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(948, 134);
            this.confirmButton.TabIndex = 17;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // chooseImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1050, 1129);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.flashPB);
            this.Controls.Add(this.batmanPB);
            this.Controls.Add(this.spidermanPB);
            this.Controls.Add(this.darthVaderPB);
            this.Controls.Add(this.choosePuzzleImageLabel);
            this.Name = "chooseImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button confirmButton;
    }
}