namespace GUI
{
	partial class Form1
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
			this.CreateFleetButton = new System.Windows.Forms.Button();
			this.GameBoard = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// CreateFleetButton
			// 
			this.CreateFleetButton.Location = new System.Drawing.Point(337, 426);
			this.CreateFleetButton.Name = "CreateFleetButton";
			this.CreateFleetButton.Size = new System.Drawing.Size(75, 23);
			this.CreateFleetButton.TabIndex = 0;
			this.CreateFleetButton.Text = "Slozi";
			this.CreateFleetButton.UseVisualStyleBackColor = true;
			this.CreateFleetButton.Click += new System.EventHandler(this.CreateFleetButton_Click);
			// 
			// GameBoard
			// 
			this.GameBoard.Location = new System.Drawing.Point(0, 10);
			this.GameBoard.Margin = new System.Windows.Forms.Padding(0);
			this.GameBoard.Name = "GameBoard";
			this.GameBoard.Size = new System.Drawing.Size(424, 413);
			this.GameBoard.TabIndex = 1;
			this.GameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSquares);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 461);
			this.Controls.Add(this.GameBoard);
			this.Controls.Add(this.CreateFleetButton);
			this.MaximumSize = new System.Drawing.Size(440, 500);
			this.MinimumSize = new System.Drawing.Size(440, 500);
			this.Name = "Form1";
			this.Text = "Flota";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button CreateFleetButton;
		private System.Windows.Forms.Panel GameBoard;
	}
}

