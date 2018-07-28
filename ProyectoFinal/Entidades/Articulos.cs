using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Articulos
    {
        [Key]
        public int ArticuloID { get; set; }
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public DateTime Fecha { get; set; }
        public int Vigencia { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
        public string Ganancia { get; set; }
        
        public Articulos()
        {
            ArticuloID = 0;
            CodigoArticulo = string.Empty;
            Nombre = string.Empty;
            Marca = string.Empty;
            Fecha = DateTime.Now;
            Vigencia = 0;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Ganancia = string.Empty;

        }

       
    }
}
