using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.ServiceReference;
using System.Data;

namespace ProgettoAP.Models
{
   
    //Interazione Client e server
    class Controller
    {
        public static bool EffettuaLoginUtente(string email, string psw)
        {

            if (Sessione.ServerDB.Login(email, psw, false))
                return true;

            else
                return false;
        }

        public static Utente getInfoUser(string email, string psw)
        {
            try
            {
                Utente utente = Utente.UtenteSToUUtente(Sessione.ServerDB.InfoUtente(email, psw));
                if (utente.Id != 0)
                {
                    return utente;
                }
                return null;
            }

            catch
            {
                MessageBox.Show("ERRORE! MetodoGetInfoUser nel controller");
                Application.Exit();
            }
            return null;
        }

        public static Ceo_organizzazioni getInfoCeo(string email, string psw){
            try
            {
                Ceo_organizzazioni ceo = Ceo_organizzazioni.CeoSToCeo(Sessione.ServerDB.InfoCeo(email, psw));
                if(ceo.Id != 0)
                {
                    return ceo;
                }
                return null;        
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetInfoCeo nel controller");
                Application.Exit();
            }
            return null;
        }
        public static bool EffettuaLoginCeo(string email, string psw)
        {
            if(Sessione.ServerDB.Login(email, psw, true))
            {
                return true;
            }
            return false;
        }

        public static string GetNomeOrganizzazioni()
        {
            string s = Sessione.ServerDB.GetNomiOrganizzazioni();
            return s;
        }

        public static Organizzazione GetOrganizzazioneFromID(int id)
        {
            try
            {
                Organizzazione o = Organizzazione.OrganizzazioneSToOrganizzazione(Sessione.ServerDB.GetOrganizzazioneFromId(id));
                if(o.Id != 0)
                {
                    return o;
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! MEtodo Get OrganizzazioneFromID nel controller");
                Application.Exit();
            }
            return null;
        }
        
        public static Biglietto GetBigliettoFromIdEvento(int id)
        {
            try
            {
                Biglietto b = Biglietto.BigliettoSToBiglietto(Sessione.ServerDB.GetBigliettoFromIdEvento(id));
                if(b.Id != 0)
                {
                    return b;
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetBigliettoFromIdevento nel controller");
                Application.Exit();
            }
            return null;
        }

        public static bool RegistraUtente(string nome, string cognome, string username, string email, string password)
        {
            try
            {
                return Sessione.ServerDB.Registrazione(nome, cognome, username, email, password, false, "");
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo RegistraUtente nel controller");
                Application.Exit();
            }
            return false;
        }

        public static bool RegistraCeo(string nome, string cognome, string email, string password, string nomeOrg)
        {
            try
            {
                return Sessione.ServerDB.Registrazione(nome, cognome, "", email, password, true, nomeOrg);
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo RegistraCeo nel controller");
                Application.Exit();
            }
            return false;
        }
        public static List<Evento> GetEventi()
        {
            try
            {
                List<Evento> listaEventi= Evento.EventoSToEvento(Sessione.ServerDB.EventiDisponibili().ToList());
                if(listaEventi != null)
                {
                    return listaEventi;
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo GetEventi nel controller");
                Application.Exit();
            }
            return null;
        }

        public static bool AcquistaBiglietti(int idBig, int idUtente, bool isPremium, int idEvento, int numBig) 
        {
            try
            {
                return Sessione.ServerDB.AcquistaBiglietto(idBig, idUtente, isPremium, idEvento, numBig);
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo AcquistaBiglietti nel controller");
                Application.Exit();
            }
            return false;
        }
    }
}


