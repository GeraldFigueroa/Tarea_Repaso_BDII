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
    public class EmpleadosLogic
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static EmpleadosLogic _instanciaP = null;

        public EmpleadosLogic(){
        }

        public static EmpleadosLogic InstanciaP
        {
            get
            {
                if (_instanciaP == null){
                    _instanciaP = new EmpleadosLogic();
                }
                return _instanciaP;
            }
        }

        public bool Guardar(Model.Empleados obj){

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)){

                conexion.Open();
                string query = "INSERT INTO personal(identidad, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, sexo, puestoLaboralID, codigoCentroTriaje) VALUES(@identidad, @primerNombre, @segundoNombre, @primerApellido, @segundoApellido, @fechaNacimiento, @sexo, @puestoLaboralID, @codigoCentroTriaje)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@identidad", obj.identidad));
                cmd.Parameters.Add(new SQLiteParameter("@primerNombre", obj.primerNombre));
                cmd.Parameters.Add(new SQLiteParameter("@segundoNombre", obj.segundoNombre));
                cmd.Parameters.Add(new SQLiteParameter("@primerApellido", obj.primerApellido));
                cmd.Parameters.Add(new SQLiteParameter("@segundoApellido", obj.segundoApellido));
                cmd.Parameters.Add(new SQLiteParameter("@fechaNacimiento", obj.fechaNacimiento));
                cmd.Parameters.Add(new SQLiteParameter("@sexo", obj.sexo));
                cmd.Parameters.Add(new SQLiteParameter("@puestoLaboralID", obj.puestoLaboralID) );
                cmd.Parameters.Add(new SQLiteParameter("@codigoCentroTriaje", obj.codigoCentroTriaje));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public List<Model.Empleados> Listar(){

            List<Model.Empleados> oLista = new List<Model.Empleados>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT personal.identidad, personal.primerNombre, personal.segundoNombre, personal.primerApellido, personal.segundoApellido, personal.sexo FROM personal";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read()){                                                                        
                        oLista.Add(new Empleados(){
                            identidad = dr["identidad"].ToString(),
                            primerNombre = dr["primerNombre"].ToString(),
                            segundoNombre = dr["segundoNombre"].ToString(),
                            primerApellido = dr["primerApellido"].ToString(),
                            segundoApellido = dr["segundoApellido"].ToString(),                            
                            //fechaNacimiento = dr["fechaNacimiento"].ToString().Replace('-', '/'),
                            sexo = dr["sexo"].ToString(),
                            //puestoLaboralID = dr["puestoLaboralID"].ToString(),
                            //codigoCentroTriaje = dr["codigoCentroTrabajo"].ToString(),
                        }); 
                    }
                }


            }

            return oLista;

        }        

    }
}
