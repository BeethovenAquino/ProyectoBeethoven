using BLL;
using Entidades;
using ProyectoFinal.UI.Reportes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaEntradaInversion : Form
    {
        List<EntradaInversion> inversions = new List<EntradaInversion>();
        public ConsultaEntradaInversion()
        {
            InitializeComponent();
        }

        Expression<Func<EntradaInversion, bool>> filtrar = x => true;

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
                    filtrar = t=>t.EntradaInversionID == id;
                    break;
                    
               
                //Fecha
                case 1:
                    filtrar = t => t.Fecha.Equals(CriteriotextBox.Text) && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);

                    break;
                //Listar Todo
                case 2:

                    filtrar = t => true;
                    break;
            }

            inversions = EntradaInversionBLL.GetList(filtrar);

            ConsultadataGridView.DataSource = inversions;
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                EntradaerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            return paso;
        }

        private void LimpiarError()
        {
            EntradaerrorProvider.Clear();
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            if (inversions.Count == 0)
            {
                MessageBox.Show("No hay datos");
                return;
            }

            ReporteEntradaInversion reporte = new ReporteEntradaInversion(inversions);
            reporte.ShowDialog();

        }
    }
}

