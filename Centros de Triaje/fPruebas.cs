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
    public partial class fPruebas : Form
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public fPruebas()
        {
            InitializeComponent();
            mostrarTiposPruebas();
            mostrarPruebas();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal formMenu = new MenuPrincipal();
            this.Visible = false;
            formMenu.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            if (comprobarVacios() == false)
            {
                string seleccionListaTipoPrueba = listBoxTiposPrueba.SelectedItem.ToString();
                Pruebas oPrueba = new Pruebas()
                {
                    consultaID = txtNumConsulta.Text,
                    fechaHoraPrueba = monthCalendar1.SelectionRange.Start.ToShortDateString().Replace('/', '-'),
                    tipoPruebaID = buscarIDPrueba(seleccion),
                    identidadPersonal = txtIdentidadDoctor.Text,
                    fechaHoraResultado = monthCalendar2.SelectionRange.Start.ToShortDateString().Replace('/', '-'),
                    resultadoPrueba = richtxtResultadoPrueba.Text,
                };

                bool respuesta = PruebasLogic.Instancia.Guardar(oPrueba);

                if (respuesta)
                {
                    GlobalVariables.mostrarMensajeRegistroExitoso();
                    mostrarPruebas();
                }
            }
            else { 
                GlobalVariables.mostrarMensajeErrorVacio();
            }
        }


        private void mostrarTiposPruebas()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT nombrePrueba FROM tipoPrueba";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBoxTiposPrueba.Items.Add(dr["nombrePrueba"].ToString());
                    }
                }
            }
            listBoxTiposPrueba.EndUpdate();
        }

        public int buscarIDPrueba(string seleccion)
        {
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                string query = "SELECT * FROM tipoPrueba";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string tempID = dr["idTipoPrueba"].ToString();
                        string tempNombre = dr["nombrePrueba"].ToString();
                        if (tempNombre.Equals(seleccion))
                        {
                            respuesta = Int32.Parse(tempID);
                        }
                    }
                }
            }
            return respuesta;
        }

        private bool comprobarVacios() {
            bool vacio = true;
            if (txtNumConsulta.Text != "" && txtIdentidadDoctor.Text != "" && richtxtResultadoPrueba.Text != "") {
                if (listBoxTiposPrueba.SelectedIndex == 0 || listBoxTiposPrueba.SelectedIndex == 1 || listBoxTiposPrueba.SelectedIndex == 2 || listBoxTiposPrueba.SelectedIndex == 3) {
                    vacio = false;
                }
            }
            return vacio;
        }

        public void mostrarPruebas()
        {
            dgvPruebas.DataSource = null;
            dgvPruebas.DataSource = PruebasLogic.Instancia.Listar();
        }

    }
}
