using ProyectoFinal.DAL;
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
    public partial class RegistroEntradaArticulos : Form
    {
        public RegistroEntradaArticulos()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {

            Repositorio<Articulos> repositori = new Repositorio<Articulos>(new Contexto());

            ArticulocomboBox.DataSource = repositori.GetList(c => true);
            ArticulocomboBox.ValueMember = "ArticuloId";
            ArticulocomboBox.DisplayMember = "CodigoArticulo";
        }
        private EntradaArticulos LlenarClase()
        {

            EntradaArticulos articulo = new EntradaArticulos();

            articulo.EntradaArticulosID = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);
            articulo.Articulo = ArticulocomboBox.Text;
            articulo.Cantidad = Convert.ToInt32(CantidadArticulonumericUpDown.Value);
            articulo.ArticuloID = Convert.ToInt32(ArticulocomboBox.SelectedValue);

            return articulo;
        }
        private bool Validar(int validar)
        {

            bool paso = false;
            if (validar == 1 && EntradaArticuloIDnumericUpDown.Value == 0)
            {
                EntradaerrorProvider.SetError(EntradaArticuloIDnumericUpDown, "Ingrese un ID");
                paso = true;

            }
            if (validar == 2 && ArticulocomboBox.Text == string.Empty)
            {
                EntradaerrorProvider.SetError(ArticulocomboBox, "Ingrese un Articulo");
                paso = true;
            }

            if (validar == 2 && CantidadArticulonumericUpDown.Value == 0)
            {

                EntradaerrorProvider.SetError(CantidadArticulonumericUpDown, "Ingrese un Costo");
                paso = true;
            }


            return paso;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            EntradaArticuloIDnumericUpDown.Value = 0;
            CantidadArticulonumericUpDown.Value = 0;
            ArticulocomboBox.Text.ToString();
            EntradaerrorProvider.Clear();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            EntradaArticulos entradaArticulos = LlenarClase();
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }

            EntradaerrorProvider.Clear();


            if (EntradaArticuloIDnumericUpDown.Value == 0)
            {
                paso = BLL.EntradaArticulosBLL.Guardar(entradaArticulos);
            }
            else
            {
                var E = BLL.EntradaArticulosBLL.Buscar(Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value));

                if (E != null)
                {
                    paso = BLL.EntradaArticulosBLL.Modificar(entradaArticulos);
                }

                if (paso)
                {

                    MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EntradaArticuloIDnumericUpDown.Value = 0;
                    CantidadArticulonumericUpDown.Value = 0;
                    ArticulocomboBox.Text.ToString();
                    EntradaerrorProvider.Clear();
                }
                else
                    MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);

            if (BLL.EntradaArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EntradaArticuloIDnumericUpDown.Value = 0;
                CantidadArticulonumericUpDown.Value = 0;
                ArticulocomboBox.Text.ToString();
                EntradaerrorProvider.Clear();

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

            int id = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);
            EntradaArticulos articulo = BLL.EntradaArticulosBLL.Buscar(id);

            if (articulo != null)
            {

                
                ArticulocomboBox.Text = articulo.Articulo;
                CantidadArticulonumericUpDown.Value = articulo.Cantidad;

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
