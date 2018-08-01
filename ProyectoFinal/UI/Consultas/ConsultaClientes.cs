
using BLL;
using Entidades;
using ProyectoFinal.UI.Reportes.Reporte_Clientes;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaClientes : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public ConsultaClientes()
        {
            InitializeComponent();
        }
        Expression<Func<Cliente, bool>> filtrar = x => true;

        private void Consultabutton_Click(object sender, EventArgs e)
        {
           int id;




            switch (TipocomboBox.SelectedIndex)
            {
                //ID
                case 0:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    id = int.Parse(CriteriotextBox.Text);
                    filtrar = t => t.ClienteID == id;
                    break;
                //Nombre
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.NombreCliente.Contains(CriteriotextBox.Text);
                    break;

                //Direccion
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Direccion == CriteriotextBox.Text;
                    break;
                //Cedula
                case 3:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    filtrar = t => t.Cedula == CriteriotextBox.Text;
                    break;
                //Telefono
                case 4:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    filtrar = t => t.Telefono == CriteriotextBox.Text;
                    break;
                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }

            clientes= ClienteBLL.GetList(filtrar);

            ConsultadataGridView.DataSource = clientes;
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            ClienteerrorProvider.Clear();
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }

            ReporteClientess reporte = new ReporteClientess(clientes);
            reporte.ShowDialog();
        }
    }
 }

