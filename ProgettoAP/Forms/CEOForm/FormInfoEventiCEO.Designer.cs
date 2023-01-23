namespace ProgettoAP.Forms.CEOForm
{
    partial class FormInfoEventiCEO
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
            this.lblTitolo = new System.Windows.Forms.Label();
            this.dtUtenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(353, 91);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(209, 23);
            this.lblTitolo.TabIndex = 3;
            this.lblTitolo.Text = "BIGLIETTI ACQUISTATI DA\r\n";
            // 
            // dtUtenti
            // 
            this.dtUtenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUtenti.Location = new System.Drawing.Point(174, 160);
            this.dtUtenti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtUtenti.Name = "dtUtenti";
            this.dtUtenti.RowHeadersWidth = 62;
            this.dtUtenti.RowTemplate.Height = 28;
            this.dtUtenti.Size = new System.Drawing.Size(579, 213);
            this.dtUtenti.TabIndex = 2;
            // 
            // FormInfoEventiCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 463);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.dtUtenti);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormInfoEventiCEO";
            this.Text = "FormInfoEventiCEO";
            this.Load += new System.EventHandler(this.FormInfoEventiCEO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUtenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.DataGridView dtUtenti;
    }
}