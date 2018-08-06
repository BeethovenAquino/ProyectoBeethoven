
using BLL;
using DAL;
using Entidades;
using System;

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

            ArticulocomboBox.DataSource = repositori.GetList(c =>true /* c.PrecioCompra == 0*/);
            ArticulocomboBox.ValueMember = "ArticuloID";
            ArticulocomboBox.DisplayMember = "Nombre";
        }
        private EntradaArticulos LlenarClase()
        {

            EntradaArticulos articulo = new EntradaArticulos();

            articulo.EntradaArticulosID = Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value);
            articulo.Articulo = ArticulocomboBox.Text;
            articulo.Cantidad = Convert.ToInt32(CantidadArticulonumericUpDown.Value);
            articulo.ArticuloID = Convert.ToInt32(ArticulocomboBox.SelectedValue);
            articulo.PrecioCompra = Convert.ToInt32(PrecioCompranumericUpDown.Value);
            articulo.PrecioVenta = Convert.ToInt32(PrecioVentanumericUpDown.Value);
            articulo.Ganancia = Convert.ToInt32(GanancianumericUpDown.Value);

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

                EntradaerrorProvider.SetError(CantidadArticulonumericUpDown, "Ingrese una Cantidad");
                paso = true;
            }

            if (validar == 2 && PrecioCompranumericUpDown.Value == 0)
            {

                EntradaerrorProvider.SetError(PrecioCompranumericUpDown, "Ingrese un Precio de compra");
                paso = true;
            }

            if (validar == 2 && PrecioVentanumericUpDown.Value == 0)
            {

                EntradaerrorProvider.SetError(PrecioVentanumericUpDown, "Ingrese un Precio de Venta");
                paso = true;
            }



            return paso;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            EntradaArticuloIDnumericUpDown.Value = 0;
            CantidadArticulonumericUpDown.Value = 0;
            ArticulocomboBox.Text.ToString();
            PrecioCompranumericUpDown.Value = 0;
            PrecioVentanumericUpDown.Value = 0;
            GanancianumericUpDown.Value=0;
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
                paso = EntradaArticulosBLL.Guardar(entradaArticulos);
            }
            else
            {
                var E = EntradaArticulosBLL.Buscar(Convert.ToInt32(EntradaArticuloIDnumericUpDown.Value));

                if (E != null)
                {
                    paso = EntradaArticulosBLL.Modificar(entradaArticulos);
                }
            }

                if (paso)
                {

                     MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                    EntradaArticuloIDnumericUpDown.Value = 0;
                    CantidadArticulonumericUpDown.Value = 0;
                    ArticulocomboBox.Text.ToString();
                    PrecioCompranumericUpDown.Value = 0;
                    PrecioVentanumericUpDown.Value = 0;
                    GanancianumericUpDown.Value = 0;
                    EntradaerrorProvider.Clear();
                }
            else { MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            LlenarComboBox();
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
                PrecioCompranumericUpDown.Value = 0;
                PrecioVentanumericUpDown.Value = 0;
                GanancianumericUpDown.Value = 0;
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
                PrecioCompranumericUpDown.Value = articulo.PrecioCompra;
                PrecioVentanumericUpDown.Value = articulo.PrecioVenta;
                GanancianumericUpDown.Value = articulo.Ganancia;
                CantidadArticulonumericUpDown.Value = articulo.Cantidad;

            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PrecioCompranumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int precioVenta = Convert.ToInt32(PrecioVentanumericUpDown.Value);
            int precioCompra = Convert.ToInt32(PrecioCompranumericUpDown.Value);

            if (PrecioCompranumericUpDown.Value != 0 && PrecioVentanumericUpDown.Value != 0)
            {
                GanancianumericUpDown.Value = BLL.EntradaArticulosBLL.CalcularGanancia(precioVenta, precioCompra);

            }
        }

        private void PrecioVentanumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int precioVenta = Convert.ToInt32(PrecioVentanumericUpDown.Value);
            int precioCompra = Convert.ToInt32(PrecioCompranumericUpDown.Value);

            if (precioVenta < precioCompra)
            {
                MessageBox.Show("Va a Perder dinero", "Perdida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                if (PrecioCompranumericUpDown.Value != 0 && PrecioVentanumericUpDown.Value != 0)
                {
                    GanancianumericUpDown.Value = BLL.EntradaArticulosBLL.CalcularGanancia(precioVenta, precioCompra);

                }
               
            }
            
        }
        }
    }

