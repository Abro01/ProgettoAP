using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoAP.Models
{
    class ceo_biglietti
    {
        //Attributi 
        private int id;
        private bool premium;
        private int CODBiglietto;
        private int CODCeo;

        public ceo_biglietti() { }


        public ceo_biglietti(int id, bool premium, int cODBiglietto, int cODCeo)
        {
            this.id = id;
            this.premium = premium;
            CODBiglietto = cODBiglietto;
            CODCeo = cODCeo;
        }

        public int Id { get => id; set => id = value; }
        public bool Premium { get => premium; set => premium = value; }
        public int CODBiglietto1 { get => CODBiglietto; set => CODBiglietto = value; }
        public int CODCeo1 { get => CODCeo; set => CODCeo = value; }
    }
}
