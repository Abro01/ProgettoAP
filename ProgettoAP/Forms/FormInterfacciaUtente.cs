﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ProgettoAP.Elementi;


namespace ProgettoAP.Forms
{
    public partial class FormInterfacciaUtente : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FormInterfacciaUtente()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];

            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnlTitolo.BackColor = color;
                    pnlLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDesktop.Controls.Add(childForm);
            this.pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitolo.Text = childForm.Text;
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm.FormHomeUtente(), sender);
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm.FormRicercaUtente(), sender);
        }

        private void btnProfilo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm.FormProfiloUtente(), sender);
        }

        private void btnImpostazioni_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.UserForm.FormImpostazioniUtente(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login logout = new Login();
            logout.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitolo.Text = "Anteprima";
            pnlTitolo.BackColor = Color.FromArgb(0, 150, 136);
            pnlLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


    }
}
