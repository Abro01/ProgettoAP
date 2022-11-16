using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Models
{
    public class OrganizzazioneS
    {
       
        private int id;
        private string nome;
        private string pIva;

        //Costruttore 
        public OrganizzazioneS(int id, string nome, string pIva)
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
        public OrganizzazioneS() { }

        //METODI

        //Genera Organizzazione dalla query
        public static OrganizzazioneS GeneraOrganizzazione(string s)
        {
            OrganizzazioneS o = new OrganizzazioneS();
            try
            {
                List<string> oInfo = s.Split('-').ToList();

                o.id = Int16.Parse(oInfo.ElementAt(0));
                o.nome = oInfo.ElementAt(1);
                o.pIva = oInfo.ElementAt(2);

            }
            catch
            {
                MessageBox.Show("Errore nella generazione di un evento con il metodo GeneraOrganizzazione nel Server");
                Application.Exit();
            }
            return o;
        }
        
    }
}
