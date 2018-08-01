using ProyectoFinal.DAL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.BLL
{
   public class PagosBLL
    {
        
        public static bool Guardar(Pagos pagos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
   ;
                if (contexto.pagos.Add(pagos) != null)
                {

                    contexto.Facturacion.Find(pagos.FacturaID).Abono += cobro.Abono;

                    foreach (var item in BLL.ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    {
                        contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono,item.MontoTotal));
                    }
                    
                    contexto.activodenegocio.Find(cobro.ActivodeNegocioId).Activo += cobro.Abono;

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
                Pagos cobro = contexto.cobro.Find(id);

                if (cobro != null)
                {
                    contexto.recibos.Find(cobro.ReciboId).Abono -= cobro.Abono;



                    foreach (var item in BLL.ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    {
                        contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(-AumentoDias(cobro.Abono, item.MontoTotal));
                    }


                    contexto.activodenegocio.Find(cobro.ActivodeNegocioId).Activo -= cobro.Abono;
                    contexto.Entry(cobro).State = EntityState.Deleted;
                 
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }


            }
            catch (Exception) { throw; }

            return paso;
        }



        public static bool Editar(Pagos cobro)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
             

                Pagos Anterior = BLL.CobroBLL.Buscar(cobro.PagosId);
             

                decimal diferencia;
       

                

                diferencia = Anterior.Abono + cobro.Abono;
                decimal otradif = Anterior.Abono - cobro.Abono;


                Recibos recibos = BLL.ReciboBLL.Buscar(cobro.ReciboId);
              recibos.Abono = Math.Abs(recibos.Abono-diferencia);

                ActivodeNegocio negocio = BLL.ActivodeNegocioBLL.Buscar(cobro.ActivodeNegocioId);
                if (Anterior.Abono < cobro.Abono)
                {
                    
                    negocio.Activo += diferencia;
                }
                else
                {
                    
                    negocio.Activo = negocio.Activo - otradif;
                }


               recibos.UltimaFechadeVigencia = recibos.UltimaFechadeVigencia.AddDays(-AumentoDias(Anterior.Abono, recibos.MontoTotal));
                recibos.UltimaFechadeVigencia = recibos.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono, recibos.MontoTotal));

                BLL.ReciboBLL.ModEspecial(recibos);
                BLL.ActivodeNegocioBLL.Editar(negocio);

                contexto.Entry(cobro).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }



        public static Pagos Buscar(int id)
        {

            Pagos cobro = new Pagos();
            Contexto contexto = new Contexto();

            try
            {
               
                cobro = contexto.cobro.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return cobro;

        }



        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> cobro = new List<Pagos>();
            Contexto contexto = new Contexto();

            try
            {
                cobro = contexto.cobro.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return cobro;
        }

    }
}
