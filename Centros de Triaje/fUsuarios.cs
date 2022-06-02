using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Centros_de_Triaje.Logic;
using Centros_de_Triaje.Model;

namespace Centros_de_Triaje
{
    public partial class fUsuarios : Form
    {
        public fUsuarios()
        {
            InitializeComponent();
            mostrarUsuarios();
            mostrarEmpleados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            this.Visible = false;
            formMenu.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seleccion = " ";
            if (comprobarVacios() == false)
            {
                if (txtContrasenia.Text.Equals(txtConfContra.Text))
                {
                    if (comboBoxNivel.SelectedIndex == 0)
                    {
                        seleccion = "BASIC";
                    }
                    if (comboBoxNivel.SelectedIndex == 1)
                    {
                        seleccion = "ADMIN";
                    }
                    Login oLogin = new Login()
                    {
                        idUsuario = txtIDusuario.Text,
                        identidadPersonal = txtIdentidadEmpleado.Text,
                        nombreUsuario = txtNombreUsuario.Text,
                        contrsenia = txtConfContra.Text,
                        nivelAcceso = seleccion,
                    };
                    bool respuesta = UsuariosLogic.Instancia.Guardar(oLogin);

                    if (respuesta)
                    {
                        GlobalVariables.mostrarMensajeRegistroExitoso();
                        mostrarUsuarios();
                    }
                }
                else
                {
                    GlobalVariables.mostrarMensajeErrorContrasenia();
                }
            }
            else {
                GlobalVariables.mostrarMensajeErrorVacio();
            }            
                        
        }

        private bool comprobarVacios() {
            bool vacio = true;
            if (txtIDusuario.Text != "" && txtIdentidadEmpleado.Text != "" && txtNombreUsuario.Text != "" && txtContrasenia.Text != "" && txtConfContra.Text != ""){
                if (comboBoxNivel.SelectedIndex == 0 || comboBoxNivel.SelectedIndex == 1) {
                    vacio = false;
                }                
            }
            return vacio;
        }

        public void mostrarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = UsuariosLogic.Instancia.Listar();
        }

        public void mostrarEmpleados()
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = EmpleadosLogic.InstanciaP.Listar();
        }

    }
}
