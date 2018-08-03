using BLL;
using Entidades;

using System;

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
            decimal num = 0;
            if (error == 1 && EntradaInversionIDnumericUpDown.Value == 0)
            {
                InversionerrorProvider.SetError(EntradaInversionIDnumericUpDown, "Llenar el campo");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(MontotextBox.Text))
            {
                InversionerrorProvider.SetError(MontotextBox, "Digite el monto");
                errores = true;
            }




            if (error == 3 && decimal.TryParse(MontotextBox.Text, out num) == false)
            {
                InversionerrorProvider.SetError(MontotextBox, "Debe Digitar un monto");
                errores = true;
            }

            if (error == 4 && Convert.ToDecimal(MontotextBox.Text) == 0)
            {
                InversionerrorProvider.SetError(MontotextBox, "Debe Digitar un monto");
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
            entradaInversion.Monto = Convert.ToDecimal(MontotextBox.Text);
            
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
                    paso = EntradaInversionBLL.Guardar(entrada);
                }
                else
                {
                    int id = Convert.ToInt32(EntradaInversionIDnumericUpDown.Value);
                    var entry = EntradaInversionBLL.Buscar(id);

                    if (entry != null)
                    {
                        paso = EntradaInversionBLL.Editar(entrada);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                EntradaInversionIDnumericUpDown.Value = 0;
                FechadateTimePicker.Value = DateTime.Now;
                MontotextBox.Clear();
                InversionerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EntradaInversionIDnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    MontotextBox.Clear();
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
            MontotextBox.Clear();
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
                    MontotextBox.Clear();
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
                    MontotextBox.Text = entrada.Monto.ToString();

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
