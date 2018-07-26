using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string PrecioCompra { get; set; }
        public string PrecioVenta { get; set; }
        public string Ganancia { get; set; }

        public virtual ICollection<Inventario> Detalle { get; set; }

        public Articulos()
        {
            this.Detalle = new List<Inventario>();

            ArticuloID = 0;
            CodigoArticulo= string.Empty;
            Nombre= string.Empty;
            Marca= string.Empty;
            Fecha = DateTime.Now;
            Vigencia = string.Empty;
            PrecioCompra = string.Empty;
            PrecioVenta= string.Empty;
            Ganancia= string.Empty;

        }

        public void AgregarDetalle(int InventarioID, string Articulo, int PrecioCompra, int PrecioVenta, string Ganancia)
        {
            this.Detalle.Add(new Inventario(InventarioID, Articulo, PrecioCompra, PrecioVenta, Ganancia));
        }
    }
}
