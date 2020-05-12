using System;
using System.Collections.Generic;
using System.Data;
using System.Linq; // Linq.U
using System.Windows.Forms;
using Entidades;
namespace frmLogin
{
    public partial class frmBusquedaDeAlumno : Form
    {
        public frmBusquedaDeAlumno()
        {
            InitializeComponent();
        }

        private void BtnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string apellidoRecibido = txtApellidoAlumno.Text.ToUpper();
            List<Alumno> alumnosObtenidos = new List<Alumno>();

            alumnosObtenidos.AddRange(EstadosAplicacion.AlumnosConAula.Where(x => x.Apellido.ToUpper().Contains(apellidoRecibido)));
            alumnosObtenidos.AddRange(EstadosAplicacion.AlumnosSinAula.Where(x => x.Apellido.ToUpper().Contains(apellidoRecibido)));

            cmbAlumnos.DataSource = alumnosObtenidos;
            cmbAlumnos.Text = string.Empty;
        }
    }
}
