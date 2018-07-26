using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoFinal.DAL
{
   public class Contexto :DbContext 
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Facturacion> Facturacion { get; set; }
        public DbSet<EntradaArticulos> EntradaArticulos { get; set; }

        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
