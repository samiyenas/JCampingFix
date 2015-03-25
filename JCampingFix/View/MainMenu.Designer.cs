namespace JCampingFix.View
{
    partial class MainMenu
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
            this.kundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillKundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stugorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledigaStugorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bokaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokaEnStugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kundToolStripMenuItem,
            this.stugorToolStripMenuItem,
            this.bokaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kundToolStripMenuItem
            // 
            this.kundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.läggTillKundToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.kundToolStripMenuItem.Name = "kundToolStripMenuItem";
            this.kundToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.kundToolStripMenuItem.Text = "Kund";
            // 
            // läggTillKundToolStripMenuItem
            // 
            this.läggTillKundToolStripMenuItem.Name = "läggTillKundToolStripMenuItem";
            this.läggTillKundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.läggTillKundToolStripMenuItem.Text = "Lägg till Kund";
            this.läggTillKundToolStripMenuItem.Click += new System.EventHandler(this.läggTillKundToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // stugorToolStripMenuItem
            // 
            this.stugorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ledigaStugorToolStripMenuItem,
            this.saveToolStripMenuItem1});
            this.stugorToolStripMenuItem.Name = "stugorToolStripMenuItem";
            this.stugorToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.stugorToolStripMenuItem.Text = "Stugor";
            // 
            // ledigaStugorToolStripMenuItem
            // 
            this.ledigaStugorToolStripMenuItem.Name = "ledigaStugorToolStripMenuItem";
            this.ledigaStugorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ledigaStugorToolStripMenuItem.Text = "Lediga Stugor";
            this.ledigaStugorToolStripMenuItem.Click += new System.EventHandler(this.ledigaStugorToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // bokaToolStripMenuItem
            // 
            this.bokaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bokaEnStugaToolStripMenuItem});
            this.bokaToolStripMenuItem.Name = "bokaToolStripMenuItem";
            this.bokaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.bokaToolStripMenuItem.Text = "Boka";
            // 
            // bokaEnStugaToolStripMenuItem
            // 
            this.bokaEnStugaToolStripMenuItem.Name = "bokaEnStugaToolStripMenuItem";
            this.bokaEnStugaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bokaEnStugaToolStripMenuItem.Text = "Boka en stuga";
            this.bokaEnStugaToolStripMenuItem.Click += new System.EventHandler(this.bokaEnStugaToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem läggTillKundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stugorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ledigaStugorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bokaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bokaEnStugaToolStripMenuItem;
    }
}