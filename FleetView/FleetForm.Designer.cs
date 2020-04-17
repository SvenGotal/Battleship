namespace FleetView
{
	partial class FleetForm
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
			this.components = new System.ComponentModel.Container();
			this.buttonAgrees = new System.Windows.Forms.Button();
			this.buttonQuit = new System.Windows.Forms.Button();
			this.gridForFleet = new FleetView.GridForFleet(this.components);
			this.SuspendLayout();
			// 
			// buttonAgrees
			// 
			this.buttonAgrees.Location = new System.Drawing.Point(10, 415);
			this.buttonAgrees.Name = "buttonAgrees";
			this.buttonAgrees.Size = new System.Drawing.Size(100, 30);
			this.buttonAgrees.TabIndex = 1;
			this.buttonAgrees.Text = "&Arrange";
			this.buttonAgrees.UseVisualStyleBackColor = true;
			this.buttonAgrees.Click += new System.EventHandler(this.buttonAgreesOnClick);
			// 
			// buttonQuit
			// 
			this.buttonQuit.Location = new System.Drawing.Point(300, 415);
			this.buttonQuit.Name = "buttonQuit";
			this.buttonQuit.Size = new System.Drawing.Size(100, 30);
			this.buttonQuit.TabIndex = 2;
			this.buttonQuit.Text = "Quit";
			this.buttonQuit.UseVisualStyleBackColor = true;
			this.buttonQuit.Click += new System.EventHandler(this.buttonQuitOnClick);
			// 
			// gridForFleet
			// 
			this.gridForFleet.Location = new System.Drawing.Point(10, 10);
			this.gridForFleet.Name = "gridForFleet";
			this.gridForFleet.Size = new System.Drawing.Size(400, 400);
			this.gridForFleet.TabIndex = 0;
			this.gridForFleet.Text = "gridForFleet";
			// 
			// FleetForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 450);
			this.Controls.Add(this.buttonQuit);
			this.Controls.Add(this.buttonAgrees);
			this.Controls.Add(this.gridForFleet);
			this.Name = "FleetForm";
			this.Text = "Fleet";
			this.ResumeLayout(false);

		}

		#endregion

		private GridForFleet gridForFleet;
		private System.Windows.Forms.Button buttonAgrees;
		private System.Windows.Forms.Button buttonQuit;
	}
}