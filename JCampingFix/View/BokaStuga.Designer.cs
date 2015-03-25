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
            this.dtpArriving = new System.Windows.Forms.DateTimePicker();
            this.dtpLeaving = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBoka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvwBokaKund
            // 
            this.lvwBokaKund.Location = new System.Drawing.Point(12, 43);
            this.lvwBokaKund.Name = "lvwBokaKund";
            this.lvwBokaKund.Size = new System.Drawing.Size(273, 153);
            this.lvwBokaKund.TabIndex = 0;
            this.lvwBokaKund.UseCompatibleStateImageBehavior = false;
            this.lvwBokaKund.View = System.Windows.Forms.View.Details;
            
            // 
            // lvwBokaStuga
            // 
            this.lvwBokaStuga.Location = new System.Drawing.Point(402, 43);
            this.lvwBokaStuga.Name = "lvwBokaStuga";
            this.lvwBokaStuga.Size = new System.Drawing.Size(306, 153);
            this.lvwBokaStuga.TabIndex = 1;
            this.lvwBokaStuga.UseCompatibleStateImageBehavior = false;
            this.lvwBokaStuga.View = System.Windows.Forms.View.Details;
            // 
            // dtpArriving
            // 
            this.dtpArriving.Location = new System.Drawing.Point(56, 252);
            this.dtpArriving.Name = "dtpArriving";
            this.dtpArriving.Size = new System.Drawing.Size(200, 20);
            this.dtpArriving.TabIndex = 2;
            // 
            // dtpLeaving
            // 
            this.dtpLeaving.Location = new System.Drawing.Point(56, 278);
            this.dtpLeaving.Name = "dtpLeaving";
            this.dtpLeaving.Size = new System.Drawing.Size(200, 20);
            this.dtpLeaving.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Från:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Till:";
            // 
            // btnBoka
            // 
            this.btnBoka.Location = new System.Drawing.Point(302, 242);
            this.btnBoka.Name = "btnBoka";
            this.btnBoka.Size = new System.Drawing.Size(75, 23);
            this.btnBoka.TabIndex = 6;
            this.btnBoka.Text = "Boka";
            this.btnBoka.UseVisualStyleBackColor = true;
            this.btnBoka.Click += new System.EventHandler(this.btnBoka_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "I stuga:";
            // 
            // tbxKund
            // 
            this.tbxKund.Enabled = false;
            this.tbxKund.Location = new System.Drawing.Point(12, 202);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(639, 20);
            this.tbxKund.TabIndex = 8;
            // 
            // BokaStuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 404);
            this.Controls.Add(this.tbxKund);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBoka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLeaving);
            this.Controls.Add(this.dtpArriving);
            this.Controls.Add(this.lvwBokaStuga);
            this.Controls.Add(this.lvwBokaKund);
            this.Name = "BokaStuga";
            this.Text = "BokaStuga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwBokaKund;
        private System.Windows.Forms.ListView lvwBokaStuga;
        private System.Windows.Forms.DateTimePicker dtpArriving;
        private System.Windows.Forms.DateTimePicker dtpLeaving;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBoka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxKund;
    
    }
}