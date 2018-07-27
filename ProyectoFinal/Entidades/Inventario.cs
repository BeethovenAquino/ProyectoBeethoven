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
        public int ArticuloID { get; set; }
        public DateTime Fecha { get; set; }
        public string Articulo { get; set; }
        public int PrecioCompra { get; set; }
        public int PrecioVenta { get; set; }
        public string Ganancia { get; set; }


        public virtual ICollection<Inventario> Detalle { get; set; }

        [ForeignKey("ArticuloID")]
        public virtual Articulos Articulos { get; set; }


        public Inventario()
        {
            InventarioID = 0;
            ArticuloID = 0;
            Fecha = DateTime.Now;
            Articulo= string.Empty;
            PrecioCompra = 0;
            PrecioVenta = 0;
            Ganancia = string.Empty;
        }

        public Inventario(int inventarioID, DateTime fecha, string articulo, int precioCompra, int precioVenta, string ganancia)
        {
            InventarioID = inventarioID;
          
            Fecha = fecha;
            Articulo = Articulo;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Ganancia = ganancia;
        }

        public Inventario(int articuloID,string articulo, int precioCompra, int precioVenta, string ganancia)
        {
            ArticuloID = articuloID;
            Articulo = Articulo;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Ganancia = ganancia;
        }

        public void AgregarDetalle(int InventarioID,string Articulo, int PrecioCompra, int PrecioVenta, string Ganancia)
        {
            this.Detalle.Add(new Inventario(InventarioID, Articulo, PrecioCompra, PrecioVenta, Ganancia));
        }
    }
}
