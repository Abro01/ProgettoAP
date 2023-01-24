using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using Server.Models;

namespace Server
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "DBService" nel codice e nel file di configurazione contemporaneamente.
    public class DBService : IDBService
    {
        public MySqlConnection cn;
        public void Connessione()
        {
            cn = new MySqlConnection("Datasource = 127.0.0.1;username=root;password=;database=a_p_ticket");
        }


        
        public bool Login(string email, string psw, bool organizzatore)
        {
            try
            {
                if (organizzatore)             //LOGIN CEO
                {
                    string qCeo = "SELECT * FROM ceo_organizzazioni WHERE Email = '" + email + "' AND Password = MD5('" + psw + "')";    //VERIFICA CHE I DATI INSERITI SIANO PRESENTI NEL DATABASE
                    return Interazione.ReadingQuery(qCeo);
                }
                else                                         //LOGIN UTENTI NORMALI
                {
                    string qUtenti = "SELECT * FROM utenti WHERE Email = '" + email + "' AND Password = MD5('" + psw + "')";
                    return Interazione.ReadingQuery(qUtenti);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public UtenteS InfoUtente(string e, string psw)
        {
            string q = "SELECT* FROM utenti WHERE Email = '" + e + "' AND Password = MD5('" + psw + "')";

            try
            {
                string r = Interazione.GetInfo(q);
                if(r != null)
                {
                    return UtenteS.GeneraUtente(r);
                }

            }
            catch (Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LE INFORMAZIONI DELL'UTENTE: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI PER L'UTENTE AL SERVER CON SUCCESSO");
            }
            return null;
        }

        public Ceo_organizzazioniS InfoCeo(string e, string psw)
        {
            string q = "SELECT* FROM ceo_organizzazioni WHERE Email = '" + e + "' AND Password = MD5('" + psw + "')";

            try
            {
                string r = Interazione.GetInfo(q);
                if (r != null)
                {
                    return Ceo_organizzazioniS.GeneraCeo(r);
                }

            }
            catch (Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione

                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LE INFORMAZIONI DELL'UTENTE: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI PER IL CEO AL SERVER CON SUCCESSO");
            }
            return null;
        }

        public string GetNomiOrganizzazioni()
        {
            string q= "SELECT nome " +
                      "FROM organizzazione";
            try
            {
                string r = Interazione.GetInfo(q);
                if (r != null)
                {
                    return r;
                }

            }
            catch(Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER I NOMI DELLE ORGANIZZAZIONI: " + ex.ToString());
                Console.ReadLine();

            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI PER LE ORGANIZZAZIONI AL SERVER CON SUCCESSO");
            }
            return "";
        }

        public BigliettoS GetBigliettoFromIdEvento(int id)
        {
            string q = "SELECT b.*" +
                       "FROM biglietti b " +
                       "WHERE b.CODEvento = '" + id + "'";
            try
            {
                string r = Interazione.GetInfo(q);
                if (r != null)
                {
                    return BigliettoS.GeneraBiglietto(r);
                }

            }
            catch (Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA RICERCA DEL BIGLIETTO: " + ex.ToString());
                Console.ReadLine();

            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI PER IL BIGLIETTO AL SERVER CON SUCCESSO:");
            }
            return null;
        }

        //Ritorno un organizzazione tramite il suo id
        public OrganizzazioneS GetOrganizzazioneFromId(int id)
        {
            string q = "SELECT o.* " +
                      "FROM organizzazione o " +
                      "WHERE o.ID = '" + id +"'";
            try
            {
                string r = Interazione.GetInfo(q);
                if (r != null)
                {
                    return OrganizzazioneS.GeneraOrganizzazione(r);
                }

            }
            catch (Exception ex)
            {
                if (Interazione.Connessione != null) //Controllo che la connessione sia stata aperta
                    Interazione.Connessione.Close(); //Chiudo la connessione
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA RICERCA DI UN ORGANIZZAZIONE: " + ex.ToString());
                Console.ReadLine();

            }
            finally
            {
                Console.WriteLine("DATI RICHIESTI PER L'ORGANIZZAZIONE AL SERVER CON SUCCESSO");
            }
            return null;
        }

        //Registrazione ceo e utente sul db
        public bool Registrazione(string nome, string cognome, string username, string email, string password, bool isOrganizzatore, string nomeOrg)
        {
            try
            {
                if (isOrganizzatore)//Controllo se vuole fare la registrazione un ceo di un organizzazione
                {
                    string qIdOrg = "SELECT ID " +
                                    "FROM organizzazione " +
                                    "WHERE Nome = '" + nomeOrg + "'";
                    string r = Interazione.GetInfo(qIdOrg);
                    List<string> info = r.Split('-').ToList();
                    int idOrg = Int16.Parse(info.ElementAt(0));
                    
                    if(idOrg != 0)
                    {
                        string query = $"INSERT INTO `ceo_organizzazioni` (`ID`, `Nome`, `Cognome`, `Email`, `Password`, `CODOrganizzazione`) VALUES ('', '" + nome + "', '" + cognome + "', '" + email + "', MD5('" + password + "'), '" + idOrg + "');";     //INSERIAMO NEL DATABASE I DATI INSERITI NELLE TEXTBOX E SELEZIONATI NELLA COMBOBOX
                        return Interazione.WritingQuery(query);
                    }
                }
                else//Se non è un CEO registro un utente
                {
                    string query = $"INSERT INTO `utenti` (`ID`, `Nome`, `Cognome`, `Username`, `Email`, `Password`) VALUES ('', '" + nome + "', '" + cognome + "', '" + username + "', '" + email + "', MD5('" + password + "'));";           //INSERIMENTO DATI
                    return Interazione.WritingQuery(query);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA REGISTRAZIONE: " + ex.ToString());
                Console.ReadLine();
            }
            return false;
        }


        public List<EventoS> EventiDisponibili()//Ritorno tutti gli eventi disponibili sul sito
        {
            try
            {
                string query = "SELECT ID, Nome, Genere, Luogo, Descrizione, Nposti, CODOrganizzazione FROM eventi";  //MOSTRO TUTTI GLI EVENTI DISPONIBILI
                return EventoS.GeneraListaEventi(Interazione.GetInfo(query));    
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA RICERCA DEGLI EVENTI DISPONIBILI: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per gli eventi disponibili recuperati con successo");
            }
            return null;
        }
        //Acquisto biglietti per ceo o utente
        public bool AcquistaBiglietto(int idBig, int idUtente, bool isPremium, int idEvento, int numBig, bool isCeo)
        {
            try
            {
                string queryPosti = "SELECT NPosti " +
                                    "FROM Eventi " +
                                    "WHERE ID = '" + idEvento + "'";

                string r = Interazione.GetInfo(queryPosti);
                List<string> info = r.Split('-').ToList();
                int posti = Int16.Parse(info.ElementAt(0));
                int bigPremium = Convert.ToInt32(isPremium);
                if (posti < numBig)
                    return false;
                string queryAggPosti = "UPDATE eventi SET Nposti = Nposti - " + numBig + " WHERE ID = '" + idEvento + "'";
                Interazione.WritingQuery(queryAggPosti);
                string query;

                if (isCeo) //CONTROLLO CHE L'UTENTE PASSATO SIA UN CEO ED IN QUEL CASO INTERAGISCO CON CEO_BIGLIETTI
                {
                    query = $"INSERT INTO `ceo_biglietti` (`ID`, `Premium`, `CODCeo`, `CODBiglietto`) VALUES ('','" + bigPremium + "','" + idUtente + "','" + idBig + "')";
                    for (int i = 1; i < numBig; i++)
                    {
                        Interazione.WritingQuery(query);
                    }
                    return Interazione.WritingQuery(query);
                }
                else//NEL CASO SIA UN UTENTE INTERAGISCO CON LA TABELLA utenti_biglietti NEL DB
                {
                    query = $"INSERT INTO `utenti_biglietti` (`ID`, `Premium`, `CODUtente`, `CODBiglietto`) VALUES ('','" + bigPremium + "','" + idUtente + "','" + idBig + "')";
                    for (int i = 1; i < numBig; i++)
                    {
                        Interazione.WritingQuery(query);
                    }
                    return Interazione.WritingQuery(query);
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA CREAZIONE DI UN BIGLIETTO_UTENTE: " + ex.ToString());
                Console.ReadLine();
            }
            return false;
        }

        public List<EventoS> EventiFromCeo(int codOrg)//RICERCO TRAMITE QUERY TUTTI GLI EVENTI CREATI DALL'ORGANIZZAZIONE DEL CEO LOGGATO
        {
            try
            {
                string query = "SELECT ID, Nome, Genere, Luogo, Descrizione, Nposti, CODOrganizzazione FROM eventi WHERE CodOrganizzazione = " +codOrg;  //MOSTRO TUTTI GLI EVENTI DEL CEO
                return EventoS.GeneraListaEventi(Interazione.GetInfo(query));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA RICERCA DEGLI EVENTI DA UN CEO: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per gli eventi disponibili da un ceo recuperati con successo");
            }
            return null;
        }
        //Ritorno una lista di utenti che hanno acquistato un biglietto per un determinato evento
        public List<UtenteS> UtentiAquirenti(int idEvento) 
        {
            try
            {
                string query =  "SELECT u.ID, u.Nome, u.Cognome, u.Username, u.Email, u.Password " +
                                "FROM utenti u, biglietti b, utenti_biglietti ub " +    //CERCO LE INFORMAZIONI DEGLI UTENTI CHE CHE HANNO ACQUISTATO DEI  BIGLIETTI PER UN CERTO EVENTO SELEZIONATO
                                "WHERE b.ID=ub.CODBiglietto AND ub.CODUtente=u.ID " +   //TRAMITE L'ID DELL'EVENTO
                                "AND b.CODEvento = '" + idEvento + "'";
                return UtenteS.GeneraListaUtenti(Interazione.GetInfo(query));
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA RICERCA DEGLI UTENTI ACQUIRENTI DI UN CERTO EVENTO: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per gli utenti che hanno acquistato un determinato biglietto di un evento presi con successo");
            }
            return null;
        }

        //Ritorno una lista di ceo che hanno acquistato un biglietto per un determinato evento
        public List<Ceo_organizzazioniS> CeoFromEvento(int idEvento)
        {
            try
            {
                string query = "SELECT c.ID, c.Nome, c.Cognome, c.Email, c.Password, c.CODOrganizzazione " +
                                "FROM ceo_organizzazioni c, biglietti b, ceo_biglietti cb " +    //CERCO LE INFORMAZIONI DEI CEO CHE CHE HANNO ACQUISTATO DEI  BIGLIETTI PER UN CERTO EVENTO SELEZIONATO
                                "WHERE b.ID=cb.CODBiglietto AND cb.CODCeo=c.ID " +   //TRAMITE L'ID DELL'EVENTO
                                "AND b.CODEvento = '" + idEvento + "'";
                return Ceo_organizzazioniS.GeneraListaCeo(Interazione.GetInfo(query));
            }
            catch (Exception ex){
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER LA RICERCA DEI CEO ACQUIRENTI DI UN CERTO EVENTO: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per i ceo che hanno acquistato un biglietto per un deteminato evento con successo");
            }
            return null;
        }
        public bool AggiungiEvento(string nome, string genere, string luogo, string descrizione, int nPosti, int codOrg, int costo)
        {
            try
            {
                string queryE = $"INSERT INTO `eventi` (`ID`, `Nome`, `Genere`, `Luogo`, `Descrizione`, `NPosti`, `CODOrganizzazione`) VALUES('', '" + nome +  "','" + genere  + "','" + luogo + "','" + descrizione + "','" + nPosti + "','" + codOrg + "')";
                if (Interazione.WritingQuery(queryE))//SE LA QUERY PER INSERIRE UN EVENTO VA A BUON FINE SI EFFETTUA LA QUERY PER L'INSERIMENTO DEL BIGLIETTO COLLEGATO ALLO STESSO
                {
                    string queryId = "SELECT ID " + //PRENDO L'ID DELL'EVENTO APPENA INSERITO TRAMITE LE SUE INFORMAZIONI 
                                    "FROM Eventi " +
                                    "WHERE nome = '" + nome + "' AND Genere = '" + genere + "' AND Descrizione = '" + descrizione +"'" ;

                    string r = Interazione.GetInfo(queryId);
                    List<string> info = r.Split('-').ToList();
                    int idEvento = Int16.Parse(info.ElementAt(0));

                    string queryB = $"INSERT INTO `biglietti` (`ID`, `Costo`, `CODEvento`) VALUES('', '" + costo + "', '" + idEvento + "')"; //INSERISCE IL BIGLIETTO COLLEGATO ALL'EVENTO APPENA CREATO
                    return Interazione.WritingQuery(queryB);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER L'AGGIUNTA DI UN EVENTO PER UN ORGANIZZAZIONE: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per gli eventi disponibili da un ceo recuperati con successo");
            }
            return false;
        }

        public bool ModificaUtente(string nome, string cognome, string username, string email, int id)
        {
            try
            {
                string query = "UPDATE utenti " +
                               "SET Nome = '" + nome + "', Cognome = '" + cognome + "', Username = '" + username + "', Email = '" + email + "' " +
                               "WHERE ID = '" + id + "'";
                return Interazione.WritingQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER L'AGGIORNAMENTO DEI DATI DI UN UTENTE: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per l'utente Modificati con successo");
            }
            return false;
        }
        public bool ModificaCeo(string nome, string cognome, string email, int id)
        {
            try
            {
                string query = "UPDATE ceo_organizzazioni " +
                               "SET Nome = '" + nome + "', Cognome = '" + cognome + "', Email = '" + email + "' " +
                               "WHERE ID = '" + id + "'";
                return Interazione.WritingQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRORE NELL'ESECUZIONE DELLA QUERY PER L'AGGIORNAMENTO DEI DATI DI UN CEO: " + ex.ToString());
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Dati per il CEO Modificati con successo");
            }
            return false;
        }

    }
}
