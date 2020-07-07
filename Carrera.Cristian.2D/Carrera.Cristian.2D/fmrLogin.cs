using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera.Cristian._2D
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txtUsuario.Text is null) && !(txtContraseña.Text is null))
            {
                if ((txtUsuario.Text == "admin") && (txtContraseña.Text == "admin"))
                {
                    FrmPrincipal menuPrincipal = new FrmPrincipal();
                    FrmSecundario secundario = new FrmSecundario();
           
                    menuPrincipal.Show();
                    secundario.Show();
                }
                else
                {
                    MessageBox.Show("Error al loguearse!!", "ERROR");
                    return;
                }
            }
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
