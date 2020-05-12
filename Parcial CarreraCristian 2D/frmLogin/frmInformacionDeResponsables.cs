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
    public partial class frmInformacionDeResponsables : Form
    {
        public frmInformacionDeResponsables()
        {
            InitializeComponent();
        }
        #region Carga de datos a herramientas del form
        private void frmInformacionDeResponsables_Load(object sender, EventArgs e)
        {
            List<Aula> lista = new List<Aula>();
            foreach (var item in EstadosAplicacion.Aulas)
            {
                lista.Add(item);
            }
            comboBoxSeleccionarAula.DataSource = lista;

        }
        #endregion

        #region Obtencion y exposicion de datos
        private void button1_Click(object sender, EventArgs e)
        {
            Aula aula = (Aula)comboBoxSeleccionarAula.SelectedItem;
            List<string> responsable = new List<string>();
            foreach (var item in aula.Alumnos)
            {
                responsable.Add($"Apellido:{item.Responsable.Apellido}" +
                    $" Nombre:{item.Responsable.Nombre} Telefono:{item.Responsable.telefono}");
            }
            listBoxResponsables.DataSource = responsable;
        }
        #endregion
    }
}
