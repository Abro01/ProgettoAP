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
                    if (Controller.EffettuaLoginUtente(email, password)) ///Controllo l'esistenza di questo utente sul db
                    {
                        Utente utente = Controller.getInfoUser(email, password);//Se l'utente esiste e la psw è corretta allora effettua il login 

                        if (utente != null)
                        {
                            Sessione.Utente = utente;
                            FormInterfacciaUtente home = new FormInterfacciaUtente();              
                            home.ShowDialog();
                            this.Hide();
                        }
                    }
                    else
                        MessageBox.Show("Username o password non validi");
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
                    if (Controller.EffettuaLoginCeo(email, password)) // Controllo l'esistenza del ceo nel db 
                    {
                        Ceo_organizzazioni ceo = Controller.getInfoCeo(email, password); // Se il ceo esiste allora effettuo il login 
                        if (ceo != null)
                        {
                            Sessione.Ceo = ceo;
                            FormInterfacciaCEO home = new FormInterfacciaCEO();
                            home.ShowDialog();
                            this.Hide();
                            MessageBox.Show("Login ceo effettuato con successo: " + ceo.Nome);
                        }
                    }
                    else
                        MessageBox.Show("Username o password non validi");
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
