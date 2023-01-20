using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace ProgettoAP.Models
{
    class Utenti_biglietti
    {
        //Attributi 
        private int id;
        private bool premium;
        private int CODUTente;
        private int CODBiglietto;

        //Costruttore Vuoto
        public Utenti_biglietti() { }

        //Costruttore classe
        public Utenti_biglietti(int id, bool premium, int cODUTente, int cODBiglietto)
        {
            this.Id = id;
            this.Premium = premium;
            CODUTente1 = cODUTente;
            CODBiglietto1 = cODBiglietto;
        }

        //GETTER & SETTER
        public int Id { get => id; set => id = value; }
        public bool Premium { get => premium; set => premium = value; }
        public int CODUTente1 { get => CODUTente; set => CODUTente = value; }
        public int CODBiglietto1 { get => CODBiglietto; set => CODBiglietto = value; }
        
        
    }
}
