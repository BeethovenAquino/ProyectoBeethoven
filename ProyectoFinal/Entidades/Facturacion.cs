using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProyectoFinal.Entidades
{
    public class Facturacion
    {
        [Key]
        public int FacturaID { get; set; }
        public int ClienteID { get; set; }
        public DateTime Fecha { get; set; }
        public string Subtotal { get; set; }
        public int Total { get; set; }

        public virtual ICollection<FacturacionDetalle> Detalle { get; set; }
        
        public Facturacion()
        {
            this.Detalle = new List<FacturacionDetalle>();
            FacturaID = 0;
            Fecha = DateTime.Now;
            Subtotal= string.Empty;
            Total= 0;
        }

        public void AgregarDetalle(int id, int FacturaID, string Venta, int ClienteID, string Cliente, int ArticuloID,string Articulo,int cantidad, int precio,int importe, int monto,string devuelta)
        {
            this.Detalle.Add(new FacturacionDetalle(id,FacturaID,Venta,ClienteID,Cliente,ArticuloID,Articulo,cantidad,precio,importe,monto,devuelta));
        }
    }


}
