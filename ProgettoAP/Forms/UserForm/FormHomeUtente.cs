﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgettoAP.Elementi;

namespace ProgettoAP.Forms.UserForm
{
    public partial class FormHomeUtente : Form
    {
        public FormHomeUtente()
        {
            InitializeComponent();
        }
        private void FormHomeUtente_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            lblTitoloDesktop.ForeColor = ThemeColor.SecondaryColor;
            lblDescrizioneDesktop.ForeColor = ThemeColor.PrimaryColor;
        }
    }
}
