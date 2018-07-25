using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
   public class EntradaArticulos
    {
        [Key]
        public int EntradaArticulosID { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int ArticuloID { get; set; }

        public EntradaArticulos()
        {
            EntradaArticulosID = 0;
            Articulo= string.Empty;
            Cantidad = 0;
        }
    }
}
