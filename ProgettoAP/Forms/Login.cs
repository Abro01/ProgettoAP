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
using ProgettoAP.Forms.UserForm;

namespace ProgettoAP.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click_1(object sender, EventArgs e)
        {
            bool ceoLogin = cbCeo.Checked;
            string email = tbEmail.Text;
            string password = tbPsw.Text;

            if (!ceoLogin)//login UTENTE
            {
                try
                {
                    if (Controller.EffettuaLoginUtente(email, password)) ///Effettuo il login
                    {
                        Utente utente = Controller.getInfoUser(email, password);

                        if (utente != null)
                        {
                            Sessione.Utente = utente;
                            MessageBox.Show("Login utente effettuato con successo: " + utente.Nome);
                            FormListaEventi fle = new FormListaEventi();
                            fle.Show();
                            this.Hide();
                        }

                        else
                            MessageBox.Show("Username o password non validi");
                    }
                }

                catch
                {
                    MessageBox.Show("ERRORE! FormLogin: errore click bottone accesso");
                    Application.Exit();
                }
            }

            //login CEO
            else
            {
                try
                {
                    if (Controller.EffettuaLoginCeo(email, password))
                    {
                        Ceo_organizzazioni ceo = Controller.getInfoCeo(email, password);
                        if (ceo != null)
                        {
                            Sessione.Ceo = ceo;
                            MessageBox.Show("Login ceo effettuato con successo: " + ceo.Nome);
                        }
                        else
                            MessageBox.Show("Username o password non validi");
                    }
                }
                catch
                {
                    MessageBox.Show("ERRORE! FormLogin(CEO): errore click bottone accesso");
                    Application.Exit();
                }
            }

        }

        private void lbRegistrazione_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrazione reg = new Registrazione();
            reg.Show();
            this.Hide();
        }
    }
}
