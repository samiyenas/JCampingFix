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
            this.tbxPrisLista = new System.Windows.Forms.TextBox();
            this.btnBetala = new System.Windows.Forms.Button();
            this.lblHusvagn = new System.Windows.Forms.Label();
            this.lblKWH = new System.Windows.Forms.Label();
            this.btnPris = new System.Windows.Forms.Button();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxStugpris = new System.Windows.Forms.TextBox();
            this.tbxHusvagnPris = new System.Windows.Forms.TextBox();
            this.tbxKWHpris = new System.Windows.Forms.TextBox();
            this.lblStuga = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.brnaddPrices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwBokningar
            // 
            this.lvwBokningar.Location = new System.Drawing.Point(12, 27);
            this.lvwBokningar.Name = "lvwBokningar";
            this.lvwBokningar.Size = new System.Drawing.Size(492, 241);
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
            // tbxPrisLista
            // 
            this.tbxPrisLista.Enabled = false;
            this.tbxPrisLista.Location = new System.Drawing.Point(580, 158);
            this.tbxPrisLista.Multiline = true;
            this.tbxPrisLista.Name = "tbxPrisLista";
            this.tbxPrisLista.Size = new System.Drawing.Size(177, 85);
            this.tbxPrisLista.TabIndex = 3;
            this.tbxPrisLista.Text = "1 natt i stuga: 10 kr\r\n\r\n1 natt i husvagn: 4 kr\r\n\r\n1kwh : 5 kr\r\n";
            // 
            // btnBetala
            // 
            this.btnBetala.Location = new System.Drawing.Point(12, 314);
            this.btnBetala.Name = "btnBetala";
            this.btnBetala.Size = new System.Drawing.Size(116, 23);
            this.btnBetala.TabIndex = 4;
            this.btnBetala.Text = "Betala vald bokning";
            this.btnBetala.UseVisualStyleBackColor = true;
            this.btnBetala.Click += new System.EventHandler(this.btnBetala_Click);
            // 
            // lblHusvagn
            // 
            this.lblHusvagn.AutoSize = true;
            this.lblHusvagn.Location = new System.Drawing.Point(595, 53);
            this.lblHusvagn.Name = "lblHusvagn";
            this.lblHusvagn.Size = new System.Drawing.Size(90, 13);
            this.lblHusvagn.TabIndex = 5;
            this.lblHusvagn.Text = "1 Natt i Husvagn:";
            // 
            // lblKWH
            // 
            this.lblKWH.AutoSize = true;
            this.lblKWH.Location = new System.Drawing.Point(642, 82);
            this.lblKWH.Name = "lblKWH";
            this.lblKWH.Size = new System.Drawing.Size(40, 13);
            this.lblKWH.TabIndex = 6;
            this.lblKWH.Text = "1 Kwh:";
            // 
            // btnPris
            // 
            this.btnPris.Location = new System.Drawing.Point(13, 285);
            this.btnPris.Name = "btnPris";
            this.btnPris.Size = new System.Drawing.Size(115, 23);
            this.btnPris.TabIndex = 7;
            this.btnPris.Text = "Pris för bokning";
            this.btnPris.UseVisualStyleBackColor = true;
            this.btnPris.Click += new System.EventHandler(this.btnPris_Click);
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(135, 287);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 8;
            // 
            // tbxStugpris
            // 
            this.tbxStugpris.Location = new System.Drawing.Point(688, 27);
            this.tbxStugpris.Name = "tbxStugpris";
            this.tbxStugpris.Size = new System.Drawing.Size(100, 20);
            this.tbxStugpris.TabIndex = 9;
            // 
            // tbxHusvagnPris
            // 
            this.tbxHusvagnPris.Location = new System.Drawing.Point(688, 53);
            this.tbxHusvagnPris.Name = "tbxHusvagnPris";
            this.tbxHusvagnPris.Size = new System.Drawing.Size(100, 20);
            this.tbxHusvagnPris.TabIndex = 10;
            // 
            // tbxKWHpris
            // 
            this.tbxKWHpris.Location = new System.Drawing.Point(688, 79);
            this.tbxKWHpris.Name = "tbxKWHpris";
            this.tbxKWHpris.Size = new System.Drawing.Size(100, 20);
            this.tbxKWHpris.TabIndex = 11;
            // 
            // lblStuga
            // 
            this.lblStuga.AutoSize = true;
            this.lblStuga.Location = new System.Drawing.Point(609, 30);
            this.lblStuga.Name = "lblStuga";
            this.lblStuga.Size = new System.Drawing.Size(73, 13);
            this.lblStuga.TabIndex = 12;
            this.lblStuga.Text = "1 Natt i stuga:";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(688, 114);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 23);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Apply Changes";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // brnaddPrices
            // 
            this.brnaddPrices.Location = new System.Drawing.Point(812, 114);
            this.brnaddPrices.Name = "brnaddPrices";
            this.brnaddPrices.Size = new System.Drawing.Size(75, 23);
            this.brnaddPrices.TabIndex = 14;
            this.brnaddPrices.Text = "button1";
            this.brnaddPrices.UseVisualStyleBackColor = true;
            this.brnaddPrices.Click += new System.EventHandler(this.brnaddPrices_Click);
            // 
            // Ekonomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 409);
            this.Controls.Add(this.brnaddPrices);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblStuga);
            this.Controls.Add(this.tbxKWHpris);
            this.Controls.Add(this.tbxHusvagnPris);
            this.Controls.Add(this.tbxStugpris);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.btnPris);
            this.Controls.Add(this.lblKWH);
            this.Controls.Add(this.lblHusvagn);
            this.Controls.Add(this.btnBetala);
            this.Controls.Add(this.tbxPrisLista);
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
        private System.Windows.Forms.TextBox tbxPrisLista;
        private System.Windows.Forms.Button btnBetala;
        private System.Windows.Forms.Label lblHusvagn;
        private System.Windows.Forms.Label lblKWH;
        private System.Windows.Forms.Button btnPris;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxStugpris;
        private System.Windows.Forms.TextBox tbxHusvagnPris;
        private System.Windows.Forms.TextBox tbxKWHpris;
        private System.Windows.Forms.Label lblStuga;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button brnaddPrices;
    }
}