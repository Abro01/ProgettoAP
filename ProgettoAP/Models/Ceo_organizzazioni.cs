using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace ProgettoAP.Models
{
    class Ceo_organizzazioni
    {
        //Atttributi
        private int id;
        private string nome;
        private string cognome;
        private string email;
        private string password;
        private int codOrganizzazione;

        public Ceo_organizzazioni() { }

        public Ceo_organizzazioni(int id, string nome, string cognome, string email, string password, int codOrganizzazione)
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

        //Metodi
        public static Ceo_organizzazioni CeoSToCeo(Ceo_organizzazioniS c)
        {
            return new Ceo_organizzazioni(c.Id, c.Nome, c.Cognome, c.Email, c.Password, c.CodOrganizzazione);

        }

        //Convertitore di una lista di Ceo server in una lista di ceo client
        public static List<Ceo_organizzazioni> CeoSToCeo(List<Ceo_organizzazioniS> listaCeoS)
        {
            List<Ceo_organizzazioni> listC = new List<Ceo_organizzazioni>();
            foreach (Ceo_organizzazioniS c in listaCeoS)
            {
                listC.Add(new Ceo_organizzazioni(c.Id, c.Nome, c.Cognome,  c.Email, c.Password, c.CodOrganizzazione));
            }
            return listC;
        }
    }
}
