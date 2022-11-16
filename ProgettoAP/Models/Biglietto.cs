using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Models;

namespace ProgettoAP.Models
{
    class Biglietto
    {
        //Attributi
        private int id;
        private int costo;
        private int codEvento;

        //Costruttore
        public Biglietto(int id, int costo, int codEvento)
        {
            this.id = id;
            this.costo = costo;
            this.codEvento = codEvento;
        }

        //Costruttore vuoto
        Biglietto() { }


        //Getter & Setter
        public int Id { get => id; set => id = value; }
        public int Costo { get => costo; set => costo = value; }
        public int CodEvento { get => codEvento; set => codEvento = value; }

        //Metodi
        public static Biglietto BigliettoSToBiglietto(BigliettoS b)
        {
            return new Biglietto(b.Id, b.Costo, b.CodEvento);
        }
    }
}
