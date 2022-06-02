using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centros_de_Triaje.Model
{
    public class Consultas
    {        
        public string idConsulta { get; set; }
        public string identidadPersona { get; set; }
        public string identidadPersonal { get; set; }
        public string codigoCentroTriaje { get; set; }
        public string fechaHoraConsulta { get; set; }
        public string fechaInicioSintomas { get; set; }
        public string comentarios { get; set; }
        public string diagnosticoFinal { get; set; }
        public string positivoNegativo { get; set; }

    }

}
