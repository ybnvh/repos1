namespace WinFormsApp1
{
    partial class fAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.revenueStatisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilmToolStripMenuItem,
            this.deleteFilmToolStripMenuItem,
            this.editToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // addFilmToolStripMenuItem
            // 
            this.addFilmToolStripMenuItem.Name = "addFilmToolStripMenuItem";
            this.addFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addFilmToolStripMenuItem.Text = "Add film";
            // 
            // deleteFilmToolStripMenuItem
            // 
            this.deleteFilmToolStripMenuItem.Name = "deleteFilmToolStripMenuItem";
            this.deleteFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteFilmToolStripMenuItem.Text = "Delete film";
            // 
            // revenueStatisticsToolStripMenuItem
            // 
            this.revenueStatisticsToolStripMenuItem.Name = "revenueStatisticsToolStripMenuItem";
            this.revenueStatisticsToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.revenueStatisticsToolStripMenuItem.Text = "Revenue statistics";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAdmin";
            this.Text = "fAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem addFilmToolStripMenuItem;
        private ToolStripMenuItem deleteFilmToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem revenueStatisticsToolStripMenuItem;
    }
}