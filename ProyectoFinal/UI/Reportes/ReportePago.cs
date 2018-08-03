using Entidades;
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
    public partial class ReportePago : Form
    {
        List<Pagos> pagos = null;
        public ReportePago(List<Pagos> pago)
        {
            InitializeComponent();
            this.pagos = pago;
        }

        private void PagocrystalReportViewer_Load(object sender, EventArgs e)
        {
            PagoCliente abrir = new PagoCliente();
            abrir.SetDataSource(pagos);
            PagocrystalReportViewer.ReportSource = abrir;
            abrir.Refresh();


        }
    }
}
