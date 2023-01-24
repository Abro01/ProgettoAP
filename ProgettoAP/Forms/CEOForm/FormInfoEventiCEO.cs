using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.Models;

namespace ProgettoAP.Forms.CEOForm
{
    public partial class FormInfoEventiCEO : Form
    {
        public FormInfoEventiCEO()
        {
            InitializeComponent();

        }

        private void FormInfoEventiCEO_Load(object sender, EventArgs e)
        {
            try
            {   //RICHIEDO UNA LISTA DI UTENTI E DI CEO CHE HANNO ACQUISTATO UN BIGLIETTO PER QUESTO EVENTO E LO INSERISCO IN UNA DATATABLE
                List<Utente> listaUtenti = Controller.GetUtentiFromEvento(Sessione.Evento.Id);
                List<Ceo_organizzazioni> listaCeo = Controller.GetCeoFromEvento(Sessione.Evento.Id);

                dtUtenti.DataSource = listaUtenti;
                dtUtenti.Columns.Remove("Password");

                dtCeo.DataSource = listaCeo;
                dtCeo.Columns.Remove("Password");
            }
            catch
            {
                MessageBox.Show("ERRORE ! FormInfoEventi: errore nel caricamento degli utenti che hanno acquistato un biglietto per quell'evento  ");
                Application.Exit();
            }
        }

        private void lblTitolo_Click(object sender, EventArgs e)
        {

        }
    }
}
