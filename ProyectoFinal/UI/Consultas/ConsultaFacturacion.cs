
using BLL;
using Entidades;
using ProyectoFinal.UI.Reportes;
using ProyectoFinal.UI.Reportes.Reporte_Facturacion;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaFacturacion : Form
    {
        
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
                    filtrar = t => t.FacturaID == id && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
               

                //Listar Todo
                case 1:
                    filtrar = t => true;
                    break;
            }

            
            ConsultadataGridView.DataSource = FacturacionBLL.GetList(filtrar);
            ConsultadataGridView.Columns["Detalle"].Visible = false;
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
            Facturacion facturacionn = new Facturacion();
            if (ConsultadataGridView.Rows.Count > 0 && ConsultadataGridView.CurrentRow != null)
            {
                List<Facturacion> Detalle = (List<Facturacion>)ConsultadataGridView.DataSource;
                int id = Detalle.ElementAt(ConsultadataGridView.CurrentRow.Index).FacturaID;

                ReporteFacturacion abrir = new ReporteFacturacion(FacturacionBLL.GetList(x => x.FacturaID == id));
                abrir.Show();
            }
            else
            {
                MessageBox.Show("No existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
