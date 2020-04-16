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

		#region Windows Form Designer generated code#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAgrees = new System.Windows.Forms.Button();
			this.gridForFleet = new FleetView.GridForFleet();
			this.SuspendLayout();
			//grid for fleet
			this.gridForFleet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.gridForFleet.Name = "gridForFleet";
			this.gridForFleet.Text = "gridForFleet";
			this.gridForFleet.Location = new System.Drawing.Point(10, 10);
			this.gridForFleet.Size = new System.Drawing.Size(400, 400);
			this.gridForFleet.TabIndex = 0;
			//button
			this.buttonAgrees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAgrees.Name = "buttonAgrees";
			this.buttonAgrees.Text = "&Arrange";
			this.buttonAgrees.Location = new System.Drawing.Point(318, 415);
			this.buttonAgrees.Size = new System.Drawing.Size(80, 25);
			this.buttonAgrees.TabIndex = 1;
			this.buttonAgrees.UseVisualStyleBackColor = true;
			this.buttonAgrees.Click += new System.EventHandler(this.buttonAgreesOnClick);
			
		}

		#endregion

		private GridForFleet gridForFleet;
		private System.Windows.Forms.Button buttonAgrees;
	}
}