
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace BLL
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

                    contexto.Facturacion.Find(pagos.FacturaID).Abono += pagos.Abono;

                    //foreach (var item in BLL.FacturacionBLL.GetList(x => x.FacturaID == cobro.ReciboId))
                    //{
                    //    contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono,item.MontoTotal));
                    //}
                    
                    contexto.inversion.Find(pagos.InversionID).Monto += pagos.Abono;

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
                Pagos pagos = contexto.pagos.Find(id);

                if (pagos != null)
                {
                    contexto.Facturacion.Find(pagos.FacturaID).Abono -= pagos.Abono;



                    //foreach (var item in BLL.ReciboBLL.GetList(x => x.ReciboId == cobro.ReciboId))
                    //{
                    //    contexto.recibos.Find(cobro.ReciboId).UltimaFechadeVigencia = item.UltimaFechadeVigencia.AddDays(-AumentoDias(cobro.Abono, item.MontoTotal));
                    //}


                    contexto.inversion.Find(pagos.InversionID).Monto -= pagos.Abono;
                    contexto.Entry(pagos).State = EntityState.Deleted;
                 
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



        public static bool Editar(Pagos pagos)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
             

                Pagos Anterior = BLL.PagosBLL.Buscar(pagos.PagoID);
             

                decimal diferencia;
       

                

                diferencia = Anterior.Abono + pagos.Abono;
                decimal otradif = Anterior.Abono - pagos.Abono;


                Facturacion facturacion = BLL.FacturacionBLL.Buscar(pagos.FacturaID);
              facturacion.Abono = Math.Abs(facturacion.Abono-diferencia);

                Inversion negocio = BLL.InversionBLL.Buscar(pagos.InversionID);
                if (Anterior.Abono < pagos.Abono)
                {
                    
                    negocio.Monto += diferencia;
                }
                else
                {
                    
                    negocio.Monto = negocio.Monto - otradif;
                }


               //recibos.UltimaFechadeVigencia = recibos.UltimaFechadeVigencia.AddDays(-AumentoDias(Anterior.Abono, recibos.MontoTotal));
               // recibos.UltimaFechadeVigencia = recibos.UltimaFechadeVigencia.AddDays(AumentoDias(cobro.Abono, recibos.MontoTotal));

                //BLL.FacturacionBLL.ModEspecial(recibos);
                //BLL.ActivodeNegocioBLL.Editar(negocio);

                contexto.Entry(pagos).State = EntityState.Modified;

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

            Pagos pagos = new Pagos();
            Contexto contexto = new Contexto();

            try
            {

                pagos = contexto.pagos.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return pagos;

        }



        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> expression)
        {
            List<Pagos> pagos = new List<Pagos>();
            Contexto contexto = new Contexto();

            try
            {
                pagos = contexto.pagos.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception) { throw; }
            return pagos;
        }

    }
}
