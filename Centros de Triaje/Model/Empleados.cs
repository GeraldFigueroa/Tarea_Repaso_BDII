using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centros_de_Triaje.Model
{
    public class Empleados
    {

        public string identidad { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string puestoLaboralID { get; set; }
        public string codigoCentroTriaje { get; set; }

    }
}
