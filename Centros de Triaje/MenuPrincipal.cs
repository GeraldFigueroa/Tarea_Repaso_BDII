using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Centros_de_Triaje.Model;

namespace Centros_de_Triaje
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            if (GlobalVariables.nivelDeAcceso.Equals("ADMIN"))
            {
                btnUsuarios.Enabled = true;
            }
            else {
                btnUsuarios.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fPersonas formPersonas = new fPersonas();
            this.Visible = false;
            formPersonas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            fEmpleados formEmpleados = new fEmpleados();
            this.Visible = false;
            formEmpleados.Show();            
                       
        }

        public Form ventanaAbierta = null;

        public void abrirVentana(Form ventana) {

            if (ventanaAbierta != null) {
                ventanaAbierta.Close();
            }
            ventanaAbierta = ventana;
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            ventana.StartPosition = FormStartPosition.CenterScreen;
            ventana.BringToFront();
            this.CenterToScreen();
            ventana.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fConsultas formConsultas = new fConsultas();
            this.Visible = false;
            formConsultas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fUsuarios formUsuarios = new fUsuarios();
            this.Visible = false;
            formUsuarios.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fLogin formLogin = new fLogin();
            this.Visible = false;
            formLogin.Show();

        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            fPruebas formPruebas = new fPruebas();
            this.Visible = false;
            formPruebas.Show();
        }
    }
}
