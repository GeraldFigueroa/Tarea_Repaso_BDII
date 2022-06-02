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
    public partial class fPersonas : Form
    {
        public fPersonas()
        {
            InitializeComponent();
            mostrarPersonas();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string seleccion = " ";
            if (radioButtonFemenino.Checked){
                seleccion = "F";
            }
            if (radioButtonMasculino.Checked) {
                seleccion = "M";
            }
            Persona oPersona = new Persona() {
                identidad = txtIdentidad.Text,
                primerNombre = txtPrimerNombre.Text,
                segundoNombre = txtSegundoNombre.Text,
                primerApellido = txtPrimerApellido.Text,
                segundoApellido = txtSegundoApellido.Text,
                fechaNacimiento = monthCalendar1.SelectionRange.Start.ToShortDateString().Replace('/','-'),
                sexo = seleccion,
            };

            bool respuesta = PersonaLogic.Instancia.Guardar(oPersona);

            if (respuesta) {
                mostrarPersonas();
            }

        }

        public void mostrarPersonas() { 
            
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = PersonaLogic.Instancia.Listar();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarPersonas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            this.Visible = false;
            formMenu.Show();

        }
    }
}
