using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace frmLogin
{
    public partial class frmAltaAlumno : Form
    {
        public frmAltaAlumno()
        {
            InitializeComponent();
        }
        #region Carga de datos a los combobox
        private void frmAltaAlumno_Load(object sender, EventArgs e)
        {
            comboBoxParentesco.DataSource = Enum.GetValues(typeof(EParentesco));
            comboBox1.DataSource = Enum.GetValues(typeof(EColores));
        }
        #endregion

        #region Obtencion y almacenamiento de los datos cargados

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos del alumno
            string nombreAl = txtNombreAlumno.Text;
            txtNombreAlumno.Clear();

            string apellidoAl = txtApellidoAlumno.Text;
            txtApellidoAlumno.Clear();

            int dniAl = 0;
            if (!int.TryParse(txtDniAlumno.Text, out dniAl))
            {
                MessageBox.Show("Ingrese un DNI valido.");
                return;
            }
            txtDniAlumno.Clear();

            int legajo = 0;
            if (!int.TryParse(txtLegajoAlumno.Text, out legajo))
            {
                MessageBox.Show("Ingrese un legajo valido.");
                return;
            }

            //  Verificamos si el legajo existe.
            if (LegajoExiste(legajo))
            {
                MessageBox.Show("El legajo se encuentra actualmente en uso.");
                return;// Salimos del metodo para evitar almacenar un alumno existente.
            }
            txtLegajoAlumno.Clear();

            float precioCuota = 0;
            if (!float.TryParse(txtPrecioCuotaAlumno.Text, out precioCuota))
            {
                MessageBox.Show("Ingrese un precio valido.");
                return;
            }
            txtPrecioCuotaAlumno.Clear();

            bool femeninoAl = true;
            if (rbFemeninoAlumno.Checked)
                femeninoAl = true;
            else
                femeninoAl = false;

            EColores colores = (EColores)Enum.Parse(typeof(EColores), Convert.ToString(comboBox1.SelectedItem));
            
            //Obtenemos los datos del Responsable
            string nombreRes = txtNombreResponsable.Text;
            txtNombreResponsable.Clear();

            string apellidoRes = txtApellidoResponsable.Text;
            txtApellidoResponsable.Clear();

            int dniRes = 0;
            if (!int.TryParse(txtDniResponsable.Text, out dniRes))
            {
                MessageBox.Show("Ingrese un DNI valido.");
                return;
            }
            txtDniResponsable.Clear();

            string telefono = txtNumeroResponsable.Text;
            txtNumeroResponsable.Clear();

            bool femeninoRes = true;
            if (rbFeemeninoResponsable.Checked)
                femeninoRes = true;
            else
                femeninoRes = false;

            EParentesco parentesco = (EParentesco)Enum.Parse(typeof(EParentesco), Convert.ToString(comboBoxParentesco.SelectedItem));
            //Instanciamos responsable y lo guardamos 
            Responsable responsable = new Responsable(nombreRes, apellidoRes, dniRes, femeninoRes, parentesco, telefono);
            EstadosAplicacion.Responsables.Add(responsable);
            MessageBox.Show(responsable.ToString(), "Cantidad de responsables dados de alta: " + EstadosAplicacion.Responsables.Count);
            //Instanciamos alumno y lo guardamos
            Alumno alumno = new Alumno(nombreAl, apellidoAl, dniAl, femeninoAl, precioCuota, responsable, legajo, colores);
            EstadosAplicacion.AlumnosSinAula.Add(alumno);
            MessageBox.Show(alumno.ToString(), "Cantidad de alumnos dados de alta: " + EstadosAplicacion.AlumnosSinAula.Count);
        }

        #endregion

        #region Metodos
        private bool LegajoExiste(int legajo)
        {
            foreach (var item in EstadosAplicacion.AlumnosConAula)
            {
                if (legajo == item.legajo)
                    return true;
            }

            foreach (var item in EstadosAplicacion.AlumnosSinAula)
            {
                if (legajo == item.legajo)
                    return true;
            }
            // Si no existe, false.
            return false;
        }
        #endregion

        #region Validacion de datos ingresados
        private void txtNombreAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtDniAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtNombreResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidoResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtDniResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtNumeroResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtPrecioCuotaAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosDecimales(e);
        }

        private void txtLegajoAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
        #endregion
    }
}
