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
    public partial class FormRicercaCEO : Form
    {
        public FormRicercaCEO()
        {
            InitializeComponent();
        }

        private void FormRicercaCEO_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                List<Evento> listaEventi = Controller.GetEventi();
                dtRisultati.DataSource = listaEventi;
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                dtRisultati.Columns.Add(btn);
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

        private void dtRisultati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idEvento = dtRisultati.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            
            List<Evento> listaEventi = Controller.GetEventi();

            foreach (Evento evento in listaEventi)
            {
                if (evento.Id == Int16.Parse(idEvento))
                {
                    Sessione.Evento = evento;
                    FormAcquistaBiglietto fab = new FormAcquistaBiglietto();
                    fab.Show();
                    this.Hide();
                }
            }
        }
    }
}
