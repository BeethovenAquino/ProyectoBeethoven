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
    public partial class ReporteEntradaInversion : Form
    {
        List<EntradaInversion> entradas = null;
        public ReporteEntradaInversion(List<EntradaInversion> inversions)
        {
            InitializeComponent();
            this.entradas = inversions;
        }

        private void EntradaInversioncrystalReportViewer_Load(object sender, EventArgs e)
        {
            EntradaInver abrir = new EntradaInver();
            abrir.SetDataSource(entradas);
            EntradaInversioncrystalReportViewer.ReportSource = abrir;
            abrir.Refresh();
        }
    }
}
