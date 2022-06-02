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
using Centros_de_Triaje.Model;
using System.Data.SQLite;

namespace Centros_de_Triaje
{
    public partial class fLogin : Form
    {
        
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        public fLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e){

            if (comprobarCamposVacios() == false)
            {
                bool respuesta = buscarUsuarioContrasenia(txtUsuario.Text, txtContrasenia.Text);
                if (respuesta == true)
                {
                    GlobalVariables.mostrarMensajeBienvenida();
                    MenuPrincipal formMenu = new MenuPrincipal();
                    this.Visible = false;
                    formMenu.Show();
                }
                else
                {
                    GlobalVariables.mostrarMensajeErrorLogin();
                }
            }
            else 
            {
                GlobalVariables.mostrarMensajeErrorVacio();
            }
            
        }        
        public bool buscarUsuarioContrasenia(string usuario, string contrasenia){
            
            bool respuesta = false; 
            using (SQLiteConnection conexion = new SQLiteConnection(cadena)){
                conexion.Open();
                string query = "SELECT * FROM usuarios";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                using (SQLiteDataReader dr = cmd.ExecuteReader()){
                    while (dr.Read()){
                        string tempUsuario = dr["nombreUsuario"].ToString();
                        string tempContrasenia = dr["contrasenia"].ToString();
                        string tempNivel = dr["nivelAcceso"].ToString();
                        if (tempUsuario.Equals(usuario) && tempContrasenia.Equals(contrasenia)){
                            respuesta = true;
                            GlobalVariables.nivelDeAcceso = tempNivel;
                        }
                    }
                }
            }
            return respuesta;
        }

        public bool comprobarCamposVacios() { 
        
            bool camposVacios = true;

            if (txtUsuario.Text != "" && txtContrasenia.Text != "") {
                camposVacios = false;
            }

            return camposVacios;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
