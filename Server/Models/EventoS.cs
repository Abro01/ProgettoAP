using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server.Models
{
    public class EventoS
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
        public EventoS(int id, string nome, string genere, string luogo, string descrizione, int nPosti, int codOrg)
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
        public EventoS() { }


        //Getter & Setter
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Genere { get => genere; set => genere = value; }
        public string Luogo { get => luogo; set => luogo = value; }
        public string Descrizione { get => descrizione; set => descrizione = value; }
        public int NPosti { get => nPosti; set => nPosti = value; }
        public int CodOrg { get => codOrg; set => codOrg = value; }

        //Metodi
        
        //Genera un Evento
        public static EventoS GeneraEvento(string s)
        {
            EventoS e = new EventoS();
            try
            {
                List<string> eInfo = s.Split('-').ToList();

                e.id = Int16.Parse(eInfo.ElementAt(0));
                e.nome = eInfo.ElementAt(1);
                e.genere = eInfo.ElementAt(2);
                e.luogo = eInfo.ElementAt(3);
                e.descrizione = eInfo.ElementAt(4);
                e.nPosti = Int16.Parse(eInfo.ElementAt(5));
                e.codOrg = Int16.Parse(eInfo.ElementAt(6));
            }
            catch
            {
                MessageBox.Show("Errore nella generazione di un evento con il metodo GeneraEvento nel Server");
                Application.Exit();
            }
            return e;
        }


        //Genera una lista di Eventi
        public static List<EventoS> GeneraListaEventi(string s)
        {
            List<EventoS> listaEventi = new List<EventoS>();
            try
            {
                List<string> infoEvento = s.Split('\n').ToList(); //divido l'elenco per lavoratore

                infoEvento.RemoveAt(infoEvento.Count - 1); //Con l'utilizzo dello split l'ultimo valore rimane vuoto

                foreach(string info in infoEvento)
                {
                    listaEventi.Add(GeneraEvento(info));
                }
            }
            catch
            {
                MessageBox.Show("Errore nella generazione di una lista di eventi con il metodo GeneraListaEventi nel Server");
                Application.Exit();
            }

            return listaEventi;
        }
    }
}
