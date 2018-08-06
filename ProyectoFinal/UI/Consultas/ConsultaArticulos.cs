
using BLL;
using Entidades;
using ProyectoFinal.UI.Reportes;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaArticulos : Form
    {

        List<Articulos> articulos = new List<Articulos>();
        public ConsultaArticulos()
        {
            InitializeComponent();
        }
        Expression<Func<Articulos, bool>> filtrar = x => true;

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
                    filtrar = t => t.ArticuloID == id&& (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
               
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Nombre == CriteriotextBox.Text && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year); 
                    break;
                //Marca
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Marca == CriteriotextBox.Text && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);
                    break;
                
                //Listar Todo
                case 4:

                    filtrar = t => true;
                    break;
            }

            articulos = ArticulosBLL.GetList(filtrar);

            ConsultadataGridView.DataSource =articulos;
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                ArticuloerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                ArticuloerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            ArticuloerrorProvider.Clear();
        }

        private void ReporteButton_Click(object sender, EventArgs e)
        {
            if (articulos.Count() == 0)
            {
                MessageBox.Show("el grid esta vacio", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                    ReporteArticulos abrir = new ReporteArticulos(articulos);
                           abrir.ShowDialog();
            }
            
         
        }
    }
    
}
