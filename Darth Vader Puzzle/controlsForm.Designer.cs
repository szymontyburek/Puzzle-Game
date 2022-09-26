namespace Darth_Vader_Puzzle
{
    partial class controlsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newGameLL = new System.Windows.Forms.LinkLabel();
            this.buttonsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(762, 48);
            this.label3.TabIndex = 130;
            this.label3.Text = "Double click on any puzzle piece, box or board";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(714, 96);
            this.label6.TabIndex = 133;
            this.label6.Text = "Ready to play? Click";
            // 
            // newGameLL
            // 
            this.newGameLL.AutoSize = true;
            this.newGameLL.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newGameLL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.newGameLL.Location = new System.Drawing.Point(699, 514);
            this.newGameLL.Name = "newGameLL";
            this.newGameLL.Size = new System.Drawing.Size(190, 96);
            this.newGameLL.TabIndex = 135;
            this.newGameLL.TabStop = true;
            this.newGameLL.Text = "here";
            this.newGameLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newGameLL_LinkClicked);
            // 
            // buttonsLabel
            // 
            this.buttonsLabel.AutoSize = true;
            this.buttonsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonsLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonsLabel.Location = new System.Drawing.Point(12, 273);
            this.buttonsLabel.Name = "buttonsLabel";
            this.buttonsLabel.Size = new System.Drawing.Size(661, 96);
            this.buttonsLabel.TabIndex = 117;
            this.buttonsLabel.Text = "To Rotate Pieces - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 96);
            this.label1.TabIndex = 136;
            this.label1.Text = "To Move Puzzle Pieces - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1401, 48);
            this.label2.TabIndex = 137;
            this.label2.Text = "Drag and drop with the mouse. You CAN move pieces around in the box and board too" +
    "";
            // 
            // controlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1426, 713);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newGameLL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonsLabel);
            this.Name = "controlsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "controlsForm";
            this.Load += new System.EventHandler(this.controlsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label6;
        private LinkLabel newGameLL;
        private Label buttonsLabel;
        private Label label1;
        private Label label2;
    }
}