namespace JCampingFix.View
{
    partial class Ekonomi
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
            this.lvwBokningar = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBetala = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPengar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwBokningar
            // 
            this.lvwBokningar.Location = new System.Drawing.Point(12, 27);
            this.lvwBokningar.Name = "lvwBokningar";
            this.lvwBokningar.Size = new System.Drawing.Size(456, 241);
            this.lvwBokningar.TabIndex = 0;
            this.lvwBokningar.UseCompatibleStateImageBehavior = false;
            this.lvwBokningar.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alla Bokningar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(685, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prislista";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(675, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 85);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "1 natt i stuga: 10 kr\r\n\r\n1 natt i husvagn: 4 kr\r\n\r\n1kwh : 5 kr\r\n";
            // 
            // btnBetala
            // 
            this.btnBetala.Location = new System.Drawing.Point(12, 274);
            this.btnBetala.Name = "btnBetala";
            this.btnBetala.Size = new System.Drawing.Size(116, 23);
            this.btnBetala.TabIndex = 4;
            this.btnBetala.Text = "Betala vald bokning";
            this.btnBetala.UseVisualStyleBackColor = true;
            this.btnBetala.Click += new System.EventHandler(this.btnBetala_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(510, 135);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label3";
            // 
            // lblPengar
            // 
            this.lblPengar.AutoSize = true;
            this.lblPengar.Location = new System.Drawing.Point(510, 161);
            this.lblPengar.Name = "lblPengar";
            this.lblPengar.Size = new System.Drawing.Size(35, 13);
            this.lblPengar.TabIndex = 6;
            this.lblPengar.Text = "label4";
            // 
            // Ekonomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 409);
            this.Controls.Add(this.lblPengar);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnBetala);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwBokningar);
            this.Name = "Ekonomi";
            this.Text = "Ekonomi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwBokningar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBetala;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPengar;
    }
}