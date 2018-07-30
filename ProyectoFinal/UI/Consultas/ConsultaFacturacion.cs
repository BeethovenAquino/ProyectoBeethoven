using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Reportes.Reporte_Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaFacturacion : Form
    {
        List<Facturacion> facturacion = new List<Facturacion>();
        public ConsultaFacturacion()
        {
            InitializeComponent();
        }

        Expression<Func<Facturacion, bool>> filtrar = x => true;

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
                    filtrar = t => t.FacturaID == id;
                    break;
                //Fecha
                case 1:
                    LimpiarError();

                    filtrar = t => t.Fecha.Equals(CriteriotextBox.Text) && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
               

                //Listar Todo
                case 2:
                    filtrar = t => true;
                    break;
            }

            facturacion = BLL.FacturacionBLL.GetList(filtrar);
            ConsultadataGridView.DataSource = facturacion;
        }


        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                FacturacionerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                FacturacionerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            FacturacionerrorProvider.Clear();
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            if (facturacion.Count() == 0)
            {
                MessageBox.Show("No existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ReporteFacturacion abrir = new ReporteFacturacion(facturacion);
            abrir.ShowDialog();

        }
    }
}
