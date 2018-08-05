using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Entidades
{
    public class Facturacion
    {
        [Key]
        public int FacturaID { get; set; }        
        public int InventarioID { get; set; }
        public int InversionID { get; set; }
        public int ClienteID { get; set; }
        public DateTime Fecha { get; set; }
        public int Subtotal { get; set; }
        public int Total { get; set; }
        public decimal Abono { get; set; }
        public int Monto { get; set; }
        public int Devuelta { get; set; }

        public virtual ICollection<FacturacionDetalle> Detalle { get; set; }
        
        public Facturacion()
        {
            this.Detalle = new List<FacturacionDetalle>();
            InversionID = 0;
            FacturaID = 0;
            InventarioID = 0;
            ClienteID = 0;
            Fecha = DateTime.Now;
            Subtotal= 0;
            Total= 0;
            Abono = 0;
            Monto = 0;
            Devuelta = 0;
        }

        public void AgregarDetalle(int id, int FacturaID, int ClienteID, int ArticuloID, string Venta, string Cliente,string Articulo,int cantidad, int precio,int importe)
        {
            this.Detalle.Add(new FacturacionDetalle(id,FacturaID,ClienteID,ArticuloID,Venta,Cliente, Articulo, cantidad,precio,importe));
        }
    }


}
