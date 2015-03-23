namespace JCampingFix.View
{
    partial class BokaStuga
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
            this.lvwBokaKund = new System.Windows.Forms.ListView();
            this.lvwBokaStuga = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwBokaKund
            // 
            this.lvwBokaKund.Location = new System.Drawing.Point(12, 43);
            this.lvwBokaKund.Name = "lvwBokaKund";
            this.lvwBokaKund.Size = new System.Drawing.Size(172, 153);
            this.lvwBokaKund.TabIndex = 0;
            this.lvwBokaKund.UseCompatibleStateImageBehavior = false;
            // 
            // lvwBokaStuga
            // 
            this.lvwBokaStuga.Location = new System.Drawing.Point(274, 43);
            this.lvwBokaStuga.Name = "lvwBokaStuga";
            this.lvwBokaStuga.Size = new System.Drawing.Size(180, 153);
            this.lvwBokaStuga.TabIndex = 1;
            this.lvwBokaStuga.UseCompatibleStateImageBehavior = false;
            // 
            // BokaStuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 404);
            this.Controls.Add(this.lvwBokaStuga);
            this.Controls.Add(this.lvwBokaKund);
            this.Name = "BokaStuga";
            this.Text = "BokaStuga";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBokaKund;
        private System.Windows.Forms.ListView lvwBokaStuga;
    
    }
}