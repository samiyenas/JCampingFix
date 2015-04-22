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
            this.lvwBokningar = new System.Windows.Forms.ListView();
            this.btnLedig = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.cbxHusvagn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lvwBokaKund
            // 
            this.lvwBokaKund.Location = new System.Drawing.Point(12, 43);
            this.lvwBokaKund.Name = "lvwBokaKund";
            this.lvwBokaKund.Size = new System.Drawing.Size(298, 153);
            this.lvwBokaKund.TabIndex = 0;
            this.lvwBokaKund.UseCompatibleStateImageBehavior = false;
            this.lvwBokaKund.View = System.Windows.Forms.View.Details;
            // 
            // lvwBokaStuga
            // 
            this.lvwBokaStuga.Location = new System.Drawing.Point(496, 43);
            this.lvwBokaStuga.Name = "lvwBokaStuga";
            this.lvwBokaStuga.Size = new System.Drawing.Size(306, 153);
            this.lvwBokaStuga.TabIndex = 1;
            this.lvwBokaStuga.UseCompatibleStateImageBehavior = false;
            this.lvwBokaStuga.View = System.Windows.Forms.View.Details;
            // 
            // dtpArriving
            // 
            this.dtpArriving.Location = new System.Drawing.Point(58, 293);
            this.dtpArriving.Name = "dtpArriving";
            this.dtpArriving.Size = new System.Drawing.Size(200, 20);
            this.dtpArriving.TabIndex = 2;
            // 
            // dtpLeaving
            // 
            this.dtpLeaving.Location = new System.Drawing.Point(58, 319);
            this.dtpLeaving.Name = "dtpLeaving";
            this.dtpLeaving.Size = new System.Drawing.Size(200, 20);
            this.dtpLeaving.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Från:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 319);
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
            this.label3.Location = new System.Drawing.Point(335, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "I stuga:";
            // 
            // lvwBokningar
            // 
            this.lvwBokningar.Location = new System.Drawing.Point(432, 290);
            this.lvwBokningar.Name = "lvwBokningar";
            this.lvwBokningar.Size = new System.Drawing.Size(564, 234);
            this.lvwBokningar.TabIndex = 9;
            this.lvwBokningar.UseCompatibleStateImageBehavior = false;
            this.lvwBokningar.View = System.Windows.Forms.View.Details;
            // 
            // btnLedig
            // 
            this.btnLedig.Location = new System.Drawing.Point(908, 55);
            this.btnLedig.Name = "btnLedig";
            this.btnLedig.Size = new System.Drawing.Size(75, 23);
            this.btnLedig.TabIndex = 10;
            this.btnLedig.Text = "Ledig";
            this.btnLedig.UseVisualStyleBackColor = true;
            this.btnLedig.Click += new System.EventHandler(this.btnLedig_Click);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Location = new System.Drawing.Point(273, 489);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(119, 23);
            this.btnDeleteBooking.TabIndex = 11;
            this.btnDeleteBooking.Text = "Ta bort bokning";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            // 
            // cbxHusvagn
            // 
            this.cbxHusvagn.AutoSize = true;
            this.cbxHusvagn.Location = new System.Drawing.Point(496, 214);
            this.cbxHusvagn.Name = "cbxHusvagn";
            this.cbxHusvagn.Size = new System.Drawing.Size(114, 17);
            this.cbxHusvagn.TabIndex = 13;
            this.cbxHusvagn.Text = "Husvagn Används";
            this.cbxHusvagn.UseVisualStyleBackColor = true;
            // 
            // BokaStuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 554);
            this.Controls.Add(this.cbxHusvagn);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnLedig);
            this.Controls.Add(this.lvwBokningar);
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
        private System.Windows.Forms.ListView lvwBokningar;
        private System.Windows.Forms.Button btnLedig;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.CheckBox cbxHusvagn;
    
    }
}