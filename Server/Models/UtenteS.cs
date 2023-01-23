using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Models
{       //Utente visibile nel Server
    public class UtenteS
    {
        //Attributi
        private int id;
        private string nome;
        private string cognome;
        private string username;
        private string email;
        private string password;

        //Costruttore Vuoto
        public UtenteS() { }

        //Costruttore della classe Utente
        public UtenteS(int id, string nome, string cognome, string username, string email, string password)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.username = username;
            this.email = email;
            this.password = password;
        }


        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }


        //Utente dal db 
        public static UtenteS GeneraUtente(string s){
            UtenteS u = new UtenteS();

            try
            {
                List<string> uInfo = s.Split('-').ToList();
                u.id = Int16.Parse(uInfo.ElementAt(0));
                u.nome = uInfo.ElementAt(1);
                u.cognome = uInfo.ElementAt(2);
                u.username = uInfo.ElementAt(3);
                u.email = uInfo.ElementAt(4);
                u.password = uInfo.ElementAt(5);

            }

            catch   
            {
                MessageBox.Show("Errore nella generazione di un utente con il metodo Genera utente nel Server");
                Application.Exit();
            }
            return u;
        }

        //Genero una lista di utenti
        public static List<UtenteS> GeneraListaUtenti(string s)
        {
            List<UtenteS> listaUtenti = new List<UtenteS>();
            try
            {
                List<string> infoUtente = s.Split('\n').ToList(); //divido l'elenco per Utente

                infoUtente.RemoveAt(infoUtente.Count - 1); //Con l'utilizzo dello split l'ultimo valore rimane vuoto

                foreach (string info in infoUtente)
                {
                    listaUtenti.Add(GeneraUtente(info));
                }
            }
            catch
            {
                MessageBox.Show("Errore nella generazione di una lista di Utenti con il metodo GeneraListaUtenti nel Server");
                Application.Exit();
            }

            return listaUtenti;
        }
    }
}
