

using Entidades;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes
{
    public partial class ReporteArticulos : Form
    {
        List<Articulos> articulos = null;

        public ReporteArticulos(List<Articulos> articulo)
        {
            InitializeComponent();
           this.articulos = articulo;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteArticulo abrir = new ReporteArticulo();
            abrir.SetDataSource(articulos);
            ReporteArticulocrystalReportViewer.ReportSource = abrir;
            abrir.Refresh();

        }
    }
}
