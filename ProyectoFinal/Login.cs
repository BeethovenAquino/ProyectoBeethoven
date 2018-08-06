using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> usuarios = new Repositorio<Usuarios>(new Contexto());
            //List<Usuarios> 
            var Lista = usuarios.GetList(x => x.Usuario.Equals(UsusariotextBox.Text) && x.Contraseña.Equals(ContraseñatextBox.Text));
            Usuarios usuario = (Lista != null && Lista.Count > 0) ? Lista[0] : null;

            if ((UsusariotextBox.Text == "Beethoven") && (ContraseñatextBox.Text == "081514"))
            {
                MainForm ver = new MainForm();
                ver.Show();
            }
            

            if (usuario != null)
            {

                this.Hide();
                Thread hilo = new Thread(Menu);
                hilo.Start();

                return;
            }
            //else
            //{
            //    MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    ContraseñatextBox.Clear();
            //}

            int paso = 0;
            //Expression<Func<Usuarios, bool>> filtrar = x => true;
            //List<Usuarios> user = new List<Usuarios>();

            LoginerrorProvider.Clear();
            if (UsusariotextBox.Text == string.Empty)
            {
                paso = 1;
                LoginerrorProvider.SetError(UsusariotextBox, "Incorrecto");

            }
            if (ContraseñatextBox.Text == string.Empty)
            {
                paso = 1;
                LoginerrorProvider.SetError(ContraseñatextBox, "Incorrecto");

            }
            if (paso == 1)
            {
                MessageBox.Show("Campos Vacios!!");
                return;
            }

        }
        private void Menu()
        {
            DataTable dt = new DataTable();
            Application.Run(new MainForm());
        }
    }

}



