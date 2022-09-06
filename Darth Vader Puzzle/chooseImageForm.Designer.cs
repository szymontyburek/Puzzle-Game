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
            this.browseButton = new System.Windows.Forms.Button();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(335, 391);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(221, 69);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse Computer";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // explanationLabel
            // 
            this.explanationLabel.Location = new System.Drawing.Point(241, 73);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(453, 178);
            this.explanationLabel.TabIndex = 1;
            this.explanationLabel.Text = "You use any picture to work on as a puzzle. There also are preset options availab" +
    "le in the folder you have downloaded this program to.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chooseImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 620);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.browseButton);
            this.Name = "chooseImageForm";
            this.Text = "chooseImageForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button browseButton;
        private Label explanationLabel;
        private OpenFileDialog openFileDialog1;
    }
}