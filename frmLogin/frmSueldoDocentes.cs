using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class frmSueldoDocentes : Form
    {
        public frmSueldoDocentes()
        {
            InitializeComponent();
        }

        private void frmSueldoDocentes_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (var item in EstadosAplicacion.Profesores)
            {
                lista.Add($"{item.Nombre} {item.Apellido} {item.CalcularSalario()}");
            }
            listBox1.DataSource = lista;
        }

        private void btnCalcularSueldos_Click(object sender, EventArgs e)
        {
            double salarios=0;
            foreach (var item in EstadosAplicacion.Profesores)
            {
                salarios += item.CalcularSalario();
            }
            txtTotalDeSueldos.Text =Convert.ToString(salarios);
        }
    }
}
