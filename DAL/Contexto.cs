
using Entidades;
using System.Data.Entity;


namespace DAL
{
   public class Contexto :DbContext 
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Facturacion> Facturacion { get; set; }
        public DbSet<EntradaArticulos> EntradaArticulos { get; set; }
        public DbSet<EntradaInversion> entradaInversion { get; set; }
        public DbSet<Inversion> inversion { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<Pagos> pagos { get; set; }

        public Contexto() : base("ConStr") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
