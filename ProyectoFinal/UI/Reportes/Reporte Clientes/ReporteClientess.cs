using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Reportes.Reporte_Clientes
{
    public partial class ReporteClientess : Form
    {
        List<Cliente> clientes = null;
        public ReporteClientess(List<Cliente> clientes)
        {
            InitializeComponent();
           this.clientes= clientes;
        }

        private void ClientecrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportesCliente reportes = new ReportesCliente();
            reportes.Load("~/UI/Reportes/Reporte Clientes/ReportesCliente.rpt");
            //reportes.Load("C:/Users/Betoven/Desktop/ProyectoFinal/ProyectoFinal/UI/Reportes/ReporteClientes/ReportesCliente.rpt");
            reportes.SetDataSource(clientes);
            ClientecrystalReportViewer.ReportSource = reportes;
            ClientecrystalReportViewer.Refresh();

        }
    }
}
