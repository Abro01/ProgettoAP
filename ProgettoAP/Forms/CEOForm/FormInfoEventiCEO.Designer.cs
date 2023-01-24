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
            this.label1 = new System.Windows.Forms.Label();
            this.dtCeo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtUtenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCeo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(357, 9);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(209, 23);
            this.lblTitolo.TabIndex = 3;
            this.lblTitolo.Text = "BIGLIETTI ACQUISTATI DA\r\n";
            this.lblTitolo.Click += new System.EventHandler(this.lblTitolo_Click);
            // 
            // dtUtenti
            // 
            this.dtUtenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUtenti.Location = new System.Drawing.Point(181, 82);
            this.dtUtenti.Margin = new System.Windows.Forms.Padding(2);
            this.dtUtenti.Name = "dtUtenti";
            this.dtUtenti.RowHeadersWidth = 62;
            this.dtUtenti.RowTemplate.Height = 28;
            this.dtUtenti.Size = new System.Drawing.Size(579, 213);
            this.dtUtenti.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Utenti che hanno acquistato il biglietto per l\'evento di cui hai richesto le info" +
    "rmazioni:";
            // 
            // dtCeo
            // 
            this.dtCeo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtCeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCeo.Location = new System.Drawing.Point(181, 333);
            this.dtCeo.Margin = new System.Windows.Forms.Padding(2);
            this.dtCeo.Name = "dtCeo";
            this.dtCeo.RowHeadersWidth = 62;
            this.dtCeo.RowTemplate.Height = 28;
            this.dtCeo.Size = new System.Drawing.Size(579, 213);
            this.dtCeo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ceo che hanno acquistato il biglietto per l\'evento di cui hai richesto le informa" +
    "zioni:";
            // 
            // FormInfoEventiCEO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCeo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.dtUtenti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInfoEventiCEO";
            this.Text = "FormInfoEventiCEO";
            this.Load += new System.EventHandler(this.FormInfoEventiCEO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUtenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.DataGridView dtUtenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtCeo;
        private System.Windows.Forms.Label label2;
    }
}