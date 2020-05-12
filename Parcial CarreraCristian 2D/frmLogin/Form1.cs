using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace frmLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txtUsuario.Text is null) && !(txtContraseña.Text is null))
            {
                if ((txtUsuario.Text == "admin") && (txtContraseña.Text == "admin"))
                {
                    frmMenuPrincipal menuPrincipal = new frmMenuPrincipal();
                    menuPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Error al loguearse!!","ERROR");
                    return;
                }
            }
           
        }
    }
}
