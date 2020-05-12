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
    public partial class frmAltaNoDocente : Form
    {
        public frmAltaNoDocente()
        {
            InitializeComponent();
        }
        private void frmAltaNoDocente_Load(object sender, EventArgs e)
        {
            comboBoxEcargo.DataSource = Enum.GetValues(typeof(ECargo));
        }
        private void GuardarNoDocente_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos
            string nombre = txtNombreAltaNoDocente.Text;
            txtNombreAltaNoDocente.Clear();

            string apellido = txtApellidoAltaNoDocente.Text;
            txtApellidoAltaNoDocente.Clear();

            int dni = 0;
            if (!int.TryParse(txtDniAltaNoDocente.Text, out dni))
            {
                MessageBox.Show("Ingrese un DNI valido.");
                return;
            }
            int valorTxtIngreso = 0;
            int valorTxtEgreso = 0;

            if (!int.TryParse(txtHoraIngresoNoDocente.Text, out valorTxtIngreso))
            {
                MessageBox.Show("Ingrese una hora de ingreso valida.");
                return;
            }

            if (!int.TryParse(txtHoraSalidaNoDocente.Text, out valorTxtEgreso))
            {
                MessageBox.Show("Ingrese una hora de ingreso valida.");
                return;
            }

            DateTime horaEntrada = new DateTime().AddHours(valorTxtIngreso);
            DateTime horaSalida = new DateTime().AddHours(valorTxtEgreso);
            txtHoraIngresoNoDocente.Clear();
            txtHoraSalidaNoDocente.Clear();

            bool femenino;
            if (rbFemenino.Checked)
                femenino = true;
            else
                femenino = false;

            ECargo cargo = (ECargo)Enum.Parse(typeof(ECargo), Convert.ToString(comboBoxEcargo.SelectedItem));
            
            Administrativo administrativo = new Administrativo(nombre, apellido, dni, femenino, horaEntrada, horaSalida, cargo);
            EstadosAplicacion.Administrativos.Add(administrativo);
            MessageBox.Show(administrativo.ToString(), "Cantidad de no docentes dados de alta: " + EstadosAplicacion.Administrativos.Count);
        }

        private void txtNombreAltaNoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtApellidoAltaNoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void txtDniAltaNoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtHoraIngresoNoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtHoraSalidaNoDocente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void txtHoraSalidaNoDocente_TextChanged(object sender, EventArgs e)
        {
            //if (int.Parse(txtHoraSalidaNoDocente.Text) < int.Parse(txtHoraIngresoNoDocente.Text))
                MessageBox.Show("La hora de salida no puede ser antes de la entrada", "ERROR");
        }
    }
}
