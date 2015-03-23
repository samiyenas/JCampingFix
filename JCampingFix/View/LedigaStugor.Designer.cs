namespace JCampingFix.View
{
    partial class LedigaStugor
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
            this.lvwCabin = new System.Windows.Forms.ListView();
            this.btnLedigaStugor = new System.Windows.Forms.Button();
            this.tbxStugNamn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwCabin
            // 
            this.lvwCabin.Location = new System.Drawing.Point(12, 12);
            this.lvwCabin.Name = "lvwCabin";
            this.lvwCabin.Size = new System.Drawing.Size(201, 178);
            this.lvwCabin.TabIndex = 0;
            this.lvwCabin.UseCompatibleStateImageBehavior = false;
            this.lvwCabin.View = System.Windows.Forms.View.Details;
            // 
            // btnLedigaStugor
            // 
            this.btnLedigaStugor.Location = new System.Drawing.Point(260, 167);
            this.btnLedigaStugor.Name = "btnLedigaStugor";
            this.btnLedigaStugor.Size = new System.Drawing.Size(100, 23);
            this.btnLedigaStugor.TabIndex = 1;
            this.btnLedigaStugor.Text = "Lägg till stuga";
            this.btnLedigaStugor.UseVisualStyleBackColor = true;
            this.btnLedigaStugor.Click += new System.EventHandler(this.btnLedigaStugor_Click);
            // 
            // tbxStugNamn
            // 
            this.tbxStugNamn.Location = new System.Drawing.Point(260, 120);
            this.tbxStugNamn.Name = "tbxStugNamn";
            this.tbxStugNamn.Size = new System.Drawing.Size(100, 20);
            this.tbxStugNamn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ny stuga";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Namn:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(233, 84);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID:";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(260, 81);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(100, 20);
            this.tbxID.TabIndex = 5;
            // 
            // LedigaStugor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxStugNamn);
            this.Controls.Add(this.btnLedigaStugor);
            this.Controls.Add(this.lvwCabin);
            this.Name = "LedigaStugor";
            this.Text = "LedigaStugor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ListView lvwCabin;
        private System.Windows.Forms.Button btnLedigaStugor;
        private System.Windows.Forms.TextBox tbxStugNamn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tbxID;

    }
    
}