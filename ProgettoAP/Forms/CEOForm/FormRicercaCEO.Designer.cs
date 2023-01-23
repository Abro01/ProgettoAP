namespace ProgettoAP.Forms.CEOForm
{
    partial class FormRicercaCEO
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
            this.bCerca = new ProgettoAP.Elementi.RJButton();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.dtRisultati = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).BeginInit();
            this.SuspendLayout();
            // 
            // bCerca
            // 
            this.bCerca.BackColor = System.Drawing.Color.White;
            this.bCerca.BackgroundColor = System.Drawing.Color.White;
            this.bCerca.Colore_bordo = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bCerca.FlatAppearance.BorderSize = 0;
            this.bCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bCerca.Location = new System.Drawing.Point(609, 50);
            this.bCerca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bCerca.Name = "bCerca";
            this.bCerca.Radius_bordo = 40;
            this.bCerca.Size = new System.Drawing.Size(111, 39);
            this.bCerca.Size_bordo = 2;
            this.bCerca.TabIndex = 47;
            this.bCerca.Text = "CERCA";
            this.bCerca.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bCerca.UseVisualStyleBackColor = false;
            this.bCerca.Click += new System.EventHandler(this.bCerca_Click);
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.Location = new System.Drawing.Point(159, 55);
            this.lblNomeEvento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(118, 23);
            this.lblNomeEvento.TabIndex = 46;
            this.lblNomeEvento.Text = "Nome Evento:";
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeEvento.Location = new System.Drawing.Point(297, 61);
            this.txtNomeEvento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(271, 20);
            this.txtNomeEvento.TabIndex = 45;
            // 
            // dtRisultati
            // 
            this.dtRisultati.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtRisultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRisultati.Location = new System.Drawing.Point(79, 120);
            this.dtRisultati.Name = "dtRisultati";
            this.dtRisultati.RowHeadersWidth = 62;
            this.dtRisultati.Size = new System.Drawing.Size(667, 226);
            this.dtRisultati.TabIndex = 44;
            this.dtRisultati.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRisultati_CellContentClick);
            // 
            // FormRicercaCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 395);
            this.Controls.Add(this.bCerca);
            this.Controls.Add(this.lblNomeEvento);
            this.Controls.Add(this.txtNomeEvento);
            this.Controls.Add(this.dtRisultati);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRicercaCEO";
            this.Text = "FormRicercaCEO";
            this.Load += new System.EventHandler(this.FormRicercaCEO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRisultati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elementi.RJButton bCerca;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.DataGridView dtRisultati;
    }
}