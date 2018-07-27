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
    public partial class RegistroInventario : Form
    {
        public RegistroInventario()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarCampos(Inventario inventario)
        {
            Articulos articulos = new Articulos();
            InventarioIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            PrecioCompranumericUpDown.Value = 0;
            PrecioVentanumericUpDown.Value = 0;
            GananciatextBox.Clear();
            InventarioerrorProvider.Clear();
            InventariodataGridView.DataSource = null;


            InventarioIDnumericUpDown.Value = inventario.InventarioID;
            FechadateTimePicker.Value = inventario.Fecha;
            PrecioCompranumericUpDown.Value = inventario.PrecioCompra;
            PrecioVentanumericUpDown.Value = inventario.PrecioVenta;
            GananciatextBox.Text = inventario.Ganancia;






            //Cargar el detalle al Grid
            InventariodataGridView.DataSource = inventario.Detalle;
            InventariodataGridView.Columns["ID"].Visible = false;
            InventariodataGridView.Columns["InventarioID"].Visible = false;
            InventariodataGridView.Columns["ArticulosID"].Visible = false;
            InventariodataGridView.Columns["Articulos"].Visible = false;
        }

        private void LlenarComboBox()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>(new Contexto());

            ArticulocomboBox.DataSource = repositorio.GetList(c => true);
            ArticulocomboBox.ValueMember = "ArticuloID";
            ArticulocomboBox.DisplayMember = "CodigoArticulo";

        }

        private bool Validar()
        {
            bool paso = false;

            if (PrecioCompranumericUpDown.Value == 0)
            {
                InventarioerrorProvider.SetError(PrecioCompranumericUpDown,
                   "No debes dejar el Precio de Compra vacio");
                paso = true;
            }

            if (InventariodataGridView.RowCount == 0)
            {
                InventarioerrorProvider.SetError(InventariodataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            return paso;
        }

        private bool ValidarE()
        {
            bool paso = false;



            if (InventarioIDnumericUpDown.Value == 0)
            {
                InventarioerrorProvider.SetError(InventarioIDnumericUpDown,
                   "Llene el campo");
                paso = true;
            }


            return paso;


        }

        private Inventario LlenaClase()
        {
            Inventario inventario = new Inventario();

            inventario.InventarioID = Convert.ToInt32(InventarioIDnumericUpDown.Value);

            inventario.Fecha = FechadateTimePicker.Value;
            inventario.Articulo = Convert.ToString(ArticulocomboBox.SelectedIndex);
            inventario.PrecioCompra = Convert.ToInt32(PrecioCompranumericUpDown.Value);
            inventario.PrecioVenta = Convert.ToInt32(PrecioVentanumericUpDown.Value);
            inventario.Ganancia = GananciatextBox.Text;



            foreach (DataGridViewRow item in InventariodataGridView.Rows)
            {

                inventario.AgregarDetalle
                     (Convert.ToInt32(item.Cells["InventarioID"].Value),
                     Convert.ToString(item.Cells["Articulo"].Value),
                     Convert.ToInt32(item.Cells["PrecioCompra"].Value),
                     Convert.ToInt32(item.Cells["PrecioVenta"].Value),
                     Convert.ToString(item.Cells["Ganancia"].Value)
                   );
            }
            return inventario;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<Inventario> detalle = new List<Inventario>();



            if (InventariodataGridView.DataSource != null)
            {
                detalle = (List<Inventario>)InventariodataGridView.DataSource;
            }




            if (string.IsNullOrEmpty(PrecioCompranumericUpDown.Text))
            {
                MessageBox.Show("el Precio de Compra esta Vacio, Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detalle.Add(
                    new Inventario(inventarioID: 0,
                     fecha: (DateTime)(FechadateTimePicker.Value),
                    articulo: (string)ArticulocomboBox.Text,
                        precioCompra: (int)Convert.ToInt32(PrecioCompranumericUpDown.Value),
                        precioVenta: (int)Convert.ToInt32(PrecioVentanumericUpDown.Value),
                        ganancia: (string)Convert.ToString(GananciatextBox.Text)));


                InventariodataGridView.DataSource = null;
                InventariodataGridView.DataSource = detalle;



                InventariodataGridView.Columns["ID"].Visible = false;
                InventariodataGridView.Columns["InventarioID"].Visible = false;
                InventariodataGridView.Columns["ArticulosID"].Visible = false;
                InventariodataGridView.Columns["Articulos"].Visible = false;



            }
        }

        private void GananciatextBox_TextChanged(object sender, EventArgs e)
        {
            int precioVenta = Convert.ToInt32(PrecioVentanumericUpDown.Value);
            int precioCompra = Convert.ToInt32(PrecioCompranumericUpDown.Value);

            if (PrecioCompranumericUpDown.Value != 0 && PrecioVentanumericUpDown.Value != 0)
            {
                GananciatextBox.Text = BLL.InventarioBLL.CalcularGanancia(precioVenta, precioCompra).ToString();

            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (InventariodataGridView.Rows.Count > 0
             && InventariodataGridView.CurrentRow != null)
            {

                List<Inventario> detalle = (List<Inventario>)InventariodataGridView.DataSource;



                detalle.RemoveAt(InventariodataGridView.CurrentRow.Index);










                InventariodataGridView.DataSource = null;
                InventariodataGridView.DataSource = detalle;


                InventariodataGridView.Columns["ID"].Visible = false;
                InventariodataGridView.Columns["InventarioID"].Visible = false;
                InventariodataGridView.Columns["ArticulosID"].Visible = false;
                InventariodataGridView.Columns["Articulos"].Visible = false;

            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            Inventario inventario = LlenaClase();
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InventarioIDnumericUpDown.Value == 0)
            {
                Paso = BLL.InventarioBLL.Guardar(inventario);
                InventarioerrorProvider.Clear();
            }
            else
            {
                var M = BLL.InventarioBLL.Buscar(Convert.ToInt32(InventarioIDnumericUpDown.Value));

                if (M != null)
                {
                    Paso = BLL.InventarioBLL.Modificar(inventario);
                }
                InventarioerrorProvider.Clear();
            }

            if (Paso)
            {

                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                InventarioIDnumericUpDown.Value = 0;
                FechadateTimePicker.Value = DateTime.Now;
                PrecioCompranumericUpDown.Value = 0;
                PrecioVentanumericUpDown.Value = 0;
                GananciatextBox.Clear();
                InventarioerrorProvider.Clear();
                InventariodataGridView.DataSource = null;
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            InventarioIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            PrecioCompranumericUpDown.Value = 0;
            PrecioVentanumericUpDown.Value = 0;
            GananciatextBox.Clear();
            InventarioerrorProvider.Clear();
            InventariodataGridView.DataSource = null;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarE())
            {


                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(InventarioIDnumericUpDown.Value);
                if (BLL.InventarioBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InventarioIDnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    PrecioCompranumericUpDown.Value = 0;
                    PrecioVentanumericUpDown.Value = 0;
                    GananciatextBox.Clear();
                    InventarioerrorProvider.Clear();
                    InventariodataGridView.DataSource = null;
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(InventarioIDnumericUpDown.Value);
            Inventario inventario = BLL.InventarioBLL.Buscar(id);

            if (inventario != null)
            {
                LlenarCampos(inventario);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

