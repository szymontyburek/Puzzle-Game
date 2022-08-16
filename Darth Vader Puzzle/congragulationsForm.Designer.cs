namespace Darth_Vader_Puzzle
{
    partial class congragulationsForm
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
            this.dvGifPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.exitProgramButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvGifPB)).BeginInit();
            this.SuspendLayout();
            // 
            // dvGifPB
            // 
            this.dvGifPB.Location = new System.Drawing.Point(12, 124);
            this.dvGifPB.Name = "dvGifPB";
            this.dvGifPB.Size = new System.Drawing.Size(931, 568);
            this.dvGifPB.TabIndex = 0;
            this.dvGifPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(139, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Congragulations!!!";
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.Black;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.ForeColor = System.Drawing.SystemColors.Control;
            this.playAgainButton.Location = new System.Drawing.Point(12, 703);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(309, 152);
            this.playAgainButton.TabIndex = 2;
            this.playAgainButton.Text = "Play Again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.BackColor = System.Drawing.Color.Black;
            this.exitProgramButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitProgramButton.ForeColor = System.Drawing.SystemColors.Control;
            this.exitProgramButton.Location = new System.Drawing.Point(634, 703);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(309, 152);
            this.exitProgramButton.TabIndex = 3;
            this.exitProgramButton.Text = "Exit Program";
            this.exitProgramButton.UseVisualStyleBackColor = false;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // congragulationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(955, 867);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.playAgainButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvGifPB);
            this.Name = "congragulationsForm";
            this.Text = "congragulationsForm";
            this.Load += new System.EventHandler(this.congragulationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvGifPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox dvGifPB;
        private Label label1;
        private Button playAgainButton;
        private Button exitProgramButton;
    }
}