using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgettoAP.ServiceReference;

namespace ProgettoAP.Models
{
    static class Sessione
    {
        private static Utente utente;
        private static DBServiceClient serverDB;
        private static Ceo_organizzazioni ceo;
        private static Evento evento;
        private static Biglietto biglietto;

        public static DBServiceClient ServerDB { get => serverDB; set => serverDB = value; }
        public static Utente Utente { get => utente; set => utente = value; }
        internal static Ceo_organizzazioni Ceo { get => ceo; set => ceo = value; }
        internal static Evento Evento { get => evento; set => evento = value; }
        internal static Biglietto Biglietto { get => biglietto; set => biglietto = value; }
    }
}
