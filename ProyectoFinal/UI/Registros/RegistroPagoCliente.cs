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
      
        public RegistroPagoCliente()
        {
            InitializeComponent();
        }
        private void Consultabutton_Click(object sender, EventArgs e)
        {

            if (SetError(4))
            {
                MessageBox.Show("Debe introducir porque filtro va a consultar", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            Expression<Func<Cliente, bool>> filtrar = x => true;

            switch (FiltrarcomboBox.SelectedIndex)
            {

                case 0://ClienteID

                    if (Validar(1))
                    {
                        MessageBox.Show("Favor Llenar Casilla ", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (Validar(2))
                    {
                        MessageBox.Show("Debe Digitar un Numero!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (BLL.ClienteBLL.GetList(filtrar).Count() == 0)
                        {
                            MessageBox.Show(" No Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            return;
                        }
                    }

                    break;

            }

            if (FiltrarcomboBox.SelectedItem != null)
            {
                ConsultadataGridView.DataSource = ClienteBLL.GetList(filtrar);

                if (FiltrarcomboBox.SelectedIndex == 0)
                {
                    foreach (var item in ClienteBLL.GetList(filtrar))
                    {

                        DeudanumericUpDown.Value = item.Total - AbonadonumericUpDown.Value;
                        AbonadonumericUpDown.Text = item.Total.ToString();
                        
                    }
                }
                
                CriteriotextBox.Clear();
                ClienteerrorProvider.Clear();
                //ConsultadataGridView.Columns["InversionID"].Visible = false;

            }
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

            if (error == 4 && FiltrarcomboBox.SelectedIndex == 0)
            {
                ClienteerrorProvider.SetError(FiltrarcomboBox, "Debe introducir porque filtro va a consultar");
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
            List<Cliente> detalle = (List<Cliente>)ConsultadataGridView.DataSource;

            int id = detalle.ElementAt(ConsultadataGridView.CurrentRow.Index).ClienteID;

            
            pagos.PagoID = Convert.ToInt32(PagoIDnumericUpDown.Value);
            pagos.InversionID = 1;
            pagos.Fecha = FechadateTimePicker.Value;
            pagos.Abono = Convert.ToInt32(AbonadonumericUpDown.Value);
            pagos.ClienteID = Convert.ToInt32(id);
            pagos.Deuda = Convert.ToInt32(AbonadonumericUpDown.Value);


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
            AbonadonumericUpDown.Value = 0;
            DeudanumericUpDown.Value = 0;

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
                    AbonadonumericUpDown.Value = 0;
                    DeudanumericUpDown.Value = 0;
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
                    AbonadonumericUpDown.Value = 0;
                    DeudanumericUpDown.Value = 0;
                }
                ClienteerrorProvider.Clear();
            }
        }

        private void LlenaCampos(Pagos cobros)
        {

            PagoIDnumericUpDown.Value = cobros.PagoID;
            AbonadonumericUpDown.Value = cobros.Abono;

           ConsultadataGridView.DataSource = BLL.ClienteBLL.GetList(x => x.ClienteID == cobros.ClienteID);

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



            //ConsultadataGridView.Columns["InversionID"].Visible = false;
            //ConsultadataGridView.Columns["Detalle"].Visible = false;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(5))
            {
                MessageBox.Show("Debe de Dijitar un Monto!", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Pagos cobros = Llenaclase();
                bool paso = false;
                if (PagoIDnumericUpDown.Value == 0)
                {
                    paso = BLL.PagosBLL.Guardar(Llenaclase());
                }
                else
                {
                    int id = Convert.ToInt32(PagoIDnumericUpDown.Value);
                    var entry = BLL.PagosBLL.Buscar(id);

                    if (entry != null)
                    {
                        paso = BLL.PagosBLL.Editar(Llenaclase());
                    }
                    else
                    {
                        MessageBox.Show("Id no existe", "Falló",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                PagoIDnumericUpDown.Value = 0;
                FiltrarcomboBox.SelectedItem = null;
                ConsultadataGridView.DataSource = null;
                CriteriotextBox.Clear();
                DesdedateTimePicker.Value = DateTime.Now;
                HastadateTimePicker.Value = DateTime.Now;
                AbonadonumericUpDown.Value = 0;
                DeudanumericUpDown.Value = 0;
                ClienteerrorProvider.Clear();
                if (paso)
                {
                    MessageBox.Show("Guardado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No pudo Guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AbonadonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }

}

