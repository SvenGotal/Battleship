namespace Vsite.Oom.Battleship.GUI
{
    partial class BattleshipsGUI
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
            this.DrawPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numberOfLines = new System.Windows.Forms.Label();
            this.numberOfLinesTextBox = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DrawPanel
            // 
            this.DrawPanel.Location = new System.Drawing.Point(12, 12);
            this.DrawPanel.MaximumSize = new System.Drawing.Size(400, 400);
            this.DrawPanel.MinimumSize = new System.Drawing.Size(400, 400);
            this.DrawPanel.Name = "DrawPanel";
            this.DrawPanel.Size = new System.Drawing.Size(400, 400);
            this.DrawPanel.TabIndex = 0;
            // 
            // numberOfLines
            // 
            this.numberOfLines.AutoSize = true;
            this.numberOfLines.Location = new System.Drawing.Point(440, 24);
            this.numberOfLines.Name = "numberOfLines";
            this.numberOfLines.Size = new System.Drawing.Size(130, 13);
            this.numberOfLines.TabIndex = 2;
            this.numberOfLines.Text = "Enter the number of lines: ";
            // 
            // numberOfLinesTextBox
            // 
            this.numberOfLinesTextBox.Location = new System.Drawing.Point(576, 21);
            this.numberOfLinesTextBox.Name = "numberOfLinesTextBox";
            this.numberOfLinesTextBox.Size = new System.Drawing.Size(61, 20);
            this.numberOfLinesTextBox.TabIndex = 3;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(443, 51);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(194, 37);
            this.drawButton.TabIndex = 5;
            this.drawButton.Text = "Draw fleet";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(446, 96);
            this.errorMessage.MaximumSize = new System.Drawing.Size(200, 15);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(189, 13);
            this.errorMessage.TabIndex = 6;
            this.errorMessage.Text = "Enter the number between 10 and 20 !";
            this.errorMessage.Visible = false;
            // 
            // BattleshipsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 431);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.numberOfLinesTextBox);
            this.Controls.Add(this.numberOfLines);
            this.Controls.Add(this.DrawPanel);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(680, 470);
            this.MinimumSize = new System.Drawing.Size(680, 470);
            this.Name = "BattleshipsGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battleships";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel DrawPanel;
        private System.Windows.Forms.Label numberOfLines;
        private System.Windows.Forms.TextBox numberOfLinesTextBox;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label errorMessage;
    }
}

