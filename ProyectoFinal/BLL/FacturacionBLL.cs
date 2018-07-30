using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ProyectoFinal.BLL
{
    public class FacturacionBLL
    {
        public static bool Guardar(Facturacion facturacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            
            try
            {
                if (contexto.Facturacion.Add(facturacion) != null)
                {

                    foreach (var item in facturacion.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticuloID).Vigencia -= item.Cantidad;
                    }

                    //contexto.Cliente.Find(facturacion.ClienteID).Total += facturacion.Total;

                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Facturacion facturacion = contexto.Facturacion.Find(id);

                foreach (var item in facturacion.Detalle)
                {
                    var articulo = contexto.Articulos.Find(item.ArticuloID);
                    articulo.Vigencia += item.Cantidad;
                }

                contexto.Facturacion.Remove(facturacion);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }

        public static Facturacion Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Facturacion facturacion = new Facturacion();
            try
            {
                facturacion = contexto.Facturacion.Find(id);
                if (facturacion != null)
                {
                    //Cargar la lista en este punto porque
                    //luego de hacer Dispose() el Contexto 
                    //no sera posible leer la lista
                    facturacion.Detalle.Count();

                    ////Cargar los nombres de las ciudades
                    //foreach (var item in facturacion.Detalle)
                    //{
                    //    //forzando la ciudad a cargarse
                    //    string s = item..Descripcion;
                    //}

                    contexto.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return facturacion;
        }





        public static List<Facturacion> GetList(Expression<Func<Facturacion, bool>> expression)
        {
            List<Facturacion> facturacion = new List<Facturacion>();
            Contexto contexto = new Contexto();
            try
            {
                facturacion = contexto.Facturacion.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return facturacion;
        }

        public static bool Modificar(Facturacion facturacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                //todo: buscar las entidades que no estan para removerlas
                var visitaant = FacturacionBLL.Buscar(facturacion.FacturaID);

                foreach (var item in visitaant.Detalle)//recorrer el detalle aterior
                {
                    //restar todas las visitas
                    contexto.Articulos.Find(item.ArticuloID).Vigencia += item.Cantidad;

                    //determinar si el item no esta en el detalle actual
                    if (!facturacion.Detalle.ToList().Exists(v => v.ID == item.ID))
                    {
                        //   contexto.Articulos.Find(item.ArticulosID).Inventario -= item.Cantidad;
                        item.Articulo = null; //quitar la ciudad para que EF no intente hacerle nada
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                //recorrer el detalle
                foreach (var item in facturacion.Detalle)
                {
                    //Sumar todas las visitas
                    contexto.Articulos.Find(item.ArticuloID).Vigencia -= item.Cantidad;

                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.ID > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                Facturacion EntradaAnterior = BLL.FacturacionBLL.Buscar(facturacion.FacturaID);


                ////identificar la diferencia ya sea restada o sumada
                //decimal diferencia;

                //diferencia = mantenimiento.Total - EntradaAnterior.Total;

                ////aplicar diferencia al inventario
                //Vehiculos vehiculos = BLL.VehiculosBLL.Buscar(mantenimiento.VehiculoID);
                //vehiculos.TotalMantenimiento += diferencia;
                //BLL.VehiculosBLL.Modificar(vehiculos);


                //Idicar que se esta modificando el encabezado
                contexto.Entry(facturacion).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static decimal CalcularImporte(int precio, int cantidad)
        {
            return Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
        }

        public static decimal CalcularDevuelta(int Monto, int Precio)
        {
            return Convert.ToInt32(Monto) - Convert.ToInt32(Precio);
        }


    }
}
