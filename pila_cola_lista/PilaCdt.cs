using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pila_cola_lista
{
    internal class PilaCdt
    {
        public decimal NumCDT { get; set; }
        public int IdCLiente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Estrato { get; set; }
        public string Categoria { get; set; }
        public string MesAbiertoCDT { get; set; }
        public int TiempoMesesCDT { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal TotalPagarCDT { get; set; }

        //Metodo para calcular el valor a pagar del CDT dependiendo de los meses
        public decimal CalcularValorPagarCDT(int meses)
        {
            decimal valor = 0;
            try
            {           
                if (meses > 0 && meses < 13)
                {
                    valor = 1000 + 2 * meses;
                }
                else if (meses > 12 && meses < 25)
                {
                    valor = 1000 + 3 * meses;
                }
                else if (meses > 24)
                {
                    valor = 1000 + 5 * meses;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //Retorna el valor a pagar
            return valor;
        }
    }
}
