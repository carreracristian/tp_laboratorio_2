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
        #region Carga de datos a herramientas del from
        private void frmSueldoDocentes_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (var item in EstadosAplicacion.ProfesoresSinaulas)
            {
                lista.Add($"{item.Nombre} {item.Apellido} {item.CalcularSalario()}");
            }
            listBox1.DataSource = lista;
        }
        #endregion

        #region Obtencion y exposicion de datos
        private void btnCalcularSueldos_Click(object sender, EventArgs e)
        {
            double salarios=0;
            foreach (var item in EstadosAplicacion.ProfesoresSinaulas)
            {
                salarios += item.CalcularSalario();
            }
            txtTotalDeSueldos.Text =Convert.ToString(salarios);
            double salarios1 = 0;
            foreach (var item in EstadosAplicacion.ProfesoresConaulas)
            {
                salarios1 += item.CalcularSalario();
            }
            txtTotalDeSueldos.Text = Convert.ToString(salarios);
        }
        #endregion
    }
}
