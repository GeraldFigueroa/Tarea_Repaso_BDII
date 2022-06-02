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
    public class PruebasLogic
    {

        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        private static PruebasLogic _instancia = null;

        public PruebasLogic()
        {
        }

        public static PruebasLogic Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new PruebasLogic();
                }
                return _instancia;
            }
        }

        public bool Guardar(Model.Pruebas obj)
        {

            bool respuesta = true;

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "INSERT INTO pruebas(consultaID, fechaHoraPrueba, tipoPruebaID, identidadPersonal, fechaHoraResultado, resultadoPrueba) VALUES(@consultaID, @fechaHoraPrueba, @tipoPruebaID, @identidadPersonal, @fechaHoraResultado, @resultadoPrueba)";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                //cmd.Parameters.Add(new SQLiteParameter("@idPrueba", obj.idPrueba));
                cmd.Parameters.Add(new SQLiteParameter("@consultaID", obj.consultaID));
                cmd.Parameters.Add(new SQLiteParameter("@fechaHoraPrueba", obj.fechaHoraPrueba));
                cmd.Parameters.Add(new SQLiteParameter("@tipoPruebaID", obj.tipoPruebaID));
                cmd.Parameters.Add(new SQLiteParameter("@identidadPersonal", obj.identidadPersonal));
                cmd.Parameters.Add(new SQLiteParameter("@fechaHoraResultado", obj.fechaHoraResultado));
                cmd.Parameters.Add(new SQLiteParameter("@resultadoPrueba", obj.resultadoPrueba));
                cmd.CommandType = System.Data.CommandType.Text;

                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }

            }

            return respuesta;

        }

        public List<Model.Pruebas> Listar()
        {

            List<Model.Pruebas> oLista = new List<Model.Pruebas>();

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                string query = "SELECT pruebas.idPrueba, pruebas.consultaID, pruebas.tipoPruebaID, pruebas.identidadPersonal, pruebas.resultadoPrueba FROM pruebas";
                SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                cmd.CommandType = System.Data.CommandType.Text;

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new Pruebas()
                        {
                            idPrueba = Int32.Parse(dr["idPrueba"].ToString()),
                            consultaID = dr["consultaID"].ToString(),
                            //fechaHoraPrueba = dr["fechaHoraPrueba"].ToString(),
                            tipoPruebaID = Int32.Parse(dr["tipoPruebaID"].ToString()),
                            identidadPersonal = dr["identidadPersonal"].ToString(),
                            //fechaHoraResultado = dr["fechaHoraResultado"].ToString().Replace('-', '/'),
                            resultadoPrueba = dr["resultadoPrueba"].ToString(),
                        });
                    }
                }


            }

            return oLista;

        }
    }
}
