using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace ProgettoAP.Models
{
    class Evento
    {
        //Attributi
        private int id;
        private string nome;
        private string genere;
        private string luogo;
        private string descrizione;
        private int nPosti;
        private int codOrg;


        //Costruttore
        public Evento(int id, string nome, string genere, string luogo, string descrizione, int nPosti, int codOrg)
        {
            this.id = id;
            this.nome = nome;
            this.genere = genere;
            this.luogo = luogo;
            this.descrizione = descrizione;
            this.nPosti = nPosti;
            this.codOrg = codOrg;
        }

        //Costruttore Vuoto
        public Evento() { }


        //Getter & Setter
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Genere { get => genere; set => genere = value; }
        public string Luogo { get => luogo; set => luogo = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public int NPosti { get => nPosti; set => nPosti = value; }
        public int CodOrg { get => codOrg; set => codOrg = value; }

        //Converte un EventoS (server) in un evento utilizzabile nel client
        public static Evento EventoSToEvento(EventoS e)
        {
            return new Evento(e.Id, e.Nome, e.Genere, e.Luogo, e.Descrizione, e.NPosti, e.CodOrg);
        }

        //Converte una lista di EventoS(Server) in una lista di eventi 
        public static List<Evento> EventoSToEvento(List<EventoS> listaEventiS)
        {
            List<Evento> listE = new List<Evento>();
            foreach(EventoS e in listaEventiS)
            {
                listE.Add(new Evento(e.Id, e.Nome, e.Genere, e.Luogo, e.Descrizione, e.NPosti, e.CodOrg));
            }
            return listE;
        }
    }
}
