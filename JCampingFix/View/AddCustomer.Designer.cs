namespace JCampingFix.View
{
    partial class AddCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblFörnamn = new System.Windows.Forms.Label();
            this.lblEfternamn = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTelefonNummer = new System.Windows.Forms.Label();
            this.tbxFörnamn = new System.Windows.Forms.TextBox();
            this.tbxEfternamn = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxTelefonnummer = new System.Windows.Forms.TextBox();
            this.lvwCustomer = new System.Windows.Forms.ListView();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(15, 146);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(114, 23);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Lägg till kund";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblFörnamn
            // 
            this.lblFörnamn.AutoSize = true;
            this.lblFörnamn.Location = new System.Drawing.Point(4, 25);
            this.lblFörnamn.Name = "lblFörnamn";
            this.lblFörnamn.Size = new System.Drawing.Size(48, 13);
            this.lblFörnamn.TabIndex = 1;
            this.lblFörnamn.Text = "Förnamn";
            // 
            // lblEfternamn
            // 
            this.lblEfternamn.AutoSize = true;
            this.lblEfternamn.Location = new System.Drawing.Point(4, 51);
            this.lblEfternamn.Name = "lblEfternamn";
            this.lblEfternamn.Size = new System.Drawing.Size(55, 13);
            this.lblEfternamn.TabIndex = 2;
            this.lblEfternamn.Text = "Efternamn";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(4, 77);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(39, 13);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adress";
            // 
            // lblTelefonNummer
            // 
            this.lblTelefonNummer.AutoSize = true;
            this.lblTelefonNummer.Location = new System.Drawing.Point(4, 103);
            this.lblTelefonNummer.Name = "lblTelefonNummer";
            this.lblTelefonNummer.Size = new System.Drawing.Size(80, 13);
            this.lblTelefonNummer.TabIndex = 4;
            this.lblTelefonNummer.Text = "Telefonnummer";
            // 
            // tbxFörnamn
            // 
            this.tbxFörnamn.Location = new System.Drawing.Point(90, 25);
            this.tbxFörnamn.Name = "tbxFörnamn";
            this.tbxFörnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxFörnamn.TabIndex = 5;
            // 
            // tbxEfternamn
            // 
            this.tbxEfternamn.Location = new System.Drawing.Point(90, 51);
            this.tbxEfternamn.Name = "tbxEfternamn";
            this.tbxEfternamn.Size = new System.Drawing.Size(100, 20);
            this.tbxEfternamn.TabIndex = 6;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(90, 77);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.Size = new System.Drawing.Size(100, 20);
            this.tbxAdress.TabIndex = 7;
            // 
            // tbxTelefonnummer
            // 
            this.tbxTelefonnummer.Location = new System.Drawing.Point(90, 103);
            this.tbxTelefonnummer.Name = "tbxTelefonnummer";
            this.tbxTelefonnummer.Size = new System.Drawing.Size(100, 20);
            this.tbxTelefonnummer.TabIndex = 8;
            // 
            // lvwCustomer
            // 
            this.lvwCustomer.Location = new System.Drawing.Point(227, 25);
            this.lvwCustomer.Name = "lvwCustomer";
            this.lvwCustomer.Size = new System.Drawing.Size(325, 151);
            this.lvwCustomer.TabIndex = 10;
            this.lvwCustomer.UseCompatibleStateImageBehavior = false;
            this.lvwCustomer.View = System.Windows.Forms.View.Details;
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Location = new System.Drawing.Point(15, 175);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(114, 23);
            this.btnDeleteCustomers.TabIndex = 11;
            this.btnDeleteCustomers.Text = "Ta bort kund";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 262);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.lvwCustomer);
            this.Controls.Add(this.tbxTelefonnummer);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.tbxEfternamn);
            this.Controls.Add(this.tbxFörnamn);
            this.Controls.Add(this.lblTelefonNummer);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblEfternamn);
            this.Controls.Add(this.lblFörnamn);
            this.Controls.Add(this.btnAddCustomer);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnDeleteCustomers_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnAddCustomer_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblFörnamn;
        private System.Windows.Forms.Label lblEfternamn;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTelefonNummer;
        private System.Windows.Forms.TextBox tbxFörnamn;
        private System.Windows.Forms.TextBox tbxEfternamn;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.TextBox tbxTelefonnummer;
        private System.Windows.Forms.ListView lvwCustomer;
        private System.Windows.Forms.Button btnDeleteCustomers;
    }
    
}