using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.Models;

namespace ProgettoAP.Forms.CEOForm
{
    public partial class FormAggiuntaEventoCEO : Form
    {
        public FormAggiuntaEventoCEO()
        {
            InitializeComponent();
        }

        private void bAggiungi_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(txtCosto.Text)) || (String.IsNullOrEmpty(txtDescrizione.Text)) || (String.IsNullOrEmpty(txtGenere.Text)) || (String.IsNullOrEmpty(txtPosti.Text) || String.IsNullOrEmpty(txtLuogo.Text) || String.IsNullOrEmpty(txtNome.Text)))
            {
                MessageBox.Show("E' necessario compilare tutti i campi");
            }
            else
            {
                try
                {

                    if(Controller.AggiungiEvento(txtNome.Text, txtGenere.Text, txtLuogo.Text, txtDescrizione.Text, Convert.ToInt32(txtPosti.Text), Sessione.Ceo.CodOrganizzazione, Convert.ToInt32(txtCosto.Text)))
                    {
                        txtNome.Clear();
                        txtGenere.Clear();
                        txtLuogo.Clear();
                        txtDescrizione.Clear();
                        txtPosti.Clear();
                        MessageBox.Show("Evento Aggiunto con successo");
                        this.Close();
                    }                  
                }
                catch
                {
                    MessageBox.Show("ERRORE! FormAggiuntaEventoCEO: errore click bottone registrati");
                    Application.Exit();
                }
            }
           
        }
    }
}
