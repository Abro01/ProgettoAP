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

        private void bCerca_Click(object sender, EventArgs e)
        {
            (dtRisultati.DataSource as DataTable).DefaultView.RowFilter = String.Format("Nome like '%{0}%'", txtNomeEvento.Text);
        }
    }
}
