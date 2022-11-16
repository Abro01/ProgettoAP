using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Models
{
    public class BigliettoS
    {
        //Attributi
        private int id;
        private int costo;
        private int codEvento;

        //Costruttore
        public BigliettoS(int id, int costo, int codEvento)
        {
            this.id = id;
            this.costo = costo;
            this.codEvento = codEvento;
        }

        //Costruttore vuoto
        BigliettoS() { }


        //Getter & Setter
        public int Id { get => id; set => id = value; }
        public int Costo { get => costo; set => costo = value; }
        public int CodEvento { get => codEvento; set => codEvento = value; }

        //METODI
        //Metodo per generare un Biglietto dalla query
        public static BigliettoS GeneraBiglietto(string s)
        {
            BigliettoS b = new BigliettoS();
            try
            {
                List<string> bInfo = s.Split('-').ToList();

                b.id = Int16.Parse(bInfo.ElementAt(0));
                b.costo = Int16.Parse(bInfo.ElementAt(1));
                b.codEvento = Int16.Parse(bInfo.ElementAt(2));
            }
            catch
            {
                MessageBox.Show("Errore nella generazione di un biglietto con il metodo GeneraBiglietto nel Server");
                Application.Exit();
            }
            return b;
        }
    }
}
