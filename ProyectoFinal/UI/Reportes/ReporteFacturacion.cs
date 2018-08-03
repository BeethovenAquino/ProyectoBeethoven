
using Entidades;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes.Reporte_Facturacion
{
    public partial class ReporteFacturacion : Form
    {
        List<Facturacion> facturacion =null;
        public ReporteFacturacion(List<Facturacion> facturar)
        {
            InitializeComponent();
            this.facturacion = facturar;
        }

        private void FacturacioncrystalReportViewer_Load(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.SetDataSource(facturacion);
            FacturacioncrystalReportViewer.ReportSource = factura;
            FacturacioncrystalReportViewer.Refresh();
        }
    }
}
