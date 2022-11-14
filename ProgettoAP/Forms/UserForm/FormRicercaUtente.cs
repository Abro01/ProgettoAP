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

namespace ProgettoAP.Forms.UserForm
{
    public partial class FormRicercaUtente : Form
    {
        public FormRicercaUtente()
        {
            InitializeComponent();
        }

        private void FormRicercaUtente_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                List<Evento> listaEventi = Controller.GetEventi();
                foreach(Evento evento in listaEventi)
                {

                }

                dtRisultati.DataSource = dt;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                // dtRisultati.Columns.Add(btn);
                btn.HeaderText = "Click Data";
                btn.Text = "ACQUISTA";      //AGGIUNGO UNA COLONNA CON IL PULSANTE ACQUISTA PER OGNI EVENTO
                btn.Name = "btn";
                btn.UseColumnTextForButtonValue = true;
            }
            catch
            {
                MessageBox.Show("ERRORE ! FormListaEventi: errore nel caricamento degli eventi disponibili");
                Application.Exit();
            }
        }
    }
}
