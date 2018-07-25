using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Facturacion
    {
        [Key]
        public int FacturaID { get; set; }
        public string Venta { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Monto { get; set; }
        public string Devuelta { get; set; }
        public string Subtotal { get; set; }
        public string Total { get; set; }

        public Facturacion()
        {
            FacturaID = 0;
            Venta = string.Empty;
            Cliente= string.Empty;
            Fecha = DateTime.Now;
            Articulo = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Monto = 0;
            Devuelta= string.Empty; 
            Subtotal= string.Empty;
            Total= string.Empty;
        }
    }


}
