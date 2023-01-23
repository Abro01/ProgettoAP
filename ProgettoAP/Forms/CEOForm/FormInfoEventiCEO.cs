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
            {
                List<Utente> listaUtenti = Controller.GetUtentiFromEvento(Sessione.Evento.Id);
                dtUtenti.DataSource = listaUtenti;
                dtUtenti.Columns.Remove("Password");
            }
            catch
            {
                MessageBox.Show("ERRORE ! FormInfoEventi: errore nel caricamento degli utenti che hanno acquistato un biglietto per quell'evento  ");
                Application.Exit();
            }
        }
    }
}
