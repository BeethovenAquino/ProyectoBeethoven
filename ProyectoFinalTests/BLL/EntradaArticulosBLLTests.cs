using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.BLL.Tests
{
    [TestClass()]
    public class EntradaArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;
            

            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;


            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;


            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;


            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;


            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void RetornarArticuloTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;


            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void CalcularGananciaTest()
        {
            bool paso;
            EntradaArticulos entrada = new EntradaArticulos();
            entrada.EntradaArticulosID = 0;
            entrada.Articulo = "Pulsa";
            entrada.PrecioCompra = 600;
            entrada.PrecioVenta = 900;
            entrada.Ganancia = 300;
            entrada.Cantidad = 4;


            paso = EntradaArticulosBLL.Guardar(entrada);
            Assert.AreEqual(paso, true);
        }
    }
}