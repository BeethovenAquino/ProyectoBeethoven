using ProyectoFinal.Entidades;
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
    public partial class RegistroArticulos : Form
    {
        public RegistroArticulos()
        {
            InitializeComponent();
        }
        private Articulos LlenarClase()
        {

            Articulos articulos = new Articulos();
            
            articulos.ArticuloID = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            VigenciatextBox.Text = 0.ToString();
            articulos.CodigoArticulo = CodigoArticulotextBox.Text;
            articulos.Nombre = NombretextBox.Text;
            articulos.Marca = MarcatextBox.Text;
            articulos.Fecha = FechaEntradadateTimePicker.Value = DateTime.Now;
            articulos.PrecioCompra = PrecioCompratextBox.Text;
            articulos.PrecioVenta = PrecioVentatextBox.Text;
            articulos.Ganancia = GananciatextBox.Text;
            articulos.Vigencia =Convert.ToInt32(VigenciatextBox.Text);
            return articulos;
        }

        private bool Validar(int validar)
        {

            bool paso = false;
            if (validar == 1 && ArticuloIDnumericUpDown.Value == 0)
            {
                ArticuloerrorProvider.SetError(ArticuloIDnumericUpDown, "Ingrese un ID");
                paso = true;

            }
            if (validar == 2 && CodigoArticulotextBox.Text == string.Empty)
            {
                ArticuloerrorProvider.SetError(CodigoArticulotextBox, "Ingrese el Codigo Del Articulo");
                paso = true;
            }

            if (validar == 2 && NombretextBox.Text == string.Empty)
            {
                ArticuloerrorProvider.SetError(NombretextBox, "Ingrese el Nombre");
                paso = true;
            }

            if (validar == 2 && MarcatextBox.Text == string.Empty)
            {
                ArticuloerrorProvider.SetError(MarcatextBox, "Ingrese la Marca");
                paso = true;
            }


            return paso;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Articulos articulos = LlenarClase();
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            ArticuloerrorProvider.Clear();


            if (ArticuloIDnumericUpDown.Value == 0)
            {
                paso = BLL.ArticulosBLL.Guardar(articulos);
            }
            else
            {
                var A = BLL.ArticulosBLL.Buscar(Convert.ToInt32(ArticuloIDnumericUpDown.Value));

                if (A != null)
                {
                    paso = BLL.ArticulosBLL.Modificar(articulos);
                }

                if (paso)
                {

                    MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ArticuloIDnumericUpDown.Value = 0;
                    CodigoArticulotextBox.Clear();
                    NombretextBox.Clear();
                    MarcatextBox.Clear();
                    FechaEntradadateTimePicker.Value = DateTime.Now;
                    PrecioCompratextBox.Clear();
                    PrecioVentatextBox.Clear();
                    VigenciatextBox.Clear();
                    ArticuloerrorProvider.Clear();

                }
                else
                    MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ArticuloIDnumericUpDown.Value = 0;
            CodigoArticulotextBox.Clear();
            NombretextBox.Clear();
            MarcatextBox.Clear();
            FechaEntradadateTimePicker.Value = DateTime.Now;
            PrecioCompratextBox.Clear();
            PrecioVentatextBox.Clear();
            VigenciatextBox.Clear();
            ArticuloerrorProvider.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ArticuloIDnumericUpDown.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ArticuloIDnumericUpDown.Value = 0;
                CodigoArticulotextBox.Clear();
                NombretextBox.Clear();
                MarcatextBox.Clear();
                FechaEntradadateTimePicker.Value = DateTime.Now;
                PrecioCompratextBox.Clear();
                PrecioVentatextBox.Clear();
                VigenciatextBox.Clear();
                ArticuloerrorProvider.Clear();
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

            int id = Convert.ToInt32(ArticuloIDnumericUpDown.Value);
            Articulos articulos = BLL.ArticulosBLL.Buscar(id);

            if (articulos != null)
            {
                CodigoArticulotextBox.Text = articulos.CodigoArticulo;
                NombretextBox.Text = articulos.Nombre;
                MarcatextBox.Text = articulos.Marca;
                FechaEntradadateTimePicker.Value = articulos.Fecha;
                PrecioCompratextBox.Text = articulos.PrecioCompra;
                PrecioVentatextBox.Text = articulos.PrecioVenta;
                VigenciatextBox.Text = articulos.Vigencia.ToString();

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
