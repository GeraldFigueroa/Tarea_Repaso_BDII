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
    public class ConsultasLogic
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static ConsultasLogic _instancia = null;

        public ConsultasLogic()
        {
        }

        public static ConsultasLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ConsultasLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(Model.Consultas obj){

            bool respuesta = true;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))            {
                conexion.Open();
                string query = "INSERT INTO consultas(identidadPersona, identidadPersonal, codigoCentroTriaje, fechaHoraConsulta, fechaInicioSintomas, comentarios, diagnosticoFinal, positivoNegativo) VALUES(@identidadPersona, @identidadPersonal, @codigoCentroTriaje, @fechaHoraConsulta, @fechaInicioSintomas, @comentarios, @diagnosticoFinal, @positivoNegativo)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.Parameters.Add(new SQLiteParameter("@identidadPersona", obj.identidadPersona));
                cmd.Parameters.Add(new SQLiteParameter("@identidadPersonal", obj.identidadPersonal));
                cmd.Parameters.Add(new SQLiteParameter("@codigoCentroTriaje", obj.codigoCentroTriaje));
                cmd.Parameters.Add(new SQLiteParameter("@fechaHoraConsulta", obj.fechaHoraConsulta));
                cmd.Parameters.Add(new SQLiteParameter("@fechaInicioSintomas", obj.fechaInicioSintomas));
                cmd.Parameters.Add(new SQLiteParameter("@comentarios", obj.comentarios));
                cmd.Parameters.Add(new SQLiteParameter("@diagnosticoFinal", obj.diagnosticoFinal));
                cmd.Parameters.Add(new SQLiteParameter("@positivoNegativo", obj.positivoNegativo));                
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1){
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public List<Model.Consultas> Listar()
        {

            List<Model.Consultas> oLista = new List<Model.Consultas>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena)){

                conexion.Open();
                string query = "SELECT * FROM consultas";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader()){
                    while (dr.Read()){
                        oLista.Add(new Consultas(){
                            //idConsulta = dr["idConsluta"].ToString(),
                            identidadPersona = dr["identidadPersona"].ToString(),
                            identidadPersonal = dr["identidadPersonal"].ToString(),
                            codigoCentroTriaje = dr["codigoCentroTriaje"].ToString(),
                            //fechaHoraConsulta = dr["fechaHoraConsulta"].ToString(),
                            //fechaInicioSintomas = dr["fechaInicioSintomas"].ToString(),
                            comentarios = dr["comentarios"].ToString(),
                            diagnosticoFinal = dr["diagnosticoFinal"].ToString(),
                            positivoNegativo = dr["positivoNegativo"].ToString(),                            
                        });
                    }
                }


            }

            return oLista;

        }

    }
}
