using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila_cola_lista
{
    internal class ListaEstudiante
    {
        //Atributos de la clase
        public string TipoId { get; set; }
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Estrato { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Voto { get; set; }
    }
}
