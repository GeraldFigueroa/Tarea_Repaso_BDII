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
    public partial class fConsultas : Form
    {
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public fConsultas()
        {
            InitializeComponent();
            mostrarCentrosDeTriaje();
            mostrarConsultas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string posneg = " ";
            if (comboBoxCovid.SelectedIndex == 0) {
                posneg = "P";
            }
            if (comboBoxCovid.SelectedIndex == 1) {
                posneg = "N";
            }   
            string seleccionListaCentro = listBoxCentroTriajes.SelectedItem.ToString();
            Consultas oConsulta = new Consultas()
            {
                   
                identidadPersona = txtIdentidadPersona.Text,
                identidadPersonal = txtIdentidadPersonal.Text,
                codigoCentroTriaje = buscarCodigoCentro(seleccionListaCentro),
                fechaHoraConsulta = monthCalendarConsulta.SelectionRange.Start.ToShortDateString().Replace('/', '-'),
                fechaInicioSintomas = monthCalendarSintomas.SelectionRange.Start.ToShortDateString().Replace('/', '-'),
                comentarios = richtxtComentarios.Text,
                diagnosticoFinal = richtxtDiagnostico.Text,
                positivoNegativo = posneg,
            };

            bool respuesta = ConsultasLogic.Instancia.Guardar(oConsulta);

            if (respuesta)
            {
                mostrarConsultas();
            }
        }

        public string buscarCodigoCentro(string seleccion)
        {

            string respuesta = " ";

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM centroTriaje";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string tempID = dr["codigo"].ToString();
                        string tempNombre = dr["nombre"].ToString();
                        if (tempNombre.Equals(seleccion))
                        {
                            respuesta = tempID;
                        }
                    }
                }
            }
            return respuesta;
        }

        private void mostrarCentrosDeTriaje()
        {

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

        public void mostrarConsultas()
        {

            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = ConsultasLogic.Instancia.Listar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            this.Visible = false;
            formMenu.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarConsultas();
        }

        private void txtIdentidadPersona_TextChanged(object sender, EventArgs e)
        {

        }       

    }
}
