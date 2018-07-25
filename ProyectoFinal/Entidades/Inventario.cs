using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Inventario
    {
        [Key]
        public int InventarioID { get; set; }
        public DateTime Fecha { get; set; }
        public string Articulo { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
        public string Ganancia { get; set; }


        [ForeignKey("ArticulosID")]
        public virtual Articulos Articulos { get; set; }


        public Inventario()
        {
            InventarioID = 0;
            Fecha = DateTime.Now;
            Articulo= string.Empty;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Ganancia = string.Empty;
        }
    }
}
