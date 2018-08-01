
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
   public  class Inversion
    {
        [Key]
        public int InversionID { get; set; }
        public decimal Monto { get; set; }

        public Inversion()
        {
            InversionID = 0;
            Monto=0;
        }
    }
}
