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
    public partial class FormImpostazioniUtente : Form
    {
        public FormImpostazioniUtente()
        {
            InitializeComponent();
        }

        private void bModifica_Click(object sender, EventArgs e) //FORM PER CAMBIARE I DATI COME USERNAME, EMAIL, NOME E COGNOME DELL'UTENTE 
        {
            try
            {
                if (Controller.Modifica(txtNome.Text, txtCognome.Text, txtUsername.Text, txtEmail.Text, Sessione.Utente.Id, false))
                {
                    MessageBox.Show("MODIFICA DEI DATI UTENTI ANDATA A BUON FINE");
                    txtNome.Clear();
                    txtCognome.Clear(); //PULISCO LE TEXTBOX
                    txtEmail.Clear();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("IMPOSSIBILE MODIFICARE LE INFORMAZIONI PER L'UTENTE!");
            }
        }
    }
}
