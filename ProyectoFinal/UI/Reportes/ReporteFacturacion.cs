using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes.Reporte_Facturacion
{
    public partial class ReporteFacturacion : Form
    {
        List<Facturacion> facturacion =null;
        public ReporteFacturacion(List<Facturacion> factura)
        {
            InitializeComponent();
            this.facturacion = factura;
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
