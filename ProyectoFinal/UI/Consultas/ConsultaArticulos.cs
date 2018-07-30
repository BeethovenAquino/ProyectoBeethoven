using ProyectoFinal.Entidades;
using ProyectoFinal.UI.Reportes;
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
    public partial class ConsultaArticulos : Form
    {
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
                    filtrar = t => t.ArticuloID == id;
                    break;
                //Codigo Articulo
                case 1:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;
                    }
                    filtrar = t => t.CodigoArticulo.Contains(CriteriotextBox.Text);
                    break;

                //Nombre
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Nombre == CriteriotextBox.Text;
                    break;
                //Marca
                case 3:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;

                    }
                    filtrar = t => t.Marca == CriteriotextBox.Text;
                    break;
                //Fecha
                case 4:
                    filtrar = t => t.Fecha.Equals(CriteriotextBox.Text) && (t.Fecha.Day >= DesdedateTimePicker.Value.Day) && (t.Fecha.Month >= DesdedateTimePicker.Value.Month) && (t.Fecha.Year >= DesdedateTimePicker.Value.Year)
                    && (t.Fecha.Day <= HastadateTimePicker.Value.Day) && (t.Fecha.Month <= HastadateTimePicker.Value.Month) && (t.Fecha.Year <= HastadateTimePicker.Value.Year);

                    break;
                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }


            ConsultadataGridView.DataSource = BLL.ArticulosBLL.GetList(filtrar);
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
            
            ReporteArticulos abrir = new ReporteArticulos(BLL.ArticulosBLL.GetList(filtrar));
            abrir.Show();
        }
    }
    
}
