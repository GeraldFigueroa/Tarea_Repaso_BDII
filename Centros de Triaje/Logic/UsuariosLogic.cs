using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data.SQLite;
using Centros_de_Triaje.Model;

namespace Centros_de_Triaje.Logic
{
    public class UsuariosLogic
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static UsuariosLogic _instancia = null;

        public UsuariosLogic()
        {
        }

        public static UsuariosLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UsuariosLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(Login obj)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "INSERT INTO usuarios(idUsuario, identidadPersonal, nombreUsuario, contrasenia, nivelAcceso) VALUES(@idUsuario, @identidadPersonal, @nombreUsuario, @contrasenia, @nivelAcceso)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@idUsuario", obj.idUsuario));
                cmd.Parameters.Add(new SQLiteParameter("@identidadPersonal", obj.identidadPersonal));
                cmd.Parameters.Add(new SQLiteParameter("@nombreUsuario", obj.nombreUsuario));
                cmd.Parameters.Add(new SQLiteParameter("@contrasenia", obj.contrsenia));
                cmd.Parameters.Add(new SQLiteParameter("@nivelAcceso", obj.nivelAcceso));                
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public List<Login> Listar()
        {

            List<Login> oUsuarios = new List<Login>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT * FROM usuarios";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oUsuarios.Add(new Login()
                        {
                            idUsuario = dr["idUsuario"].ToString(),
                            identidadPersonal = dr["identidadPersonal"].ToString(),
                            nombreUsuario = dr["nombreUsuario"].ToString(),
                            contrsenia = dr["contrasenia"].ToString(),
                            nivelAcceso = dr["nivelAcceso"].ToString(),                            
                        });
                    }
                }


            }

            return oUsuarios;

        }

    }
}
