namespace Vsite.Oom.Battleship.Gui
{
    partial class GuiForm
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
            this.guiPanel1 = new Vsite.Oom.Battleship.Gui.GuiPanel();
            this.SuspendLayout();
            // 
            // guiPanel1
            // 
            this.guiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guiPanel1.Location = new System.Drawing.Point(383, 12);
            this.guiPanel1.Name = "guiPanel1";
            this.guiPanel1.Size = new System.Drawing.Size(405, 426);
            this.guiPanel1.TabIndex = 0;
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guiPanel1);
            this.Name = "GuiForm";
            this.Text = "Battleship";
            this.ResumeLayout(false);

        }

        #endregion

        private GuiPanel guiPanel1;
    }
}

