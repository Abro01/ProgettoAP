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
    public partial class FormProfiloUtente : Form
    {
        public FormProfiloUtente()
        {
            InitializeComponent();
            lblNome2.Text = Sessione.Utente.Nome;
            lblCognome2.Text = Sessione.Utente.Cognome;
            lblUsername2.Text = Sessione.Utente.Username;
            lblEmail2.Text = Sessione.Utente.Email;

        }
    }
}
