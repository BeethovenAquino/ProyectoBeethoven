﻿using ProyectoFinal.Entidades;
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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }


        private Cliente LlenarClase()
        {

            Cliente cliente = new Cliente();
            TotalTextbox.Text = 0.ToString();
            cliente.ClienteID = Convert.ToInt32(ClienteIDnumericUpDown.Value);
            cliente.NombreCliente = NombretextBox.Text;
            cliente.Cedula = (CedulatextBox.Text);
            cliente.Direccion = (DirecciontextBox.Text);
            cliente.Telefono = (TelefonotextBox.Text);
            cliente.Total = Convert.ToInt32(TotalTextbox.Text);
            cliente.Pago = Convert.ToInt32(PagonumericUpDown.Value);

            return cliente;
        }

        private bool Validar(int validar)
        {

            bool paso = false;
            if (validar == 1 && ClienteIDnumericUpDown.Value == 0)
            {
                ClienteerrorProvider.SetError(ClienteIDnumericUpDown, "Ingrese un ID");
                paso = true;

            }
            if (validar == 2 && NombretextBox.Text == string.Empty)
            {
                ClienteerrorProvider.SetError(NombretextBox, "Ingrese el Nombre");
                paso = true;
            }

            if (validar == 2 && CedulatextBox.Text == string.Empty)
            {
                ClienteerrorProvider.SetError(CedulatextBox, "Ingrese la Cedula");
                paso = true;
            }

            if (validar == 2 && DirecciontextBox.Text == string.Empty)
            {
                ClienteerrorProvider.SetError(DirecciontextBox, "Ingrese la Direccion");
                paso = true;
            }

            if (validar == 2 && TelefonotextBox.Text == string.Empty)
            {
                ClienteerrorProvider.SetError(TelefonotextBox, "Ingrese el Telefono");
                paso = true;
            }




            return paso;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Cliente cliente= LlenarClase();
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }
            else
            {
                ClienteerrorProvider.Clear();


                if (ClienteIDnumericUpDown.Value == 0)
                {
                    paso = BLL.ClienteBLL.Guardar(cliente);
                }
                else
                {
                    var A = BLL.ClienteBLL.Buscar(Convert.ToInt32(ClienteIDnumericUpDown.Value));

                    if (A != null)
                    {
                        paso = BLL.ClienteBLL.Modificar(cliente);
                    }
                }

                    if (paso)
                    {
                    

                        MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClienteIDnumericUpDown.Value = 0;
                    NombretextBox.Clear();
                    CedulatextBox.Clear();
                    DirecciontextBox.Clear();
                    TelefonotextBox.Clear();
                    TotalTextbox.Clear();
                    PagonumericUpDown.Value = 0;
                    ClienteerrorProvider.Clear(); ;

                    }
                    else{ MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        
                }
           
            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ClienteIDnumericUpDown.Value = 0;
            NombretextBox.Clear();
            CedulatextBox.Clear();
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            TotalTextbox.Clear();
            PagonumericUpDown.Value = 0;
            ClienteerrorProvider.Clear();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ClienteIDnumericUpDown.Value);

            if (BLL.ClienteBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClienteIDnumericUpDown.Value = 0;
                NombretextBox.Clear();
                CedulatextBox.Clear();
                DirecciontextBox.Clear();
                TelefonotextBox.Clear();
                TotalTextbox.Clear();
                PagonumericUpDown.Value = 0;
                ClienteerrorProvider.Clear();
            }

            else
                MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ClienteIDnumericUpDown.Value);
            Cliente cliente = BLL.ClienteBLL.Buscar(id);

            if (cliente != null)
            {

                NombretextBox.Text = cliente.NombreCliente;
                CedulatextBox.Text = cliente.Cedula;
                DirecciontextBox.Text = cliente.Direccion;
                TelefonotextBox.Text = cliente.Telefono;
                TotalTextbox.Text = cliente.Total.ToString();
                PagonumericUpDown.Value = cliente.Pago;

                
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
