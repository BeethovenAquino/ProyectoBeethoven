using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Reportes.Reporte_Articulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes
{
    public partial class ReporteArticulos : Form
    {
        List<Articulos> articulos = new List<Articulos>();

        public ReporteArticulos(List<Articulos> articulo)
        {
            InitializeComponent();
            articulos = articulo;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReporteArticulo abrir = new ReporteArticulo();
            abrir.SetDataSource(articulos);
            ReporteArticulocrystalReportViewer.ReportSource = abrir;
            ReporteArticulocrystalReportViewer.Refresh();

        }
    }
}
