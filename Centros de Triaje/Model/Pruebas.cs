using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centros_de_Triaje.Model
{
    public class Pruebas
    {
        public int idPrueba { get; set; }
        public string consultaID { get; set; }
        public string fechaHoraPrueba { get; set; }
        public int tipoPruebaID { get; set; }
        public string identidadPersonal { get; set; }
        public string fechaHoraResultado { get; set; }
        public string resultadoPrueba { get; set; }
    }
}
