using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SQLite;
using Centros_de_Triaje.Logic;
using Centros_de_Triaje.Model;

namespace Centros_de_Triaje
{
    public partial class fEmpleados : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public fEmpleados()
        {
            InitializeComponent();            
            
            mostrarCentrosDeTriaje();
            mostrarPuestosLaborales();
            mostrarEmpleados();

        }

        public void mostrarEmpleados()
        {

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = EmpleadosLogic.InstanciaP.Listar();

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            this.Visible = false;
            formMenu.Show();

        }

        private void mostrarCentrosDeTriaje() {

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT nombre FROM centroTriaje";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBoxCentroTriajes.Items.Add(dr["nombre"].ToString());
                    }
                }
            }
            listBoxCentroTriajes.EndUpdate();

        }

        private void mostrarPuestosLaborales(){

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT nombrePuesto FROM puestoLaboral";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBoxPuestoLaboral.Items.Add(dr["nombrePuesto"].ToString());
                    }
                }
            }
            listBoxPuestoLaboral.EndUpdate();

        }

        public string buscarCodigoCentro(string seleccion) {

            string respuesta = " ";

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM centroTriaje";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);                
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read()){
                        string tempID = dr["codigo"].ToString();
                        string tempNombre = dr["nombre"].ToString();
                        if (tempNombre.Equals(seleccion)){
                            respuesta = tempID;
                        }
                    }
                }
            }
            return respuesta;
        }

        public string buscarIDPuesto(string seleccion)
        {

            string respuesta = " ";

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM puestoLaboral";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string tempID = dr["idPuestoLaboral"].ToString();
                        string tempNombre = dr["nombrePuesto"].ToString();
                        if (tempNombre.Equals(seleccion))
                        {
                            respuesta = tempID;
                        }
                    }
                }
            }
            return respuesta;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seleccion = " ";
            string seleccionListaCentro = listBoxCentroTriajes.SelectedItem.ToString();
            string seleccionListaLaboral = listBoxPuestoLaboral.SelectedItem.ToString();
            if (radioButtonFemenino.Checked){
                seleccion = "F";
            }
            if (radioButtonMasculino.Checked){
                seleccion = "M";
            }
            Empleados oEmpleado = new Empleados() {
                identidad = txtIdentidad.Text,
                primerNombre = txtPrimerNombre.Text,
                segundoNombre = txtSegundoNombre.Text,
                primerApellido = txtPrimerApellido.Text,
                segundoApellido = txtSegundoApellido.Text,
                fechaNacimiento = monthCalendar1.SelectionRange.Start.ToShortDateString().Replace('/', '-'),
                sexo = seleccion,
                puestoLaboralID = buscarIDPuesto(seleccionListaLaboral),
                codigoCentroTriaje = buscarCodigoCentro(seleccionListaCentro)
            };

            bool respuesta = EmpleadosLogic.InstanciaP.Guardar(oEmpleado);

            if (respuesta)
            {
                mostrarEmpleados();
            }

        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            mostrarEmpleados();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxCentroTriajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBoxPuestoLaboral_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }   
}
