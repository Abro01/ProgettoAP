namespace ProgettoAP.Forms.UserForm
{
    partial class FormImpostazioniUtente
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTitoloImpo = new System.Windows.Forms.Label();
            this.bModifica = new ProgettoAP.Elementi.RJButton();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Location = new System.Drawing.Point(609, 334);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 26);
            this.txtUsername.TabIndex = 52;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(398, 326);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(142, 35);
            this.lblUsername.TabIndex = 51;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(609, 385);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 26);
            this.txtEmail.TabIndex = 50;
            // 
            // txtCognome
            // 
            this.txtCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCognome.Location = new System.Drawing.Point(609, 276);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(232, 26);
            this.txtCognome.TabIndex = 49;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(609, 219);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(232, 26);
            this.txtNome.TabIndex = 48;
            // 
            // lblCognome
            // 
            this.lblCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(398, 268);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(133, 35);
            this.lblCognome.TabIndex = 47;
            this.lblCognome.Text = "Cognome:";
            this.lblCognome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(398, 377);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 35);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(398, 211);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 35);
            this.lblNome.TabIndex = 45;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitoloImpo
            // 
            this.lblTitoloImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitoloImpo.AutoSize = true;
            this.lblTitoloImpo.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloImpo.Location = new System.Drawing.Point(455, 92);
            this.lblTitoloImpo.Name = "lblTitoloImpo";
            this.lblTitoloImpo.Size = new System.Drawing.Size(337, 49);
            this.lblTitoloImpo.TabIndex = 44;
            this.lblTitoloImpo.Text = "Modifica i tuoi dati";
            // 
            // bModifica
            // 
            this.bModifica.BackColor = System.Drawing.Color.White;
            this.bModifica.BackgroundColor = System.Drawing.Color.White;
            this.bModifica.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bModifica.FlatAppearance.BorderSize = 0;
            this.bModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bModifica.Location = new System.Drawing.Point(539, 447);
            this.bModifica.Name = "bModifica";
            this.bModifica.Radius_bordo = 40;
            this.bModifica.Size = new System.Drawing.Size(166, 60);
            this.bModifica.Size_bordo = 2;
            this.bModifica.TabIndex = 53;
            this.bModifica.Text = "MODIFICA";
            this.bModifica.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bModifica.UseVisualStyleBackColor = false;
            // 
            // FormImpostazioniUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 608);
            this.Controls.Add(this.bModifica);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitoloImpo);
            this.Name = "FormImpostazioniUtente";
            this.Text = "FormImpostazioniUtente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTitoloImpo;
        private Elementi.RJButton bModifica;
    }
}