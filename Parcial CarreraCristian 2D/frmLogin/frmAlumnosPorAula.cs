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
    public partial class frmAlumnosPorAula : Form
    {
        public frmAlumnosPorAula()
        {
            InitializeComponent();
        }
        #region Carga de datos a herramientas del form
        private void frmAlumnosPorAula_Load(object sender, EventArgs e)
        {
            List<Aula> aulas = new List<Aula>();
            foreach (var item in EstadosAplicacion.Aulas)
            {
                aulas.Add(item);
            }
            cmbAulas.DataSource = aulas;
        }
        #endregion

        #region Obtencion y exposicion de datos seleccionados
        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            Aula aula = (Aula)cmbAulas.SelectedItem;

            List<string> alumnos = new List<string>();
            foreach (var item in aula.Alumnos)
            {
                alumnos.Add($"Legajo: {item.legajo}  Apellido: {item.Apellido}  Nombre: {item.Nombre}");
            }
            listBox1.DataSource = alumnos;
        }
        #endregion
    }
}
