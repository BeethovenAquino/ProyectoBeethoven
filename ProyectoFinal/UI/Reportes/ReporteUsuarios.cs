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
    public partial class ReporteUsuarios : Form
    {
        List<Usuarios> usuarios = null;
        public ReporteUsuarios(List<Usuarios> usuario)
        {
            InitializeComponent();
            this.usuarios = usuario;
        }

        private void UsuariocrystalReportViewer_Load(object sender, EventArgs e)
        {
            Usuarioss abrir = new Usuarioss();
            abrir.SetDataSource(usuarios);
            UsuariocrystalReportViewer.ReportSource = abrir;
            abrir.Refresh();

        }
    }
}
