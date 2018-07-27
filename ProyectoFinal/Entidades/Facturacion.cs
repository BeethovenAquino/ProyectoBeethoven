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
        public string Venta { get; set; }
        public DateTime Fecha { get; set; }
        public string Subtotal { get; set; }
        public string Total { get; set; }

        public virtual ICollection<FacturacionDetalle> Detalle { get; set; }

        

        public Facturacion()
        {
            FacturaID = 0;
            Venta = string.Empty;
           
            Fecha = DateTime.Now;
            
            Subtotal= string.Empty;
            Total= string.Empty;
        }

        public void AgregarDetalle(int ID, int FacturaID,  int ClienteID, string Cliente, int ArticuloID,string Articulo,int cantidad, int precio,int importe, int monto,string devuelta)
        {
            this.Detalle.Add(new FacturacionDetalle(ID,FacturaID,ClienteID,Cliente,ArticuloID,Articulo,cantidad,precio,importe,monto,devuelta));
        }
    }


}
