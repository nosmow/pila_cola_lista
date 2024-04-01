using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pila_cola_lista
{
    internal class ColaJuventud
    {
        public int IdJoven { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Comuna { get; set; }
        public string Genero { get; set; }
        public DateTime FechaActDatos { get; set; }
        public decimal AuxilioEconomico { get; set; }

        //Metodo para calcular el auxilio economico del joven
        public decimal CalcularAuxilioE(string comuna)
        {
            if (comuna == "Comuna Noroccidental" || comuna == "Comuna Suroriental" || comuna == "Comuna Las Palmas")
            {
                AuxilioEconomico = 100000;
            }
            else
            {
                AuxilioEconomico = 50000;
            }

            return AuxilioEconomico;
        }
    }
}
