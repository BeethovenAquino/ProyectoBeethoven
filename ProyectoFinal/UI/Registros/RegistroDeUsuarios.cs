using BLL;
using Entidades;
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
    public partial class RegistroDeUsuarios : Form
    {
        public RegistroDeUsuarios()
        {
            InitializeComponent();
        }


        private bool validar(int error)
        {
            bool errores = false;
            int num = 0;
            if (error == 1 && usuariosIdNumericUpDown.Value == 0)
            {
                UsuarioerrorProvider.SetError(usuariosIdNumericUpDown, "Llenar Usuario Id");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                UsuarioerrorProvider.SetError(nombreTextBox, "Llene Nombre");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                UsuarioerrorProvider.SetError(usuarioTextBox, "Llene Usuario");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(contraseñaTextBox.Text))
            {
                UsuarioerrorProvider.SetError(contraseñaTextBox, "Llene contraseña");
                errores = true;
            }

            if (error == 2 && string.IsNullOrWhiteSpace(ConfirmartextBox.Text))
            {
                UsuarioerrorProvider.SetError(ConfirmartextBox, "Llene contraseña");
                errores = true;
            }

            
            if (error == 3 && int.TryParse(nombreTextBox.Text, out num) == true)
            {
                UsuarioerrorProvider.SetError(nombreTextBox, "Debe Digitar Caracteres");
                errores = true;
            }

            if (error == 4 && contraseñaTextBox.Text != ConfirmartextBox.Text)
            {
                UsuarioerrorProvider.SetError(ConfirmartextBox, "Llenar Confirmar Contraseña");
                errores = true;
            }
            
            return errores;

        }

        private Usuarios Llenaclase()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.UsuariosId = Convert.ToInt32(usuariosIdNumericUpDown.Value);
            usuarios.Nombre = nombreTextBox.Text;
            usuarios.Usuario = usuarioTextBox.Text;
            usuarios.Contraseña = contraseñaTextBox.Text;
        
            return usuarios;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {

            usuariosIdNumericUpDown.Value = 0;
            nombreTextBox.Clear();
            usuarioTextBox.Clear();
            contraseñaTextBox.Clear();
            ConfirmartextBox.Clear();
            UsuarioerrorProvider.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Usuarios usuarios = Llenaclase();
            int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);



            if (validar(3))
            {
                MessageBox.Show("Favor Dijite un Nombre");
                return;
            }
            if (validar(4))
            {
                MessageBox.Show("La Contraseña no son Iguales", "Validacion");
                contraseñaTextBox.Clear();
                ConfirmartextBox.Clear();
                return;
            }

            if (validar(2))
            {
                MessageBox.Show("Favor de Llenar las Casillas");
            }
            else
            {
                if (usuariosIdNumericUpDown.Value == 0)
                {
                    paso = UsusariosBLL.Guardar(usuarios);
                }
                else
                {

                    var usuario = UsusariosBLL.Buscar(id);

                    if (usuario != null)
                    {
                        paso = BLL.UsusariosBLL.Editar(usuarios);
                    }
                    else
                        MessageBox.Show("Id no existe", "Falló",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                usuariosIdNumericUpDown.Value = 0;
                nombreTextBox.Clear();
                usuarioTextBox.Clear();
                contraseñaTextBox.Clear();
                ConfirmartextBox.Clear();
                UsuarioerrorProvider.Clear();
                
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

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar casilla para poder Eliminar");
            }
            else
            {
                int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);

                if (UsusariosBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    usuariosIdNumericUpDown.Value = 0;
                    nombreTextBox.Clear();
                    usuarioTextBox.Clear();
                    contraseñaTextBox.Clear();
                    ConfirmartextBox.Clear();
                    UsuarioerrorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No Pudo Eliminar!", "Fallido!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UsuarioerrorProvider.Clear();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar(1))
            {
                MessageBox.Show("Favor de Llenar Casilla para poder Buscar");
            }
            else
            {
                int id = Convert.ToInt32(usuariosIdNumericUpDown.Value);
                Usuarios usuarios = BLL.UsusariosBLL.Buscar(id);

                if (usuarios != null)
                {
                    usuariosIdNumericUpDown.Value = usuarios.UsuariosId;
                    nombreTextBox.Text = usuarios.Nombre;
                    usuarioTextBox.Text = usuarios.Usuario;
                    contraseñaTextBox.Text = usuarios.Contraseña;
                    

                }
                else
                {
                    MessageBox.Show("No Fue Encontrado!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UsuarioerrorProvider.Clear();
            }
        }
    }
}
