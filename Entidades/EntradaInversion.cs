using System;

namespace Entidades
{
   public class EntradaInversion
    {
        public int EntradaInversionID { get; set; }
        public int InversionID { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public EntradaInversion()
        {
            EntradaInversionID = 0;
            InversionID = 0;
            Fecha = DateTime.Now;
            Monto = 0;
        }
    }
}
