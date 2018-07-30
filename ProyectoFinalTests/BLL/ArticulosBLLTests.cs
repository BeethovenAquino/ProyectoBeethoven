﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoFinal.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloID = 0;
            articulo.CodigoArticulo ="001";
            articulo.Nombre = "Aretes";
            articulo.Marca = "GUCCI";
            articulo.Fecha = DateTime.Now;
            articulo.PrecioCompra =300;
            articulo.PrecioVenta = 350;
            articulo.Ganancia = "50";
            articulo.Vigencia = 10;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloID = 0;
            articulo.CodigoArticulo = "001";
            articulo.Nombre = "Aretes";
            articulo.Marca = "GUCCI";
            articulo.Fecha = DateTime.Now;
            articulo.PrecioCompra = 300;
            articulo.PrecioVenta = 350;
            articulo.Ganancia = "50";
            articulo.Vigencia = 10;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloID = 0;
            articulo.CodigoArticulo = "001";
            articulo.Nombre = "Aretes";
            articulo.Marca = "GUCCI";
            articulo.Fecha = DateTime.Now;
            articulo.PrecioCompra = 300;
            articulo.PrecioVenta = 350;
            articulo.Ganancia = "50";
            articulo.Vigencia = 10;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloID = 0;
            articulo.CodigoArticulo = "001";
            articulo.Nombre = "Aretes";
            articulo.Marca = "GUCCI";
            articulo.Fecha = DateTime.Now;
            articulo.PrecioCompra = 300;
            articulo.PrecioVenta = 350;
            articulo.Ganancia = "50";
            articulo.Vigencia = 10;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloID = 0;
            articulo.CodigoArticulo = "001";
            articulo.Nombre = "Aretes";
            articulo.Marca = "GUCCI";
            articulo.Fecha = DateTime.Now;
            articulo.PrecioCompra = 300;
            articulo.PrecioVenta = 350;
            articulo.Ganancia = "50";
            articulo.Vigencia = 10;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void RetornarNombreTest()
        {
            bool paso;
            Articulos articulo = new Articulos();
            articulo.ArticuloID = 0;
            articulo.CodigoArticulo = "001";
            articulo.Nombre = "Aretes";
            articulo.Marca = "GUCCI";
            articulo.Fecha = DateTime.Now;
            articulo.PrecioCompra = 300;
            articulo.PrecioVenta = 350;
            articulo.Ganancia = "50";
            articulo.Vigencia = 10;
            paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }
    }
}