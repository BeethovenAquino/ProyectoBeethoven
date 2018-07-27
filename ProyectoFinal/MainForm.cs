using ProyectoFinal.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulos A = new RegistroArticulos();
            A.Show();
        }

        private void entradaArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEntradaArticulos registroEntradaArticulos = new RegistroEntradaArticulos();
            registroEntradaArticulos.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroInventario registroInventario = new RegistroInventario();
            registroInventario.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente registroCliente = new RegistroCliente();
            registroCliente.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroFacturacion registroFacturacion = new RegistroFacturacion();
            registroFacturacion.Show();
        }
    }
}
