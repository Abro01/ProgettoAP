﻿namespace ProgettoAP.Forms.CEOForm
{
    partial class FormImpostazioniCEO
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
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(406, 267);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 49;
            // 
            // txtCognome
            // 
            this.txtCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCognome.Location = new System.Drawing.Point(406, 227);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(156, 20);
            this.txtCognome.TabIndex = 48;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(406, 190);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(156, 20);
            this.txtNome.TabIndex = 47;
            // 
            // lblCognome
            // 
            this.lblCognome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCognome.AutoSize = true;
            this.lblCognome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCognome.Location = new System.Drawing.Point(264, 222);
            this.lblCognome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(89, 23);
            this.lblCognome.TabIndex = 46;
            this.lblCognome.Text = "Cognome:";
            this.lblCognome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(264, 262);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(58, 23);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(264, 185);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 23);
            this.lblNome.TabIndex = 44;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitoloImpo
            // 
            this.lblTitoloImpo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitoloImpo.AutoSize = true;
            this.lblTitoloImpo.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitoloImpo.Location = new System.Drawing.Point(292, 110);
            this.lblTitoloImpo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitoloImpo.Name = "lblTitoloImpo";
            this.lblTitoloImpo.Size = new System.Drawing.Size(227, 33);
            this.lblTitoloImpo.TabIndex = 43;
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
            this.bModifica.Location = new System.Drawing.Point(356, 313);
            this.bModifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bModifica.Name = "bModifica";
            this.bModifica.Radius_bordo = 40;
            this.bModifica.Size = new System.Drawing.Size(111, 39);
            this.bModifica.Size_bordo = 2;
            this.bModifica.TabIndex = 75;
            this.bModifica.Text = "MODIFICA";
            this.bModifica.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bModifica.UseVisualStyleBackColor = false;
            this.bModifica.Click += new System.EventHandler(this.bModifica_Click);
            // 
            // FormImpostazioniCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 395);
            this.Controls.Add(this.bModifica);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitoloImpo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormImpostazioniCEO";
            this.Text = "FormImpostazioniCEO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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