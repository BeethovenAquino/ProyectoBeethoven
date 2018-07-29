using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes.Reporte_Entrada_Articulos
{
    public partial class ReporteEntrada : Form
    {
        List<EntradaArticulos> datos = new List<EntradaArticulos>();
        public ReporteEntrada(List<EntradaArticulos> entradas)
        {
            InitializeComponent();
            datos = entradas;
        }

        private void EntradaArticulocrystalReportViewer_Load(object sender, EventArgs e)
        {
            Entrada entrada = new Entrada();
            entrada.SetDataSource(datos);
            EntradaArticulocrystalReportViewer.ReportSource = entrada;
            EntradaArticulocrystalReportViewer.Refresh();

        }
    }
}
