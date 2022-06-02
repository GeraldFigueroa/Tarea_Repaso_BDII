using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Centros_de_Triaje.Model;
using System.Data.SQLite;

namespace Centros_de_Triaje.Logic
{
    public class PersonaLogic
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PersonaLogic _instancia = null;

        public PersonaLogic(){
        }

        public static PersonaLogic Instancia
        {
            get
            {
                if(_instancia == null){ 
                    _instancia = new PersonaLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(Persona obj) {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)) {

                conexion.Open();
                string query = "INSERT INTO personas(identidad, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, sexo) VALUES(@identidad, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @fechaNacimiento, @sexo)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@identidad", obj.identidad));
                cmd.Parameters.Add(new SQLiteParameter("@primerNombre", obj.primerNombre));
                cmd.Parameters.Add(new SQLiteParameter("@segundoNombre", obj.segundoNombre));
                cmd.Parameters.Add(new SQLiteParameter("@primerApellido", obj.primerApellido));
                cmd.Parameters.Add(new SQLiteParameter("@segundoApellido", obj.segundoApellido));
                cmd.Parameters.Add(new SQLiteParameter("@fechaNacimiento", obj.fechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@sexo", obj.sexo));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1) {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public List<Persona> Listar() { 

            List<Persona> oLista = new List<Persona>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT * FROM personas";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);                
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {                    
                    while (dr.Read()) {
                        oLista.Add(new Persona()
                        {
                            identidad = dr["identidad"].ToString(),
                            primerNombre = dr["primerNombre"].ToString(),
                            segundoNombre = dr["segundoNombre"].ToString(),
                            primerApellido = dr["primerApellido"].ToString(),
                            segundoApellido = dr["segundoApellido"].ToString(),
                            //fechaNacimiento = dr["fechaNacimiento"].ToString().Replace('-', '/'),
                            sexo = dr["sexo"].ToString(),
                        });
                    }
                }
               

            }

            return oLista;

        }

    }
}
