using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if ((UsusariotextBox.Text == "Beethoven") && (ContraseñatextBox.Text == "081514"))
            {
                MainForm ver = new MainForm();
                ver.Show();
            }
            else
            {
                MessageBox.Show("Datos Inconrrectos!!", "Fallo",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
