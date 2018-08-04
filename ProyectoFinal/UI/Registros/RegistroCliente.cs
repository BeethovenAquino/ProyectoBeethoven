
using BLL;
using Entidades;
using System;

using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }


        private Cliente LlenarClase()
        {

            Cliente cliente = new Cliente();
           
            cliente.ClienteID = Convert.ToInt32(ClienteIDnumericUpDown.Value);
            cliente.NombreCliente = NombretextBox.Text;
            cliente.Cedula = CedulamaskedTextBox.Text;
            cliente.Direccion = (DirecciontextBox.Text);
            cliente.Telefono = (TelefonomaskedTextBox.Text);
            cliente.Total = Convert.ToInt32(TotalTextbox.Text.ToString());
            
            return cliente;
        }

        private bool Validar(int validar)
        {
            int num = 0;
            bool paso = false;
            if (validar == 1 && ClienteIDnumericUpDown.Value == 0)
            {
                ClienteerrorProvider.SetError(ClienteIDnumericUpDown, "Ingrese un ID");
                paso = true;

            }
            if (validar == 2 && NombretextBox.Text == string.Empty)
            {
                ClienteerrorProvider.SetError(NombretextBox, "Ingrese el Nombre");
                paso = true;
            }

            if (validar == 2 && !CedulamaskedTextBox.MaskFull)
            {
                ClienteerrorProvider.SetError(CedulamaskedTextBox, "Ingrese la Cedula");
                paso = true;
            }
            //if (validar == 4 && int.TryParse(CedulamaskedTextBox.Text, out num) == false)
            //{
            //    ClienteerrorProvider.SetError(CedulamaskedTextBox, "Debe de introducir un numero");
            //    paso = true;
            //}

            if (validar == 2 && DirecciontextBox.Text == string.Empty)
            {
                ClienteerrorProvider.SetError(DirecciontextBox, "Ingrese la Direccion");
                paso = true;
            }

            if (validar == 2 && !TelefonomaskedTextBox.MaskFull )
            {
                ClienteerrorProvider.SetError(TelefonomaskedTextBox, "Ingrese el Telefono");
                paso = true;
            }

            //if (validar == 4 && int.TryParse(TelefonomaskedTextBox.Text, out num) == false)
            //{
            //    ClienteerrorProvider.SetError(TelefonomaskedTextBox, "Debe de introducir un numero");
            //    paso = true;
            //}

            if (validar == 3 && int.TryParse(NombretextBox.Text, out num) == true)
            {
                ClienteerrorProvider.SetError(NombretextBox, "Debe Digitar Caracteres");
                paso = true;
            }
            if (validar == 3 && int.TryParse(DirecciontextBox.Text, out num) == true)
            {
                ClienteerrorProvider.SetError(DirecciontextBox, "Debe Digitar Caracteres");
                paso = true;
            }
            return paso;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Cliente cliente= LlenarClase();
            if (Validar(2))
            {

                MessageBox.Show("Llenar todos los campos marcados");
                return;
            }
            if (Validar(3))
            {

                MessageBox.Show("Debe introducir carateres");
                return;
            }
            if (Validar(4))
            {

                MessageBox.Show("Debe introducir numeros");
                return;
            }
            else
            {
                ClienteerrorProvider.Clear();
                if (ClienteIDnumericUpDown.Value == 0)
                {
                    paso = ClienteBLL.Guardar(cliente);
                }
                else
                {
                    var A = ClienteBLL.Buscar(Convert.ToInt32(ClienteIDnumericUpDown.Value));

                    if (A != null)
                    {
                        paso = ClienteBLL.Modificar(cliente);
                        MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClienteIDnumericUpDown.Value = 0;
                        NombretextBox.Clear();
                        CedulamaskedTextBox.Clear();
                        DirecciontextBox.Clear();
                        TelefonomaskedTextBox.Clear();
                        TotalTextbox.Clear();
                        ClienteerrorProvider.Clear(); ;
                    }
                }

                    if (paso)
                    {
                    
                        MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClienteIDnumericUpDown.Value = 0;
                            NombretextBox.Clear();
                            CedulamaskedTextBox.Clear();
                            DirecciontextBox.Clear();
                            TelefonomaskedTextBox.Clear();
                            TotalTextbox.Clear();
                            ClienteerrorProvider.Clear(); ;

                    }
                    else{ MessageBox.Show("No se pudo guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        
                }
              
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ClienteIDnumericUpDown.Value = 0;
            NombretextBox.Clear();
            CedulamaskedTextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
            TotalTextbox.Clear();
            ClienteerrorProvider.Clear();

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (Validar(1))
            {
                MessageBox.Show("Ingrese un ID");
                return;
            }

            int id = Convert.ToInt32(ClienteIDnumericUpDown.Value);

            if (BLL.ClienteBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClienteIDnumericUpDown.Value = 0;
                NombretextBox.Clear();
                CedulamaskedTextBox.Clear();
                DirecciontextBox.Clear();
                TelefonomaskedTextBox.Clear();
                TotalTextbox.Clear();
                
                ClienteerrorProvider.Clear();
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

            int id = Convert.ToInt32(ClienteIDnumericUpDown.Value);
            Cliente cliente = BLL.ClienteBLL.Buscar(id);

            if (cliente != null)
            {

                NombretextBox.Text = cliente.NombreCliente;
                CedulamaskedTextBox.Text = cliente.Cedula;
                DirecciontextBox.Text = cliente.Direccion;
                TelefonomaskedTextBox.Text = cliente.Telefono;
                TotalTextbox.Text = cliente.Total.ToString();
            }
            else
                MessageBox.Show("No se encontro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            TotalTextbox.Text = 0.ToString();
        }
    }
}
