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
        //RICHIEDE UN UTENTE TRAMITE EMAIL E PASSWORD PER IL LOGIN 
        public static Utente getInfoUser(string email, string psw)
        {
            try
            {
                Utente utente = Utente.UtenteSToUtente(Sessione.ServerDB.InfoUtente(email, psw));
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
        //RICHIEDE UN CEO TRAMITE EMAIL E PASSWORD PER IL LOGIN
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
        //METODO PER IL LOGIN DEL CEO
        public static bool EffettuaLoginCeo(string email, string psw)
        {
            if(Sessione.ServerDB.Login(email, psw, true))
            {
                return true;
            }
            return false;
        }
        //METODO CHE RICHEIDE IL NOME DI TUTTE LE ORGANIZZAZIONI PER LA SCELTA IN FASE DI REGISTRAZIONE PER IL CEO, PER AGGIUNGERE UN ORGANIZZAZIONE RIVOLGERSI AI PROGETTISTI
        public static string GetNomeOrganizzazioni()
        {
            string s = Sessione.ServerDB.GetNomiOrganizzazioni();
            return s;
        }

        //METODO CHE RICHIEDE UN ORGANIZZAZIONE TRAMITE IL SUO ID 
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
        //METODO CHE RICHIEDE UN BIGLIETTO TRAMITE IL SUO ID 
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
        //METODO CHE INTERAGISCE CON IL SERVER PER REGISTRARE UN UTENTE
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
        //METODO CHE INTERAGISCE CON IL SERVER PER REGISTRARE UN CEO 
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
        //RICHIEDO AL SERVER UNA LISTA DI TUTTI GLI EVENTI DISPONIBILI
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

       
        public static bool AcquistaBiglietti(int idBig, int idUtente, bool isPremium, int idEvento, int numBig, bool isCeo) 
        {
            try
            {
                return Sessione.ServerDB.AcquistaBiglietto(idBig, idUtente, isPremium, idEvento, numBig, isCeo);// PASSO AL SERVER l'id del biglietto che voglio acquistare, l'id del utente/ceo
            }                                                                                                   //se desidero un biglietto premium, l'id dell'evento pe cui voglio acquistare il biglietto
            catch                                                                                               //il numero di biglietti che desidero acquistare e se il mio account è un account ceo o utente normale
            {
                MessageBox.Show("ERRORE! Metodo AcquistaBiglietti nel controller");
                Application.Exit();
            }
            return false;
        }

        //RICHIEDO AL SERVER I DATI PER GLI EVENTI TRAMITE IL CODICE  DELL'ORGANIZZAZIONE DEL CEO CHE HA EFFETTUATO IL LOGIN
        public static List<Evento> GetEventiFromCeo(int codOrg)
        {
            try
            {
                List<Evento> listaEventi = Evento.EventoSToEvento(Sessione.ServerDB.EventiFromCeo(codOrg).ToList());
                if (listaEventi != null)
                {
                    return listaEventi;
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo GETEVENTIFROMCEO nel controller");
                Application.Exit();
            }
            return null;
        }

        //Richiedo al server una lista di utenti dell'evento di cui ho bisogno di informazioni
        public static List<Utente> GetUtentiFromEvento(int idEvento)
        {
            try
            {
                List<Utente> listaUtenti = Utente.UtenteSToUtente(Sessione.ServerDB.UtentiAquirenti(idEvento).ToList());
                if(listaUtenti != null)
                {
                    return listaUtenti;
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo GETUTENTIFROMEVENTO nel controller");
                Application.Exit();
            }
            return null;
        }

        //Richiedo al server una lista di CEO dell'evento di cui ho bisogno di  informazioni
        public static List<Ceo_organizzazioni> GetCeoFromEvento(int idEvento)
        {
            try
            {
                List<Ceo_organizzazioni> listaCeo = Ceo_organizzazioni.CeoSToCeo(Sessione.ServerDB.CeoFromEvento(idEvento).ToList());
                if (listaCeo != null)
                {
                   return listaCeo;
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo GETUTENTIFROMEVENTO nel controller");
                Application.Exit();
            }
            return null;
        }
        //VENGONO PASSATE TUTTE LE INFORMAZIONI PER L'AGGIUNTA DELL'EVENTO AL DATABASE CHE POI FARA' LA QUERY
        public static bool AggiungiEvento(string nome, string genere, string luogo, string descrizione, int nPosti, int codOrg, int costo)
        {
            try
            {
                return Sessione.ServerDB.AggiungiEvento(nome, genere, luogo, descrizione, nPosti, codOrg, costo);
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo AggiungiEvento nel controller");
                Application.Exit();
            }
            return false;
        }

        //VENGONO PASSATE TUTTE LE INFORMAZIONI PER LA MODIFICA DI UN CEO O DI UN UTENTE AL DATABASE
        public static bool Modifica(string  nome, string cognome, string username, string email, int id, bool isCeo)
        {
            try
            {
                if (isCeo)
                {
                    return Sessione.ServerDB.ModificaCeo(nome, cognome, email, id);
                }
                else
                {
                    return Sessione.ServerDB.ModificaUtente(nome, cognome, username, email, id);
                }
            }
            catch
            {
                MessageBox.Show("ERRORE! Metodo ModificaCeo o Utente  nel controller");
                Application.Exit();
            }
            return false;
        }
    }
}


