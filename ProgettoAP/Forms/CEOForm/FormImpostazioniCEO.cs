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
    public partial class FormImpostazioniCEO : Form
    {
        public FormImpostazioniCEO()
        {
            InitializeComponent();
        }

        private void bModifica_Click(object sender, EventArgs e)//FORM PER CAMBIARE I DATI COME USERNAME, EMAIL, NOME E COGNOME PER IL CEO 
        {
            try
            {
                if (Controller.Modifica(txtNome.Text, txtCognome.Text, "", txtEmail.Text, Sessione.Ceo.Id, true))
                {
                    MessageBox.Show("MODIFICA DEI DATI CEO ANDATA A BUON FINE");
                    txtNome.Clear();
                    txtCognome.Clear(); //PULISCO LE TEXTBOX
                    txtEmail.Clear();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("IMPOSSIBILE MODIFICARE LE INFORMAZIONI PER IL CEO!");
            }
        }
    }
}
