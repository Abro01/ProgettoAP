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

namespace ProgettoAP.Forms.UserForm
{
    public partial class FormAcquistaBiglietto : Form
    {
        public FormAcquistaBiglietto()
        {
            InitializeComponent();

            lblNomeEvento.Text = Sessione.Evento.Nome;
            lblGenere2.Text = Sessione.Evento.Genere;
            lblDescrizione2.Text = Sessione.Evento.Descrizione;
            lblPosti2.Text = Sessione.Evento.NPosti.ToString();
            lblLuogo2.Text = Sessione.Evento.Luogo;
            Organizzazione o = Controller.GetOrganizzazioneFromID(Sessione.Evento.CodOrg);
            lblOrganizzazione2.Text = o.Nome;
            Biglietto b = Controller.GetBigliettoFromIdEvento(o.Id);
            Sessione.Biglietto = b;
            lPrezzo.Text = b.Costo.ToString();
            cbNumBig.SelectedIndex = 0;
        }

        

        private void cbNumBig_SelectedIndexChanged(object sender, EventArgs e)
        {
            int costo;
            string app = cbNumBig.Text;
            int numBig = Int32.Parse(app);          //AGGIORNO IL PREZZO IN BASE AL NUMERO DI BIGLIETTI CHE SI VOGLIONO ACQUISTARE
            if (cbPremium.Checked)
            {
                costo = Sessione.Biglietto.Costo * numBig + (numBig * 50);
                lPrezzo.Text = costo.ToString();
            }
            else
            {
                costo = Sessione.Biglietto.Costo * numBig;
                lPrezzo.Text = costo.ToString();
            }
        }

        //AGGIORNO IL PREZZO SE SI SELEZIONA L'ACQUISTO DI BIGLIETTI PREMIUM
        private void cbPremium_CheckedChanged_1(object sender, EventArgs e)
        {
            string app = cbNumBig.Text;
            int numBig = Int32.Parse(app);

            if (cbPremium.Checked)
            {
                int costo = Sessione.Biglietto.Costo * numBig + (numBig * 50);
                lPrezzo.Text = costo.ToString();
            }
            else
            {
                int costo = Sessione.Biglietto.Costo * numBig;
                lPrezzo.Text = costo.ToString();
            }
        }

        private void bAcquista_Click(object sender, EventArgs e)
        {
            string app = cbNumBig.Text;
            int numBig = Int32.Parse(app);//Prendo il numero di biglietti che l'utente vuole acquistare
            try
            {//Richiedo tramite il controller di acquistare un biglietto e di aggiornare il database
                bool isAcquistato = Controller.AcquistaBiglietti(Sessione.Biglietto.Id, Sessione.Utente.Id, cbPremium.Checked, Sessione.Evento.Id, numBig, false);
                if (isAcquistato)
                {
                    MessageBox.Show("BIGLIETTI/O ACQUISTATI/O PERFETTAMENTE");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("IMPOSSIBILE ACQUISTARE LA QUANTITA' RICHIESTA DI BIGLIETTI, DIMINUISCA IL NUMERO E RIPROVI");
                }
            }
            catch
            {
                MessageBox.Show("ERRORE NEL FORM DI ACQUISTA BIGLIETTO PER L'UTENTE");
            }
            
        }
    }
}
