using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class FacturacionDetalle
    {
        [Key]
        public int ID { get; set; }
        public int FacturaID { get; set; }
        public string  Venta { get; set; }
        public int ClienteID { get; set; }
        public string Cliente { get; set;}
        public int ArticuloID { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
        public int Monto { get; set; }
        public string Devuelta { get; set; }

        [ForeignKey("ArticuloID")]
        public virtual Articulos Articulos { get; set; }


        public FacturacionDetalle()
        {
            ID = 0;
            FacturaID = 0;
        }

        public FacturacionDetalle(int id, int facturaID, string venta, int clienteID, string cliente, int articuloID, string articulo, int cantidad, int precio, int importe, int monto, string devuelta)
        {
            ID = id;
            FacturaID = facturaID;
            Venta = venta;
            ClienteID = clienteID;
            Cliente = cliente;
            ArticuloID = articuloID;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
            Monto = monto;
            Devuelta = devuelta;
        }

        public FacturacionDetalle(int facturaID, int articuloID, string articulo, int cantidad, int precio)
        {
            FacturaID = facturaID;
            ArticuloID = articuloID;
            Articulo = articulo;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
