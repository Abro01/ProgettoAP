using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace ProgettoAP.Models
{
    class Organizzazione
    {
        private int id;
        private string nome;
        private string pIva;

        //Costruttore 
        public Organizzazione(int id, string nome, string pIva)
        {
            this.id = id;
            this.nome = nome;
            this.pIva = pIva;
        }
        //Getter & Setter
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string PIva { get => pIva; set => pIva = value; }
        

        //Costruttore Vuoto
        public Organizzazione() { }

        //Metodi
        public static Organizzazione OrganizzazioneSToOrganizzazione(OrganizzazioneS o)
        {
            return new Organizzazione(o.Id, o.Nome, o.PIva);
        }
    }
}
