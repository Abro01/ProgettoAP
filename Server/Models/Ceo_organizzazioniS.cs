using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Models
{
    public class Ceo_organizzazioniS
    {
        //Atttributi
        private int id;
        private string nome;
        private string cognome;
        private string email;
        private string password;
        private int codOrganizzazione;

        public Ceo_organizzazioniS() { }

        public Ceo_organizzazioniS(int id, string nome, string cognome, string email, string password, int codOrganizzazione)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.password = password;
            this.codOrganizzazione = codOrganizzazione;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public int CodOrganizzazione { get => codOrganizzazione; set => codOrganizzazione = value; }
        
        //CEO DAL DB
        public static Ceo_organizzazioniS GeneraCeo(string s)
        {
            Ceo_organizzazioniS c = new Ceo_organizzazioniS();
            try
            {
                List<string> cInfo = s.Split('-').ToList();
                c.id = Int16.Parse(cInfo.ElementAt(0));
                c.nome = cInfo.ElementAt(1);
                c.cognome = cInfo.ElementAt(2);
                c.email = cInfo.ElementAt(3);
                c.password = cInfo.ElementAt(4);
                c.CodOrganizzazione = Int16.Parse(cInfo.ElementAt(5));

            }

            catch
            {
                MessageBox.Show(s);
                Application.Exit();
            }
            return c;
        }

        //Genero una lista di cEO
        public static List<Ceo_organizzazioniS> GeneraListaCeo(string s)
        {
            List<Ceo_organizzazioniS> listaCeo = new List<Ceo_organizzazioniS>();
            try
            {
                List<string> infoCeo = s.Split('\n').ToList(); //divido l'elenco per Ceo

                infoCeo.RemoveAt(infoCeo.Count - 1); //Con l'utilizzo dello split l'ultimo valore rimane vuoto

                foreach (string info in infoCeo)
                {
                    listaCeo.Add(GeneraCeo(info));
                }
            }
            catch
            {
                MessageBox.Show("Errore nella generazione di una lista di Ceo con il metodo GeneraListaUtenti nel Server");
                Application.Exit();
            }

            return listaCeo;
        }

    }
}
