
namespace ProgettoAP.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.pnlTitolo = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbCEO = new System.Windows.Forms.CheckBox();
            this.lbRegistrazione = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPswd = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblTitoloDescrizione = new System.Windows.Forms.Label();
            this.bLogin = new ProgettoAP.Elementi.RJButton();
            this.bClear = new ProgettoAP.Elementi.RJButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTitolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(124, 578);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(80, 20);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.ForeColor = System.Drawing.Color.White;
            this.lblTitolo.Location = new System.Drawing.Point(616, 40);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(255, 47);
            this.lblTitolo.TabIndex = 8;
            this.lblTitolo.Text = "AP TICKET";
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
            this.pnlTitolo.TabIndex = 8;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(1354, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(42, 44);
            this.btnMinimize.TabIndex = 11;
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
            this.btnMaximize.Location = new System.Drawing.Point(1397, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(42, 44);
            this.btnMaximize.TabIndex = 10;
            this.btnMaximize.UseVisualStyleBackColor = true;
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
            this.btnClose.Location = new System.Drawing.Point(1436, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 44);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // cbCEO
            // 
            this.cbCEO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCEO.AutoSize = true;
            this.cbCEO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.cbCEO.Location = new System.Drawing.Point(711, 402);
            this.cbCEO.Name = "cbCEO";
            this.cbCEO.Size = new System.Drawing.Size(106, 24);
            this.cbCEO.TabIndex = 37;
            this.cbCEO.Text = "CEO login";
            this.cbCEO.UseVisualStyleBackColor = true;
            // 
            // lbRegistrazione
            // 
            this.lbRegistrazione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRegistrazione.AutoSize = true;
            this.lbRegistrazione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lbRegistrazione.LinkColor = System.Drawing.Color.Black;
            this.lbRegistrazione.Location = new System.Drawing.Point(712, 511);
            this.lbRegistrazione.Name = "lbRegistrazione";
            this.lbRegistrazione.Size = new System.Drawing.Size(77, 20);
            this.lbRegistrazione.TabIndex = 36;
            this.lbRegistrazione.TabStop = true;
            this.lbRegistrazione.Text = "Registrati";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(527, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 35;
            this.label3.Text = "PASSWORD";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(552, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "EMAIL";
            // 
            // tbPswd
            // 
            this.tbPswd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.tbPswd.Location = new System.Drawing.Point(711, 363);
            this.tbPswd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPswd.Name = "tbPswd";
            this.tbPswd.Size = new System.Drawing.Size(240, 26);
            this.tbPswd.TabIndex = 33;
            this.tbPswd.UseSystemPasswordChar = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(135)))));
            this.tbEmail.Location = new System.Drawing.Point(711, 315);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(240, 26);
            this.tbEmail.TabIndex = 32;
            // 
            // lblTitoloDescrizione
            // 
            this.lblTitoloDescrizione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitoloDescrizione.AutoSize = true;
            this.lblTitoloDescrizione.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloDescrizione.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblTitoloDescrizione.Location = new System.Drawing.Point(699, 213);
            this.lblTitoloDescrizione.Name = "lblTitoloDescrizione";
            this.lblTitoloDescrizione.Size = new System.Drawing.Size(102, 39);
            this.lblTitoloDescrizione.TabIndex = 31;
            this.lblTitoloDescrizione.Text = "LOGIN";
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.White;
            this.bLogin.BackgroundColor = System.Drawing.Color.White;
            this.bLogin.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bLogin.FlatAppearance.BorderSize = 0;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bLogin.Location = new System.Drawing.Point(575, 435);
            this.bLogin.Name = "bLogin";
            this.bLogin.Radius_bordo = 40;
            this.bLogin.Size = new System.Drawing.Size(166, 60);
            this.bLogin.Size_bordo = 2;
            this.bLogin.TabIndex = 38;
            this.bLogin.Text = "LOGIN";
            this.bLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bLogin.UseVisualStyleBackColor = false;
            // 
            // bClear
            // 
            this.bClear.BackColor = System.Drawing.Color.White;
            this.bClear.BackgroundColor = System.Drawing.Color.White;
            this.bClear.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bClear.Location = new System.Drawing.Point(765, 435);
            this.bClear.Name = "bClear";
            this.bClear.Radius_bordo = 40;
            this.bClear.Size = new System.Drawing.Size(166, 60);
            this.bClear.Size_bordo = 2;
            this.bClear.TabIndex = 40;
            this.bClear.Text = "CLEAR";
            this.bClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bClear.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 67);
            this.button1.TabIndex = 41;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.cbCEO);
            this.Controls.Add(this.lbRegistrazione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPswd);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lblTitoloDescrizione);
            this.Controls.Add(this.pnlTitolo);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            this.pnlTitolo.ResumeLayout(false);
            this.pnlTitolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Panel pnlTitolo;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbCEO;
        private System.Windows.Forms.LinkLabel lbRegistrazione;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPswd;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblTitoloDescrizione;
        private Elementi.RJButton bLogin;
        private Elementi.RJButton bClear;
        private System.Windows.Forms.Button button1;
    }
}