﻿using ProyectoFinal.UI.Consultas;
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

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaArticulos consulta = new ConsultaArticulos();
            consulta.Show();
        }

        private void entradaDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEntradaArticulos consultaEntrada = new ConsultaEntradaArticulos();
            consultaEntrada.Show();
        }

    
        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaClientes clientes = new ConsultaClientes();
            clientes.Show();
        }

        private void facturacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFacturacion facturacion = new ConsultaFacturacion();
            facturacion.Show();
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InversionEmpresa inversion = new InversionEmpresa();
            inversion.Show();
        }

        private void entradaDeInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEntradaInversion registro = new RegistroEntradaInversion();
            registro.Show();
        }

        private void cobroAlClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroPagoCliente registroPago = new RegistroPagoCliente();
            registroPago.Show();

        }

        private void entradaDeInversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEntradaInversion inversion = new ConsultaEntradaInversion();
            inversion.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultaPago pago = new ConsultaPago();
            pago.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeUsuarios registro = new RegistroDeUsuarios();
            registro.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios usuarios = new ConsultaUsuarios();
            usuarios.Show();
        }
    }
}
