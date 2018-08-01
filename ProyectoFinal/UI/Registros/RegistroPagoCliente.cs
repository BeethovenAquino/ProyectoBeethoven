using BLL;
using Entidades;

using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroPagoCliente : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public RegistroPagoCliente()
        {
            InitializeComponent();
        }
        Expression<Func<Cliente, bool>> filtrar = x => true;

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            int id;
            switch (FiltrarcomboBox.SelectedIndex)
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
                    filtrar = t => t.ClienteID == id;
                    break;
                //Nombre
                case 1:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.NombreCliente.Contains(CriteriotextBox.Text);
                    break;

                //Direccion
                case 2:
                    LimpiarError();
                    if (SetError(2))
                    {
                        MessageBox.Show("Introduce un caracter");
                        return;
                    }
                    filtrar = t => t.Direccion == CriteriotextBox.Text;
                    break;
                //Cedula
                case 3:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    filtrar = t => t.Cedula == CriteriotextBox.Text;
                    break;
                //Telefono
                case 4:
                    LimpiarError();
                    if (SetError(1))
                    {
                        MessageBox.Show("Introduce un numero");
                        return;

                    }
                    filtrar = t => t.Telefono == CriteriotextBox.Text;
                    break;
                //Listar Todo
                case 5:

                    filtrar = t => true;
                    break;
            }

            clientes = ClienteBLL.GetList(filtrar);

            ConsultadataGridView.DataSource = clientes;
        }

        private bool SetError(int error)
        {
            bool paso = false;
            int ejem = 0;
            if (error == 1 && int.TryParse(CriteriotextBox.Text, out ejem) == false)
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Debe de introducir un numero");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out ejem) == true)
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Debe de introducir un caracter");
                paso = true;
            }

            return paso;
        }

        private void LimpiarError()
        {
            ClienteerrorProvider.Clear();
        }

        private Pagos Llenaclase()
        {
            Pagos pagos = new Pagos();
            List<Facturacion> detalle = (List<Facturacion>)ConsultadataGridView.DataSource;

            int id = detalle.ElementAt(ConsultadataGridView.CurrentRow.Index).FacturaID;


            pagos.PagoID = Convert.ToInt32(PagoIDnumericUpDown.Value);
            pagos.InversionID = 1;
            pagos.Fecha = FechadateTimePicker.Value;
            pagos.Abono = Convert.ToDecimal(AbonadotextBox.Text);
            pagos.FacturaID = Convert.ToInt32(id);


            return pagos;
        }

        private bool Validar(int error)
        {
            bool paso = false;
            int num = 0;

            if (error == 1 && string.IsNullOrEmpty(CriteriotextBox.Text))
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Por Favor, LLenar Casilla!");
                paso = true;
            }
            if (error == 2 && int.TryParse(CriteriotextBox.Text, out num) == false)
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Debe Digitar un Numero");
                paso = true;
            }

            if (error == 3 && int.TryParse(CriteriotextBox.Text, out num) == true)
            {
                ClienteerrorProvider.SetError(CriteriotextBox, "Debe Digitar Caracteres");
                paso = true;
            }

            if (error == 4 && PagoIDnumericUpDown.Value == 0)
            {
                ClienteerrorProvider.SetError(PagoIDnumericUpDown, "Llenar Pago Id ");
                paso = true;
            }

            if (error == 5 && int.TryParse(AbonadotextBox.Text, out num) == false)
            {
                ClienteerrorProvider.SetError(AbonadotextBox, "Debe Digitar numeros");
                paso = true;
            }
            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            PagoIDnumericUpDown.Value = 0;
            FiltrarcomboBox.SelectedItem = null;
            ConsultadataGridView.DataSource = null;
            CriteriotextBox.Clear();
            DesdedateTimePicker.Value = DateTime.Now;
            HastadateTimePicker.Value = DateTime.Now;
            AbonadotextBox.Clear();
            DeudatextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(4))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(PagoIDnumericUpDown.Value);

                if (BLL.PagosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PagoIDnumericUpDown.Value = 0;
                    FiltrarcomboBox.SelectedItem = null;
                    ConsultadataGridView.DataSource = null;
                    CriteriotextBox.Clear();
                    DesdedateTimePicker.Value = DateTime.Now;
                    HastadateTimePicker.Value = DateTime.Now;
                    AbonadotextBox.Clear();
                    DeudatextBox.Clear();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClienteerrorProvider.Clear();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(4))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = Convert.ToInt32(PagoIDnumericUpDown.Value);
                Pagos cobros = BLL.PagosBLL.Buscar(id);
                

                if (cobros != null)
                {

                    LlenaCampos(cobros);


                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PagoIDnumericUpDown.Value = 0;
                    FiltrarcomboBox.SelectedItem = null;
                    ConsultadataGridView.DataSource = null;
                    CriteriotextBox.Clear();
                    DesdedateTimePicker.Value = DateTime.Now;
                    HastadateTimePicker.Value = DateTime.Now;
                    AbonadotextBox.Clear();
                    DeudatextBox.Clear();
                }
                ClienteerrorProvider.Clear();
            }
        }

        private void LlenaCampos(Pagos cobros)
        {

            PagoIDnumericUpDown.Value = cobros.PagoID;
            AbonadotextBox.Text = cobros.Abono.ToString();

           ConsultadataGridView.DataSource = BLL.FacturacionBLL.GetList(x => x.FacturaID == cobros.FacturaID);

            //foreach (var item in BLL.FacturacionBLL.GetList(x => x.ReciboId == cobros.ReciboId))
            //{

            //    deudatextBox.Text = (quincenas(item.Fecha, item.MontoTotal) - item.Abono).ToString();
            //    AbonostextBox.Text = item.Abono.ToString();



            //    DateTime FechaAct = fechaDateTimePicker.Value;
            //    DateTime FechaEmpeño = item.UltimaFechadeVigencia;
            //    if (FechaAct >= FechaEmpeño)
            //    {
            //        estadolabel.Text = "Vencido";
            //        estadolabel.ForeColor = Color.Red;
            //    }
            //    else
            //    {

            //        estadolabel.Text = "Vigente";
            //        estadolabel.ForeColor = Color.Green;
            //    }


            //}



            ConsultadataGridView.Columns["InversionID"].Visible = false;
            //ConsultadataGridView.Columns["Detalle"].Visible = false;

        }




    }

}

