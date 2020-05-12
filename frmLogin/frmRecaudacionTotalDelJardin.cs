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
    public partial class frmRecaudacionTotalDelJardin : Form
    {
        public frmRecaudacionTotalDelJardin()
        {
            InitializeComponent();
        }

        private void frmRecaudacionTotalDelJardin_Load(object sender, EventArgs e)
        {
            List<Aula> aulas = new List<Aula>();

            foreach (var item in EstadosAplicacion.Aulas)
            {
                aulas.Add(item);
            }

            listBox1.DataSource = aulas;

        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            float recaudacionTotal=0;

            foreach (var item in EstadosAplicacion.AlumnosSinAula)
            {
                recaudacionTotal += item.precioCuota;
            }

            txtRecaudacionTotal.Text = recaudacionTotal.ToString();
        }
    }
}
