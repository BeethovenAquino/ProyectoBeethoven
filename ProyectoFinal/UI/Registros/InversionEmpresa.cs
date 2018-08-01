using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class InversionEmpresa : Form
    {
        public InversionEmpresa()
        {
            InitializeComponent();
        }

        private void InversionEmpresa_Load(object sender, EventArgs e)
        {
            Inversion inversion = BLL.InversionBLL.Buscar(1);
            Montolabel.Text = 0.ToString();
            Montolabel.Text = $"${inversion.Monto.ToString()}";
            Montolabel.ForeColor = Color.Green;
        }

        private void Refrescarbutton_Click(object sender, EventArgs e)
        {
            Inversion inversion = BLL.InversionBLL.Buscar(1);
            Montolabel.Text = 0.ToString();
            Montolabel.Text = $"${inversion.Monto.ToString()}";
            Montolabel.ForeColor = Color.Green;

        }
    }
}
