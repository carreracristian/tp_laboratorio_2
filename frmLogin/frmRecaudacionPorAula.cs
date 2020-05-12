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
    public partial class frmRecaudacionPorAula : Form
    {
        public frmRecaudacionPorAula()
        {
            InitializeComponent();
        }

        private void frmRecaudacionPorAula_Load(object sender, EventArgs e)
        {
            List<Aula> lista = new List<Aula>();
            foreach (var item in EstadosAplicacion.Aulas)
            {
                lista.Add(item);
            }
            comboBoxSeleccionColorAulaParaRecaudacion.DataSource = lista;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aula aula = (Aula)(comboBoxSeleccionColorAulaParaRecaudacion.SelectedItem);

            double recaudacion = 0;

            foreach (var item in aula.Alumnos)
            {
                recaudacion += item.precioCuota;
            }
            txtRecaudacionDeAula.Text = Convert.ToString(recaudacion);
        }
    }
}
