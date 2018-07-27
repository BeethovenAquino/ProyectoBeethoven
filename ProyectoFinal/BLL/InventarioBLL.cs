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
   public class InventarioBLL
    {
        public static bool Guardar(Inventario inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();


           
            try
            {
                if (contexto.Inventario.Add(inventario) != null)
                {

                    foreach (var item in inventario.Detalle)
                    {
                        contexto.Articulos.Find(item.ArticuloID).PrecioCompra += item.PrecioCompra;
                        contexto.Articulos.Find(item.ArticuloID).PrecioVenta += item.PrecioVenta;
                        contexto.Articulos.Find(item.ArticuloID).Ganancia += item.Ganancia;

                    }
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
                Inventario inventario = contexto.Inventario.Find(id);

                foreach (var item in inventario.Detalle)
                {
                    var articulo = contexto.Articulos.Find(item.ArticuloID);
                    articulo.PrecioCompra += item.PrecioCompra;
                    articulo.PrecioVenta += item.PrecioVenta;
                    articulo.Ganancia += item.Ganancia;

                }

                contexto.Inventario.Remove(inventario);

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

        public static Inventario Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventario inventario = new Inventario();
            try
            {
                inventario = contexto.Inventario.Find(id);
                if (inventario != null)
                {
                    
                    inventario.Detalle.Count();

                    
                    foreach (var item in inventario.Detalle)
                    {
                        //forzando el articulo a cargarse
                        string s = item.Articulos.Nombre;
                    }

                    contexto.Dispose();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return inventario;
        }





        public static List<Inventario> GetList(Expression<Func<Inventario, bool>> expression)
        {
            List<Inventario> inventario = new List<Inventario>();
            Contexto contexto = new Contexto();
            try
            {
                inventario = contexto.Inventario.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }

            return inventario;
        }

        public static bool Modificar(Inventario inventario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                //todo: buscar las entidades que no estan para removerlas
                var inve = InventarioBLL.Buscar(inventario.InventarioID);

                foreach (var item in inve.Detalle)//recorrer el detalle aterior
                {
                    //restar todas las visitas
                    contexto.Articulos.Find(item.ArticuloID).PrecioCompra += item.PrecioCompra;
                    contexto.Articulos.Find(item.ArticuloID).PrecioVenta += item.PrecioVenta;
                    contexto.Articulos.Find(item.ArticuloID).Ganancia  += item.Ganancia;

                    //determinar si el item no esta en el detalle actual
                    if (!inventario.Detalle.ToList().Exists(v => v.InventarioID == item.InventarioID))
                    {
                        //   contexto.Articulos.Find(item.ArticulosID).Inventario -= item.Cantidad;
                        item.Articulos = null; //quitar la ciudad para que EF no intente hacerle nada
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

              
                foreach (var item in inventario.Detalle)
                {
                    //Sumar todas las visitas
                    contexto.Articulos.Find(item.ArticuloID).PrecioCompra += item.PrecioCompra;
                    contexto.Articulos.Find(item.ArticuloID).PrecioVenta += item.PrecioVenta;
                    contexto.Articulos.Find(item.ArticuloID).Ganancia += item.Ganancia;

                    //Muy importante indicar que pasara con la entidad del detalle
                    var estado = item.InventarioID > 0 ? EntityState.Modified : EntityState.Added;
                    contexto.Entry(item).State = estado;
                }

                Inventario EntradaAnterior = BLL.InventarioBLL.Buscar(inventario.InventarioID);
                
               

                //Idicar que se esta modificando el encabezado
                contexto.Entry(inventario).State = EntityState.Modified;

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

        public static decimal CalcularGanancia(int precioCompra, int precioVenta)
        {

            return ((Convert.ToInt32(precioVenta) - Convert.ToInt32(precioCompra)));

        }
    }
}
