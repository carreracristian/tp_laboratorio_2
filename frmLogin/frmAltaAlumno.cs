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
    public partial class frmAltaAlumno : Form
    {
        public frmAltaAlumno()
        {
            InitializeComponent();
        }
        private void frmAltaAlumno_Load(object sender, EventArgs e)
        {
           comboBoxParentesco.DataSource = Enum.GetValues(typeof(EParentesco));
            comboBox1.DataSource = Enum.GetValues(typeof(EColores));
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos del alumno
            string nombreAl=txtNombreAlumno.Text;
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
            txtLegajoAlumno.Clear();

            float precioCuota = 0;
            if (!float.TryParse(txtPrecioCuotaAlumno.Text, out precioCuota))
            {
                MessageBox.Show("Ingrese un precio valido.");
                return;
            }
            txtPrecioCuotaAlumno.Clear();

            bool femeninoAl=true;
            if (rbFemeninoAlumno.Checked)
                femeninoAl = true;
            else
                femeninoAl = false;

            EColores colores = (EColores)Enum.Parse(typeof(EColores), Convert.ToString(comboBox1.SelectedItem));
            //Obtenemos los datos del Responsable
            string nombreRes =txtNombreResponsable.Text;
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
            //Instanciamos responsable
            Responsable responsable = new Responsable(nombreRes, apellidoRes, dniRes, femeninoRes, parentesco, telefono);
            EstadosAplicacion.Responsables.Add(responsable);
            MessageBox.Show(responsable.ToString(), "Cantidad de responsables dados de alta: " + EstadosAplicacion.Responsables.Count);
            //Instanciamos alumno
            Alumno alumno = new Alumno(nombreAl, apellidoAl, dniAl, femeninoAl, precioCuota, responsable, legajo, colores);
            EstadosAplicacion.AlumnosSinAula.Add(alumno);
            MessageBox.Show(alumno.ToString(), "Cantidad de alumnos dados de alta: " + EstadosAplicacion.AlumnosSinAula.Count);
        }

        private void txtLegajoAlumno_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in EstadosAplicacion.AlumnosSinAula)
            {
                if (int.Parse(txtLegajoAlumno.Text) == item.legajo)
                    MessageBox.Show("Ya existe un alumno con ese legajo", "ERROR");
            }
        }

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
    }
}
