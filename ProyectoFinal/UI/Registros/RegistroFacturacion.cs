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
    public partial class RegistroFacturacion : Form
    {
        public RegistroFacturacion()
        {
            InitializeComponent();
            LlenarComboBox();
        }


        private void LlenarCampos(Facturacion facturacion)
        {

            FacturaIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportetextBox.Clear();
            MontonumericUpDown.Value = 0;
            DevueltatextBox.Clear();
            SubtotaltextBox.Clear();
            TotaltextBox.Clear();



            FacturaIDnumericUpDown.Value = facturacion.FacturaID;
            VentacomboBox.Text = facturacion.Venta;
            FechadateTimePicker.Value = facturacion.Fecha;
            SubtotaltextBox.Text = facturacion.Subtotal.ToString();
            TotaltextBox.Text = facturacion.Total.ToString();






            //Cargar el detalle al Grid
            FacturacionerrorProvider.DataSource = facturacion.Detalle;
            FacturaciondataGridView.Columns["ID"].Visible = false;
            FacturaciondataGridView.Columns["FacturaID"].Visible = false;
            FacturaciondataGridView.Columns["ClienteID"].Visible = false;
            FacturaciondataGridView.Columns["ArticulosID"].Visible = false;
            FacturaciondataGridView.Columns["Articulos"].Visible = false;
        }

        private void LlenarComboBox()
        {
            Repositorio<Articulos> repositorio = new Repositorio<Articulos>(new Contexto());
            Repositorio<Cliente> repositori = new Repositorio<Cliente>(new Contexto());

            ArticulocomboBox.DataSource = repositorio.GetList(c => true);
            ArticulocomboBox.ValueMember = "ArticuloID";
            ArticulocomboBox.DisplayMember = "NombreCliente";

            ClientecomboBox.DataSource = repositori.GetList(c => true);
            ClientecomboBox.ValueMember = "ClienteID";
            ClientecomboBox.DisplayMember = "NombreCliente";



        }
        private bool Validar()
        {
            bool paso = false;

            if (CantidadnumericUpDown.Value == 0)
            {
                FacturacionerrorProvider.SetError(CantidadnumericUpDown,
                   "No debes dejar la Cantidad Vacia ");
                paso = true;
            }

            if (MontonumericUpDown.Value == 0)
            {
                FacturacionerrorProvider.SetError(MontonumericUpDown,
                   "No debes dejar el monto Vacio ");
                paso = true;
            }

            if (PrecionumericUpDown.Value == 0)
            {
                FacturacionerrorProvider.SetError(PrecionumericUpDown,
                   "No debes dejar el precio Vacio ");
                paso = true;
            }

            if (FacturaciondataGridView.RowCount == 0)
            {
                FacturacionerrorProvider.SetError(FacturaciondataGridView,
                    "Es obligatorio Agregar un Articulo ");
                paso = true;
            }

            return paso;
        }

        private bool ValidarE()
        {
            bool paso = false;



            if (FacturaIDnumericUpDown.Value == 0)
            {
                FacturacionerrorProvider.SetError(FacturaIDnumericUpDown,
                   "Llene el campo");
                paso = true;
            }


            return paso;


        }

        private Facturacion LlenaClase()
        {
            Facturacion facturacion = new Facturacion();

            facturacion.FacturaID = Convert.ToInt32(FacturaIDnumericUpDown.Value);
            facturacion.Venta = Convert.ToString(VentacomboBox.SelectedValue);
            facturacion.Fecha = FechadateTimePicker.Value;
            facturacion.Subtotal = SubtotaltextBox.Text;
            facturacion.Total = TotaltextBox.Text;





            foreach (DataGridViewRow item in FacturaciondataGridView.Rows)
            {

                facturacion.AgregarDetalle
                    (Convert.ToInt32(item.Cells["ID"].Value),
                    Convert.ToInt32(item.Cells["FacturaID"].Value),
                    Convert.ToInt32(item.Cells["ClienteID"].Value),
                    Convert.ToString(item.Cells["Cliente"].Value),
                    Convert.ToInt32(item.Cells["ArticuloID"].Value),
                    Convert.ToString(item.Cells["Articulo"].Value),
                    Convert.ToInt32(item.Cells["Cantidad"].Value),
                    Convert.ToInt32(item.Cells["Precio"].Value),
                    Convert.ToInt32(item.Cells["Importe"].Value),
                    Convert.ToInt32(item.Cells["Monto"].Value),
                    Convert.ToString(item.Cells["devuelta"].Value)

                  );
            }
            return facturacion;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<FacturacionDetalle> detalle = new List<FacturacionDetalle>();



            if (FacturaciondataGridView.DataSource != null)
            {
                detalle = (List<FacturacionDetalle>)FacturaciondataGridView.DataSource;
            }



            if (string.IsNullOrEmpty(ImportetextBox.Text))
            {
                MessageBox.Show("Importe esta vacio , Llene cantidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                detalle.Add(
                    new FacturacionDetalle(iD: 0,
                    facturaID: (int)Convert.ToInt32(FacturaIDnumericUpDown.Value),
                    clienteID: (int)ClientecomboBox.SelectedValue,
                       cliente: (string)ClientecomboBox.Text,
                            articuloID: (int)ArticulocomboBox.SelectedIndex,
                            articulo: (string)ArticulocomboBox.Text,

                        cantidad: (int)Convert.ToInt32(CantidadnumericUpDown.Value),
                        precio: (int)Convert.ToInt32(PrecionumericUpDown.Value),
                        importe: (int)Convert.ToInt32(ImportetextBox.Text),
                        monto: (int)Convert.ToInt32(MontonumericUpDown.Value),
                        devuelta: (string)Convert.ToString(DevueltatextBox.Text)

                    ));


                FacturaciondataGridView.DataSource = null;
                FacturaciondataGridView.DataSource = detalle;



                FacturaciondataGridView.Columns["ID"].Visible = false;
                FacturaciondataGridView.Columns["FacturaID"].Visible = false;
                FacturaciondataGridView.Columns["ClienteID"].Visible = false;
                FacturaciondataGridView.Columns["ArticulosID"].Visible = false;
                FacturaciondataGridView.Columns["Articulos"].Visible = false;

                int subtotal = 0;
                foreach (var item in detalle)
                {
                    subtotal += item.Importe;

                }

                SubtotaltextBox.Text = subtotal.ToString();

                int total = 0;


                total += Convert.ToInt32(SubtotaltextBox.Text);

                TotaltextBox.Text = total.ToString();

            }
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            int precio = Convert.ToInt32(PrecionumericUpDown.Value);


            ImportetextBox.Text = BLL.FacturacionBLL.CalcularImporte(precio, cantidad).ToString();
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            int precio = Convert.ToInt32(PrecionumericUpDown.Value);


            ImportetextBox.Text = BLL.FacturacionBLL.CalcularImporte(precio, cantidad).ToString();
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (FacturaciondataGridView.Rows.Count > 0
              && FacturaciondataGridView.CurrentRow != null)
            {

                List<FacturacionDetalle> detalle = (List<FacturacionDetalle>)FacturaciondataGridView.DataSource;



                detalle.RemoveAt(FacturaciondataGridView.CurrentRow.Index);


                int subtotal = 0;
                int total = 0;

                foreach (var item in detalle)
                {
                    subtotal += item.Importe;
                }

                SubtotaltextBox.Text = subtotal.ToString();

                total += Convert.ToInt32(SubtotaltextBox.Text);

                TotaltextBox.Text = total.ToString();








                FacturaciondataGridView.DataSource = null;
                FacturaciondataGridView.DataSource = detalle;


                FacturaciondataGridView.Columns["ID"].Visible = false;
                FacturaciondataGridView.Columns["FacturaID"].Visible = false;
                FacturaciondataGridView.Columns["ClienteID"].Visible = false;
                FacturaciondataGridView.Columns["ArticulosID"].Visible = false;
                FacturaciondataGridView.Columns["Articulos"].Visible = false;

            }
        }

        private void DevueltatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MontonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(PrecionumericUpDown.Value);
            int monto = Convert.ToInt32(MontonumericUpDown.Value);


            DevueltatextBox.Text = BLL.FacturacionBLL.CalcularDevuelta(precio, monto).ToString();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            FacturaIDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportetextBox.Clear();
            MontonumericUpDown.Value = 0;
            DevueltatextBox.Clear();
            SubtotaltextBox.Clear();
            TotaltextBox.Clear();
            FacturacionerrorProvider.Clear();
            FacturaciondataGridView.DataSource = null;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = LlenaClase();
            bool Paso = false;

            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (FacturaIDnumericUpDown.Value == 0)
            {
                Paso = BLL.FacturacionBLL.Guardar(facturacion);
                FacturacionerrorProvider.Clear();
            }
            else
            {
                var M = BLL.FacturacionBLL.Buscar(Convert.ToInt32(FacturaIDnumericUpDown.Value));

                if (M != null)
                {
                    Paso = BLL.FacturacionBLL.Modificar(facturacion);
                }
                FacturacionerrorProvider.Clear();
            }

            if (Paso)
            {

                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FacturaIDnumericUpDown.Value = 0;
                FechadateTimePicker.Value = DateTime.Now;
                CantidadnumericUpDown.Value = 0;
                PrecionumericUpDown.Value = 0;
                ImportetextBox.Clear();
                MontonumericUpDown.Value = 0;
                DevueltatextBox.Clear();
                SubtotaltextBox.Clear();
                TotaltextBox.Clear();
                FacturacionerrorProvider.Clear();
                FacturaciondataGridView.DataSource = null;
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarE())
            {


                MessageBox.Show("Favor Llenar Casilla!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                int id = Convert.ToInt32(FacturaIDnumericUpDown.Value);
                if (BLL.FacturacionBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FacturaIDnumericUpDown.Value = 0;
                    FechadateTimePicker.Value = DateTime.Now;
                    CantidadnumericUpDown.Value = 0;
                    PrecionumericUpDown.Value = 0;
                    ImportetextBox.Clear();
                    MontonumericUpDown.Value = 0;
                    DevueltatextBox.Clear();
                    SubtotaltextBox.Clear();
                    TotaltextBox.Clear();
                    FacturacionerrorProvider.Clear();
                    FacturaciondataGridView.DataSource = null;
                }
                else
                    MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(FacturaIDnumericUpDown.Value);
            Facturacion facturacion = BLL.FacturacionBLL.Buscar(id);

            if (facturacion != null)
            {
                LlenarCampos(facturacion);

            }
            else
                MessageBox.Show("No se encontro!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VentacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VentacomboBox.SelectedIndex == 0)
            {
                ClientecomboBox.Enabled = false;
            }
            else { ClientecomboBox.Enabled = true; }
        }
    }
}