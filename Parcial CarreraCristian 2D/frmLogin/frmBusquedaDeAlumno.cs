using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        #region Obtencion y exposicion de datos seleccionados
        private void BtnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string apellidoRecibido = txtApellidoAlumno.Text.ToUpper();
            List<Alumno> alumnosObtenidos = new List<Alumno>();
            foreach (var item in EstadosAplicacion.AlumnosSinAula)
            {
                if (item.Apellido.ToUpper().Contains(apellidoRecibido))
                    alumnosObtenidos.Add(item);
            }
            foreach (var item in EstadosAplicacion.AlumnosConAula)
            {
                if (item.Apellido.ToUpper().Contains(apellidoRecibido))
                    alumnosObtenidos.Add(item);
            }
            
            cmbAlumnos.DataSource = alumnosObtenidos;
            cmbAlumnos.Text = string.Empty;
        }
        #endregion
    }
}
