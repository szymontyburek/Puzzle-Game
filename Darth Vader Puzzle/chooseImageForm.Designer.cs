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
            this.flashRB = new System.Windows.Forms.RadioButton();
            this.choosePuzzleImageLabel = new System.Windows.Forms.Label();
            this.batmanRB = new System.Windows.Forms.RadioButton();
            this.darthVaderRB = new System.Windows.Forms.RadioButton();
            this.spidermanRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flashRB
            // 
            this.flashRB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.flash;
            this.flashRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flashRB.Location = new System.Drawing.Point(529, 537);
            this.flashRB.Name = "flashRB";
            this.flashRB.Size = new System.Drawing.Size(440, 382);
            this.flashRB.TabIndex = 3;
            this.flashRB.TabStop = true;
            this.flashRB.UseVisualStyleBackColor = true;
            // 
            // choosePuzzleImageLabel
            // 
            this.choosePuzzleImageLabel.AutoSize = true;
            this.choosePuzzleImageLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.choosePuzzleImageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choosePuzzleImageLabel.Location = new System.Drawing.Point(276, 21);
            this.choosePuzzleImageLabel.Name = "choosePuzzleImageLabel";
            this.choosePuzzleImageLabel.Size = new System.Drawing.Size(508, 60);
            this.choosePuzzleImageLabel.TabIndex = 4;
            this.choosePuzzleImageLabel.Text = "Choose a puzzle image:";
            // 
            // batmanRB
            // 
            this.batmanRB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.batman;
            this.batmanRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.batmanRB.Location = new System.Drawing.Point(27, 537);
            this.batmanRB.Name = "batmanRB";
            this.batmanRB.Size = new System.Drawing.Size(440, 382);
            this.batmanRB.TabIndex = 5;
            this.batmanRB.TabStop = true;
            this.batmanRB.UseVisualStyleBackColor = true;
            // 
            // darthVaderRB
            // 
            this.darthVaderRB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.darthVader;
            this.darthVaderRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.darthVaderRB.Location = new System.Drawing.Point(27, 115);
            this.darthVaderRB.Name = "darthVaderRB";
            this.darthVaderRB.Size = new System.Drawing.Size(440, 382);
            this.darthVaderRB.TabIndex = 6;
            this.darthVaderRB.TabStop = true;
            this.darthVaderRB.UseVisualStyleBackColor = true;
            this.darthVaderRB.CheckedChanged += new System.EventHandler(this.darthVaderRB_CheckedChanged);
            // 
            // spidermanRB
            // 
            this.spidermanRB.BackgroundImage = global::Darth_Vader_Puzzle.Properties.Resources.spiderman4;
            this.spidermanRB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spidermanRB.Location = new System.Drawing.Point(529, 115);
            this.spidermanRB.Name = "spidermanRB";
            this.spidermanRB.Size = new System.Drawing.Size(440, 382);
            this.spidermanRB.TabIndex = 7;
            this.spidermanRB.TabStop = true;
            this.spidermanRB.UseVisualStyleBackColor = true;
            // 
            // chooseImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1012, 957);
            this.Controls.Add(this.spidermanRB);
            this.Controls.Add(this.darthVaderRB);
            this.Controls.Add(this.batmanRB);
            this.Controls.Add(this.choosePuzzleImageLabel);
            this.Controls.Add(this.flashRB);
            this.Name = "chooseImageForm";
            this.Text = "chooseImageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label choosePuzzleImageLabel;
        public RadioButton darthVaderRB;
        public RadioButton flashRB;
        public RadioButton batmanRB;
        public RadioButton spidermanRB;
    }
}