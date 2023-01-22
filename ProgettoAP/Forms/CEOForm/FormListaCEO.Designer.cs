
namespace ProgettoAP.Forms.CEOForm
{
    partial class FormListaCEO
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
            this.dtRisultati = new System.Windows.Forms.DataGridView();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.bCerca = new ProgettoAP.Elementi.RJButton();
            this.bAggiungi = new ProgettoAP.Elementi.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRisultati
            // 
            this.dtRisultati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRisultati.Location = new System.Drawing.Point(206, 214);
            this.dtRisultati.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtRisultati.Name = "dtRisultati";
            this.dtRisultati.RowHeadersWidth = 62;
            this.dtRisultati.Size = new System.Drawing.Size(998, 300);
            this.dtRisultati.TabIndex = 30;
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.Location = new System.Drawing.Point(244, 141);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(177, 35);
            this.lblNomeEvento.TabIndex = 33;
            this.lblNomeEvento.Text = "Nome Evento:";
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeEvento.Location = new System.Drawing.Point(452, 150);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(404, 26);
            this.txtNomeEvento.TabIndex = 32;
            // 
            // bCerca
            // 
            this.bCerca.BackColor = System.Drawing.Color.White;
            this.bCerca.BackgroundColor = System.Drawing.Color.White;
            this.bCerca.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bCerca.FlatAppearance.BorderSize = 0;
            this.bCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bCerca.Location = new System.Drawing.Point(1002, 132);
            this.bCerca.Name = "bCerca";
            this.bCerca.Radius_bordo = 40;
            this.bCerca.Size = new System.Drawing.Size(166, 60);
            this.bCerca.Size_bordo = 2;
            this.bCerca.TabIndex = 55;
            this.bCerca.Text = "CERCA";
            this.bCerca.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bCerca.UseVisualStyleBackColor = false;
            this.bCerca.Click += new System.EventHandler(this.bCerca_Click);
            // 
            // bAggiungi
            // 
            this.bAggiungi.BackColor = System.Drawing.Color.White;
            this.bAggiungi.BackgroundColor = System.Drawing.Color.White;
            this.bAggiungi.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bAggiungi.FlatAppearance.BorderSize = 0;
            this.bAggiungi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAggiungi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bAggiungi.Location = new System.Drawing.Point(616, 578);
            this.bAggiungi.Name = "bAggiungi";
            this.bAggiungi.Radius_bordo = 40;
            this.bAggiungi.Size = new System.Drawing.Size(166, 60);
            this.bAggiungi.Size_bordo = 2;
            this.bAggiungi.TabIndex = 56;
            this.bAggiungi.Text = "AGGIUNGI EVENTO";
            this.bAggiungi.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bAggiungi.UseVisualStyleBackColor = false;
            this.bAggiungi.Click += new System.EventHandler(this.bAggiungi_Click);
            // 
            // FormListaCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 728);
            this.Controls.Add(this.bAggiungi);
            this.Controls.Add(this.bCerca);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.txtNomeEvento);
            this.Controls.Add(this.dtRisultati);
            this.Name = "FormListaCEO";
            this.Text = "FormLista";
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRisultati;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private Elementi.RJButton bCerca;
        private Elementi.RJButton bAggiungi;
    }
}