
namespace ProgettoAP.Forms
{
    partial class Registrazione
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrazione));
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCognome = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkBoxOrg = new System.Windows.Forms.CheckBox();
            this.lblTitoloDescrizione = new System.Windows.Forms.Label();
            this.pnlTitolo = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.tOrg = new System.Windows.Forms.Label();
            this.cbOrg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bClear = new ProgettoAP.Elementi.RJButton();
            this.btnReg = new ProgettoAP.Elementi.RJButton();
            this.tUser = new System.Windows.Forms.Label();
            this.pnlTitolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(725, 426);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(162, 26);
            this.tbNome.TabIndex = 0;
            // 
            // tbCognome
            // 
            this.tbCognome.Location = new System.Drawing.Point(725, 470);
            this.tbCognome.Name = "tbCognome";
            this.tbCognome.Size = new System.Drawing.Size(162, 26);
            this.tbCognome.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(725, 507);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(162, 26);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(725, 390);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(162, 26);
            this.tbEmail.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(723, 332);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(164, 26);
            this.tbUser.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1434, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 44);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // checkBoxOrg
            // 
            this.checkBoxOrg.AutoSize = true;
            this.checkBoxOrg.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrg.Location = new System.Drawing.Point(986, 341);
            this.checkBoxOrg.Name = "checkBoxOrg";
            this.checkBoxOrg.Size = new System.Drawing.Size(152, 28);
            this.checkBoxOrg.TabIndex = 41;
            this.checkBoxOrg.Text = "Organizzatore";
            this.checkBoxOrg.UseVisualStyleBackColor = true;
            this.checkBoxOrg.CheckedChanged += new System.EventHandler(this.checkBoxOrg_CheckedChanged_1);
            // 
            // lblTitoloDescrizione
            // 
            this.lblTitoloDescrizione.AutoSize = true;
            this.lblTitoloDescrizione.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloDescrizione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitoloDescrizione.Location = new System.Drawing.Point(640, 249);
            this.lblTitoloDescrizione.Name = "lblTitoloDescrizione";
            this.lblTitoloDescrizione.Size = new System.Drawing.Size(231, 39);
            this.lblTitoloDescrizione.TabIndex = 40;
            this.lblTitoloDescrizione.Text = "REGISTRAZIONE";
            // 
            // pnlTitolo
            // 
            this.pnlTitolo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTitolo.Controls.Add(this.btnMinimize);
            this.pnlTitolo.Controls.Add(this.btnMaximize);
            this.pnlTitolo.Controls.Add(this.btnClose);
            this.pnlTitolo.Controls.Add(this.lblTitolo);
            this.pnlTitolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitolo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitolo.Name = "pnlTitolo";
            this.pnlTitolo.Size = new System.Drawing.Size(1478, 125);
            this.pnlTitolo.TabIndex = 39;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1352, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 44);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(1395, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 44);
            this.btnMaximize.TabIndex = 14;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.White;
            this.lblTitolo.Location = new System.Drawing.Point(616, 40);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(234, 46);
            this.lblTitolo.TabIndex = 12;
            this.lblTitolo.Text = "AP TICKET";
            // 
            // tOrg
            // 
            this.tOrg.AutoSize = true;
            this.tOrg.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOrg.Location = new System.Drawing.Point(484, 329);
            this.tOrg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tOrg.Name = "tOrg";
            this.tOrg.Size = new System.Drawing.Size(219, 26);
            this.tOrg.TabIndex = 38;
            this.tOrg.Text = "ORGANIZZAZIONE";
            // 
            // cbOrg
            // 
            this.cbOrg.FormattingEnabled = true;
            this.cbOrg.Location = new System.Drawing.Point(723, 332);
            this.cbOrg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOrg.Name = "cbOrg";
            this.cbOrg.Size = new System.Drawing.Size(180, 28);
            this.cbOrg.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(484, 504);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 32;
            this.label5.Text = "PASSWORD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 465);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "COGNOME";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(484, 423);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "NOME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(484, 378);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 26);
            this.label9.TabIndex = 29;
            this.label9.Text = "EMAIL";
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.White;
            this.bClear.BackgroundColor = System.Drawing.Color.White;
            this.bClear.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bClear.Location = new System.Drawing.Point(772, 568);
            this.bClear.Name = "bClear";
            this.bClear.Radius_bordo = 40;
            this.bClear.Size = new System.Drawing.Size(166, 60);
            this.bClear.Size_bordo = 2;
            this.bClear.TabIndex = 43;
            this.bClear.Text = "CLEAR";
            this.bClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bClear.UseVisualStyleBackColor = false;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.White;
            this.btnReg.BackgroundColor = System.Drawing.Color.White;
            this.btnReg.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReg.Location = new System.Drawing.Point(546, 568);
            this.btnReg.Name = "btnReg";
            this.btnReg.Radius_bordo = 40;
            this.btnReg.Size = new System.Drawing.Size(166, 60);
            this.btnReg.Size_bordo = 2;
            this.btnReg.TabIndex = 42;
            this.btnReg.Text = "REGISTRAZIONE";
            this.btnReg.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click_1);
            // 
            // tUser
            // 
            this.tUser.AutoSize = true;
            this.tUser.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUser.Location = new System.Drawing.Point(484, 329);
            this.tUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tUser.Name = "tUser";
            this.tUser.Size = new System.Drawing.Size(136, 26);
            this.tUser.TabIndex = 45;
            this.tUser.Text = "USERNAME";
            // 
            // Registrazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.tUser);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.checkBoxOrg);
            this.Controls.Add(this.lblTitoloDescrizione);
            this.Controls.Add(this.pnlTitolo);
            this.Controls.Add(this.tOrg);
            this.Controls.Add(this.cbOrg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCognome);
            this.Controls.Add(this.tbNome);
            this.Name = "Registrazione";
            this.Text = "Registrazione";
            this.Load += new System.EventHandler(this.Registrazione_Load);
            this.pnlTitolo.ResumeLayout(false);
            this.pnlTitolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCognome;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBoxOrg;
        private System.Windows.Forms.Label lblTitoloDescrizione;
        private System.Windows.Forms.Panel pnlTitolo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label tOrg;
        private System.Windows.Forms.ComboBox cbOrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Elementi.RJButton btnReg;
        private Elementi.RJButton bClear;
        private System.Windows.Forms.Label tUser;
    }
}