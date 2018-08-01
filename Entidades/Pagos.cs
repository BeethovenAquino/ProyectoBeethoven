using System;

using System.ComponentModel.DataAnnotations;


namespace Entidades
{
   public class Pagos
    {
        [Key]
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
