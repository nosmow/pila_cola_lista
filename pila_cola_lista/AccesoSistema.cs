using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila_cola_lista
{
    internal class AccesoSistema
    {
        private int Clave = 123;

        //Metodo que valida la clave y retorna true o false
        public bool ValidarAcceso(int clave)
        {
            if (clave == this.Clave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
