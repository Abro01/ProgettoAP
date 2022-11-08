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

namespace ProgettoAP.Forms
{
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        private void Registrazione_Load(object sender, EventArgs e)
        {
            tOrg.Hide();
            cbOrg.Hide();
            this.cbOrg.DropDownStyle = ComboBoxStyle.DropDownList; //Non permette di scrivere nella combobox facendola diventare di fatto una ddlist
            string s = Controller.GetNomeOrganizzazioni();
            List<string> oInfo = s.Split('-').ToList();
            foreach(string i in oInfo)
            {
                cbOrg.Items.Add(i);
            }
        }

        private void checkBoxOrg_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxOrg.Checked)
            {
                tOrg.Show();
                cbOrg.Show();
                tUser.Hide();
                tbUser.Hide();
            }
            else
            {
                tUser.Show();
                tbUser.Show();
                tOrg.Hide();
                cbOrg.Hide();
            }
        }

        private void btnReg_Click_1(object sender, EventArgs e)
        {
            if (checkBoxOrg.Checked)
            {
                string nomeOrg = this.cbOrg.GetItemText(this.cbOrg.SelectedItem);
                if ((String.IsNullOrEmpty(tbEmail.Text)) || (String.IsNullOrEmpty(tbPassword.Text)) || (String.IsNullOrEmpty(tbNome.Text)) || (String.IsNullOrEmpty(tbCognome.Text)))
                {
                    MessageBox.Show("E' necessario compilare tutti i campi");
                }
                else
                {
                    try
                    {
                        if (Controller.RegistraCeo(tbNome.Text, tbCognome.Text, tbEmail.Text, tbPassword.Text, nomeOrg.Remove(0, 1)))
                            MessageBox.Show("Registrazione effettuata con successo");
                    }
                    catch
                    {
                        MessageBox.Show("ERRORE! FormRegistrazione: errore click bottone registrati");
                        Application.Exit();
                    }
                }
            }
            else
            {
                if ((String.IsNullOrEmpty(tbEmail.Text)) || (String.IsNullOrEmpty(tbPassword.Text)) || (String.IsNullOrEmpty(tbNome.Text)) || (String.IsNullOrEmpty(tbCognome.Text)) || (String.IsNullOrEmpty(tbUser.Text)))
                {
                    MessageBox.Show("E' necessario compilare tutti i campi");
                }
                else
                {
                    try
                    {
                        if (Controller.RegistraUtente(tbNome.Text, tbCognome.Text, tbUser.Text, tbEmail.Text, tbPassword.Text))
                            MessageBox.Show("Registrazione Effettuata con successo");
                    }
                    catch
                    {
                        MessageBox.Show("ERRORE! FormRegistrazione: errore click bottone registrati");
                        Application.Exit();
                    }
                }
            }
        }
    }
}
