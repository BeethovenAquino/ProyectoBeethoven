using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
   public class Pagos
    {
        public int PagoID { get; set; }
        public int InversionID { get; set; }
        public int FacturaID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Abono { get; set; }

        public Pagos()
        {
            PagoID = 0;
            InversionID = 0;
            FacturaID = 0;
            Fecha = DateTime.Now;
            Abono = 0;
        }
    }
}
