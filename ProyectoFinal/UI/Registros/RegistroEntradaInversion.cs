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
    public partial class RegistroEntradaInversion : Form
    {
        public RegistroEntradaInversion()
        {
            InitializeComponent();
        }

        private bool validar(int error)
        {
            bool errores = false;
            if (error == 1 && EntradaInversionIDnumericUpDown.Value == 0)
            {
                InversionerrorProvider.SetError(EntradaInversionIDnumericUpDown, "Llenar el campo");
                errores = true;
            }
            
            if (error == 2 && MontonumericUpDown.Value==0)
            {
                InversionerrorProvider.SetError(MontonumericUpDown, "Debe Digitar un monto");
                errores = true;
            }
            
            return errores;

        }

        private EntradaInversion Llenaclase()
        {
            EntradaInversion entradaInversion = new EntradaInversion();

            entradaInversion.EntradaInversionID = Convert.ToInt32(EntradaInversionIDnumericUpDown.Value);
            entradaInversion.InversionID = 1;
            entradaInversion.Fecha = FechadateTimePicker.Value;
            entradaInversion.Monto = Convert.ToDecimal(MontonumericUpDown.Value);


            return entradaInversion;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (validar(3))
            {
                MessageBox.Show("Dijite un Monto");
                return;
            }

            if (validar(4))
            {
                MessageBox.Show("Digite un monto", "Validar");
                return;
            }
            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
                return;
            }

            else
            {
                bool paso = false;


                EntradaInversion entrada = Llenaclase();

                if (EntradaInversionIDnumericUpDown.Value == 0)
                {
                    paso = BLL.EntradaInversionBLL.Guardar(entrada);
                }
                else
                {
                    int id = Convert.ToInt32(EntradaInversionIDnumericUpDown.Value);
                    var entry = BLL.EntradaInversionBLL.Buscar(id);

                    if (entry != null)
                    {
                        paso = BLL.EntradaInversionBLL.Editar(entrada);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                EntradaInversionIDnumericUpDown.Value = 0;
                FechadateTimePicker.Value = DateTime.Now;
                MontonumericUpDown.Value = 0;
                InversionerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EntradaInversionIDnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    MontonumericUpDown.Value = 0;
                    InversionerrorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            EntradaInversionIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            MontonumericUpDown.Value = 0;
            InversionerrorProvider.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(EntradaInversionIDnumericUpDown.Value);

                if (BLL.EntradaInversionBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EntradaInversionIDnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    MontonumericUpDown.Value = 0;
                    InversionerrorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InversionerrorProvider.Clear();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar los campos");
            }
            else
            {
                int id = Convert.ToInt32(EntradaInversionIDnumericUpDown.Value);
                EntradaInversion entrada = BLL.EntradaInversionBLL.Buscar(id);

                if (entrada != null)
                {
                    EntradaInversionIDnumericUpDown.Value = entrada.EntradaInversionID;
                    FechadateTimePicker.Value = entrada.Fecha;
                    MontonumericUpDown.Value = entrada.Monto;

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                InversionerrorProvider.Clear();
            }
        }
    }
    
}
