namespace Darth_Vader_Puzzle
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlsButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.gifPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifPB)).BeginInit();
            this.SuspendLayout();
            // 
            // controlsButton
            // 
            this.controlsButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.controlsButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.controlsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.controlsButton.Location = new System.Drawing.Point(257, 12);
            this.controlsButton.Name = "controlsButton";
            this.controlsButton.Size = new System.Drawing.Size(455, 112);
            this.controlsButton.TabIndex = 0;
            this.controlsButton.Text = "Controls";
            this.controlsButton.UseVisualStyleBackColor = false;
            this.controlsButton.Click += new System.EventHandler(this.controlsButton_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.newGameButton.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newGameButton.ForeColor = System.Drawing.SystemColors.Control;
            this.newGameButton.Location = new System.Drawing.Point(257, 479);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(455, 118);
            this.newGameButton.TabIndex = 1;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gifPB
            // 
            this.gifPB.Location = new System.Drawing.Point(12, 136);
            this.gifPB.Name = "gifPB";
            this.gifPB.Size = new System.Drawing.Size(953, 323);
            this.gifPB.TabIndex = 2;
            this.gifPB.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(977, 609);
            this.Controls.Add(this.gifPB);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.controlsButton);
            this.Name = "HomePage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button controlsButton;
        private Button newGameButton;
        private PictureBox gifPB;
    }
}